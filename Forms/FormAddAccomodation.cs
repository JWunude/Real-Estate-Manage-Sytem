using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lems.Forms
{
    public partial class FormAddAccomodation : Form
    {
        private readonly MaangeAccomodationInfo _parent;

        SqlConnection conHelper = new SqlConnection(Helper.ConnectionString);

        public string strACID, strAcDescription, strPropID, strACNumber, strAmtPerMonth, strAmtPerYear, strACStatus, strRemarks;
        static double yearlyPayment = 0;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public FormAddAccomodation(MaangeAccomodationInfo Parent)
        {
            InitializeComponent();
            _parent = Parent;
            GenerateACID();
            //monthlyPayment =Convert.ToDouble(txtMontlyPayment.Texts);
        }

        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            base.WndProc(ref m);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                if (Validation())
                {
                    if (IfAccomodationExist(txtPropID.Texts,txtACNumber.Texts))
                    {
                        MessageBox.Show("Accomodation with Flat/ Room No" + txtACNumber.Texts + "Already Exist in Database...!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        try
                        {
                            string sqlAddNewAcc = @"INSERT INTO [AccomodationInfo] (AID, PID,ACDescription,ACNumber,AmountPerMonth,
                                                                                       AmountPerYear,ACStatus,Remarks)
                                                                                      VALUES (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8)";
                            SqlCommand cmd = new SqlCommand(sqlAddNewAcc, conHelper);
                            cmd.Parameters.Add(new SqlParameter("a1", txtACID.Texts));
                            cmd.Parameters.Add(new SqlParameter("a2", txtPropID.Texts));
                            cmd.Parameters.Add(new SqlParameter("a3", cboACDescription.Text));
                            cmd.Parameters.Add(new SqlParameter("a4", txtACNumber.Texts));
                            cmd.Parameters.Add(new SqlParameter("a5", txtMontlyPayment.Texts));
                            cmd.Parameters.Add(new SqlParameter("a6", txtYearlyPayment.Texts));
                            cmd.Parameters.Add(new SqlParameter("a7", cboACStatus.Text));
                            cmd.Parameters.Add(new SqlParameter("a8", txtGeneralRemarks.Texts));

                            if (conHelper.State != ConnectionState.Open)
                                conHelper.Open();

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("New Accoumation Record Save Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _parent.LoadData();
                            ClearData();
                            GenerateACID();

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message); ;
                        }
                        finally
                        {
                            conHelper.Close();
                        }
                    }
                }

            }
            if (btnSave.Text == "Update")
            {
                if (Validation())
                {
                    try
                    {
                        string sqlPropUpd = @"UPDATE [AccomodationInfo]  SET ACDescription=@a1,ACNumber=@a2,AmountPerMonth=@a3,AmountPerYear=@a4,
                                                                            ACStatus=@a5,Remarks=@a6 WHERE AID='" + txtACID.Texts + "'";

                        SqlCommand cmd = new SqlCommand(sqlPropUpd, conHelper);
                        cmd.Parameters.Add(new SqlParameter("a1", cboACDescription.Text));
                        cmd.Parameters.Add(new SqlParameter("a2", txtACNumber.Texts));
                        cmd.Parameters.Add(new SqlParameter("a3", txtMontlyPayment.Texts));
                        cmd.Parameters.Add(new SqlParameter("a4", txtYearlyPayment.Texts));
                        cmd.Parameters.Add(new SqlParameter("a5", cboACStatus.Text));
                        cmd.Parameters.Add(new SqlParameter("a6", txtGeneralRemarks.Texts));

                        if (conHelper.State != ConnectionState.Open)
                            conHelper.Open();

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Modification Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _parent.LoadData();
                        ClearData();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message); ;
                    }
                    finally
                    {
                        conHelper.Close();
                    }
                }
            }
        }

        public void GenerateACID()
        {
            try
            {
                string sql = (@"Select MAX(AID) FROM [AccomodationInfo]");
                if (conHelper.State != ConnectionState.Open)
                    conHelper.Open();
                SqlCommand cmd = new SqlCommand(sql, conHelper);
                var maxRecID = cmd.ExecuteScalar() as string;
                if (maxRecID == null)
                {
                    txtACID.Texts = "LEMS-AID-00001";
                }

                else
                {
                    int intval = int.Parse(maxRecID.Substring(9, 5));
                    intval++;
                    txtACID.Texts = string.Format("LEMS-AID-{0:00000}", intval);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conHelper.Close();
            }
        }

        private void cboACDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboACDescription.SelectedIndex > -1)
            {
                Connection con = new Connection();
                con.getData(@"SELECT PID FROM [PropertyCatalog] WHERE PropDescription='" + cboACDescription.Text + "'");
                
                DataTable dtpid = new DataTable();
                con.sda.Fill(dtpid);
                if (dtpid.Rows.Count > 0)
                {
                    txtPropID.Texts = dtpid.Rows[0]["PID"].ToString();
                }
            }
        }

        private void txtMontlyPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                errorProvider1.SetError(txtMontlyPayment, "Allow only Numeric Values !");
            }
            else
            {
                errorProvider1.SetError(txtMontlyPayment, "");
            }
        }

        private void txtMontlyPayment__TextChanged(object sender, EventArgs e)
        {

           //Code was moved to txtYearlyPayment_TextChanged Event.
            
        }

        private void txtYearlyPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                errorProvider1.SetError(txtYearlyPayment, "Allow only Numeric Values !");
            }
            else
            {
                errorProvider1.SetError(txtYearlyPayment, "");
            }
        }

        private void txtYearlyPayment__TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtYearlyPayment.Texts, out yearlyPayment))
            {
                txtMontlyPayment.Texts =Math.Round((yearlyPayment / 12),0,MidpointRounding.AwayFromZero).ToString();
            }
        }

        public void UpdateAccomodationInfo()
        {
            lblDisplayTitle.Text = "Update Accomodation Info";
            btnSave.Text = "Update";
            txtACID.Texts = strACID;
            cboACDescription.SelectedItem = strAcDescription;
            txtPropID.Texts = strPropID;
            txtACNumber.Texts = strACNumber;
            txtMontlyPayment.Texts = strAmtPerMonth;
            txtYearlyPayment.Texts = strAmtPerYear;
            cboACStatus.SelectedItem = strACStatus;
            txtGeneralRemarks.Texts = strRemarks;

        }

        public void AddNewAccomodation()
        {
            lblDisplayTitle.Text = "Add New Accomodation";
            btnSave.Text = "Save";
            GenerateACID();
            LoadPropDescription();
        }

        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtACID.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtACID, "Accomodation ID is required");
            }
            else if (string.IsNullOrEmpty(cboACDescription.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cboACDescription, "Accomodation description is required");

            }
            else if (string.IsNullOrEmpty(txtPropID.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPropID, "Property is required");

            }
            else if (string.IsNullOrEmpty(txtACNumber.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtACNumber, "Flat / Room Number is required");

            }
            else if (string.IsNullOrEmpty(txtMontlyPayment.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtMontlyPayment, "Monthly Rentage (Amount) is required");

            }
            else if (string.IsNullOrEmpty(txtYearlyPayment.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtYearlyPayment, "Yearly Rentage (Amount) is required");

            }
            else if (string.IsNullOrEmpty(cboACStatus.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cboACStatus, "Accomodation Status is required");

            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }
        public bool IfAccomodationExist(string PropID,string AcNumber)
        {
            Connection con = new Connection();
            con.getData("Select * FROM [AccomodationInfo] WHERE PID='" + PropID + "' AND ACNumber='" + AcNumber + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public void LoadPropDescription()
        {
            cboACDescription.Items.Clear();
            Connection con = new Connection();
            con.getData(@"SELECT DISTINCT PropDescription FROM [PropertyCatalog]");
            DataTable dtp = new DataTable();
            con.sda.Fill(dtp);
            if (dtp.Rows.Count > 0)
            {
                foreach (DataRow dr in dtp.Rows)
                {
                    cboACDescription.Items.Add(dr["PropDescription"].ToString());
                }
            }

        }
        public void ClearData()
        {
            txtACID.Texts = txtACNumber.Texts = txtPropID.Texts = txtMontlyPayment.Texts = txtYearlyPayment.Texts = txtGeneralRemarks.Texts="";
            cboACDescription.SelectedIndex = -1; cboACStatus.SelectedIndex = -1;
            cboACDescription.Focus();
        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
