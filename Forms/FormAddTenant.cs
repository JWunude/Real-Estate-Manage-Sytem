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
    public partial class FormAddTenant : Form
    {
        private readonly ManageTenantInfo _parent;

        public string strTenantID, strFullName, strHomePhoneNo, strWorkPhoneNo, strHomeAddress, strEmailAddress,strMeansOfID, strIDNumber, 
                      strGuarantorName, strGuarantorPhoneNo, strGuarantorAddress,strGurantorRelationShip, strRemarks;
        public FormAddTenant(ManageTenantInfo parent)
        {
            InitializeComponent();
            _parent = parent;
            GenerateTenantID();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                if (Validation())
                {
                    if (IfTenantExist(txtTenantID.Texts))
                    {
                        MessageBox.Show("Tenant with ID No" + txtTenantID.Texts + "Already Exist in Database...!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        try
                        {
                            string sqlAddNewTenant = @"INSERT INTO [TenantInfo] (TID, FullName,HomePhoneNumber,WorkPhoneNumber,HomeAddress,EmailAddress,MeansOfIdentification,
                                                                                 IdentificationNumber,GurantorName,GuarantorPhoneNumber,GurantorAddress,
                                                                                 GurantorRelationShip,Remarks,TenantUniqueID)
                                            VALUES (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10,@a11,@a12,@a13,@a14)";
                            SqlCommand cmd = new SqlCommand(sqlAddNewTenant, conHelper);
                            cmd.Parameters.Add(new SqlParameter("a1", txtTenantID.Texts));
                            cmd.Parameters.Add(new SqlParameter("a2", txtFullName.Texts));
                            cmd.Parameters.Add(new SqlParameter("a3", txtHomePhoneNo.Texts));
                            cmd.Parameters.Add(new SqlParameter("a4", txtWorkPhoneNo.Texts));
                            cmd.Parameters.Add(new SqlParameter("a5", txtHomeAddress.Texts));
                            cmd.Parameters.Add(new SqlParameter("a6", txtEmailAddress.Texts));
                            cmd.Parameters.Add(new SqlParameter("a7", cboMeansOfIdentification.Text));
                            cmd.Parameters.Add(new SqlParameter("a8", txtIDNumber.Texts));
                            cmd.Parameters.Add(new SqlParameter("a9", txtGuarantorName.Texts));
                            cmd.Parameters.Add(new SqlParameter("a10", txtGuarantorPhoneNo.Texts));
                            cmd.Parameters.Add(new SqlParameter("a11", txtGuarantorAddress.Texts));
                            cmd.Parameters.Add(new SqlParameter("a12", txtGuarantorRelationShip.Texts));
                            cmd.Parameters.Add(new SqlParameter("a13", txtGeneralRemarks.Texts));
                            cmd.Parameters.Add(new SqlParameter("a14", txtTenantID.Texts +" [ " +txtFullName.Texts +" ]"));

                            if (conHelper.State != ConnectionState.Open)
                                conHelper.Open();

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("New Tenant Record Save Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _parent.LoadData();
                            ClearData();
                            GenerateTenantID();

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
                        string sqlPropUpd = @"UPDATE [TenantInfo]  SET FullName=@a1,HomePhoneNumber=@a2,WorkPhoneNumber=@a3,HomeAddress=@a4,EmailAddress=@a5,MeansOfIdentification=@a6,
                                                                            IdentificationNumber=@a7,GurantorName=@a8,GuarantorPhoneNumber=@a9,GurantorAddress=@a10,
                                                                            GurantorRelationShip=@a11,Remarks=@a12,TenantUniqueID=@a13
                                                                            WHERE TID='" + txtTenantID.Texts + "'";

                        SqlCommand cmd = new SqlCommand(sqlPropUpd, conHelper);
                        cmd.Parameters.Add(new SqlParameter("a1", txtFullName.Texts));
                        cmd.Parameters.Add(new SqlParameter("a2", txtHomePhoneNo.Texts));
                        cmd.Parameters.Add(new SqlParameter("a3", txtWorkPhoneNo.Texts));
                        cmd.Parameters.Add(new SqlParameter("a4", txtHomeAddress.Texts));
                        cmd.Parameters.Add(new SqlParameter("a5", txtEmailAddress.Texts));
                        cmd.Parameters.Add(new SqlParameter("a6", cboMeansOfIdentification.Text));
                        cmd.Parameters.Add(new SqlParameter("a7", txtIDNumber.Texts));
                        cmd.Parameters.Add(new SqlParameter("a8", txtGuarantorName.Texts));
                        cmd.Parameters.Add(new SqlParameter("a9", txtGuarantorPhoneNo.Texts));
                        cmd.Parameters.Add(new SqlParameter("a10", txtGuarantorAddress.Texts));
                        cmd.Parameters.Add(new SqlParameter("a11", txtGuarantorRelationShip.Texts));
                        cmd.Parameters.Add(new SqlParameter("a12", txtGeneralRemarks.Texts));
                        cmd.Parameters.Add(new SqlParameter("a13", txtTenantID.Texts + " [ " + txtFullName.Texts + " ]"));

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

        private void FormAddTenant_Load(object sender, EventArgs e)
        {
            //GenerateTenantID();
        }

        SqlConnection conHelper = new SqlConnection(Helper.ConnectionString);

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
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void GenerateTenantID()
        {
            try
            {
                string sql = (@"Select MAX(TID) FROM [TenantInfo]");
                if (conHelper.State != ConnectionState.Open)
                    conHelper.Open();
                SqlCommand cmd = new SqlCommand(sql, conHelper);
                var maxRecID = cmd.ExecuteScalar() as string;
                if (maxRecID == null)
                {
                    txtTenantID.Texts = "LEMS-TID-00001";
                }

                else
                {
                    int intval = int.Parse(maxRecID.Substring(9, 5));
                    intval++;
                    txtTenantID.Texts = string.Format("LEMS-TID-{0:00000}", intval);
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

        public void UpdateTenantInfo()
        {
            lblDisplayTitle.Text = "Update Tenant Info";
            btnSave.Text = "Update";
            txtTenantID.Texts = strTenantID;
            txtFullName.Texts = strFullName;
            txtHomePhoneNo.Texts = strHomePhoneNo;
            txtWorkPhoneNo.Texts = strWorkPhoneNo;
            txtHomeAddress.Texts = strHomeAddress;
            txtEmailAddress.Texts = strEmailAddress;
            cboMeansOfIdentification.Text= strMeansOfID;
            txtIDNumber.Texts = strIDNumber;
            txtGuarantorName.Texts = strGuarantorName;
            txtGuarantorPhoneNo.Texts = strGuarantorPhoneNo;
            txtGuarantorAddress.Texts = strGuarantorAddress;
            txtGuarantorRelationShip.Texts = strGurantorRelationShip;
            txtGeneralRemarks.Texts = strRemarks;

        }

        public void AddNewTenantInfo()
        {
            lblDisplayTitle.Text = "Add New tenant";
            btnSave.Text = "Save";
            GenerateTenantID();
        }

        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtTenantID.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtTenantID, "Tenant Identification is required");
            }
            else if (string.IsNullOrEmpty(txtFullName.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtFullName, "Tenant Name is required");

            }
            else if (string.IsNullOrEmpty(txtHomePhoneNo.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtHomePhoneNo, "Tenant Phone Number is required");

            }
            else if (string.IsNullOrEmpty(txtWorkPhoneNo.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtWorkPhoneNo, "Tenant Work Phone Number is required");

            }
            else if (string.IsNullOrEmpty(txtHomeAddress.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtHomeAddress, "Tenant Home Address is required");

            }
            else if (string.IsNullOrEmpty(txtEmailAddress.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmailAddress, "Tenant Email Address is required");

            }
            else if (string.IsNullOrEmpty(cboMeansOfIdentification.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cboMeansOfIdentification, "Means of Identification is required");

            }
            else if (string.IsNullOrEmpty(txtIDNumber.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtIDNumber, "Identification Number is required");

            }
            else if (string.IsNullOrEmpty(txtGuarantorName.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtGuarantorName, "Guarantor name is required");

            }
            else if (string.IsNullOrEmpty(txtGuarantorPhoneNo.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtGuarantorPhoneNo, "Guarantor Phone No. is required");

            }
            else if (string.IsNullOrEmpty(txtGuarantorAddress.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtGuarantorAddress, "Guarantor Address is required");

            }
            else if (string.IsNullOrEmpty(txtGuarantorRelationShip.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtGuarantorRelationShip, "Guarnator Relationship is required");

            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        public bool IfTenantExist(string TenantID)
        {
            Connection con = new Connection();
            con.getData("Select * FROM [TenantInfo] WHERE TID='" + TenantID + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public void ClearData()
        {
            txtTenantID.Texts = txtFullName.Texts = txtHomePhoneNo.Texts = txtWorkPhoneNo.Texts = txtHomeAddress.Texts = txtEmailAddress.Texts = "";
            cboMeansOfIdentification.SelectedIndex = -1;txtIDNumber.Texts = txtGuarantorName.Texts = "";
            txtGuarantorPhoneNo.Texts = txtGuarantorAddress.Texts = txtGuarantorRelationShip.Texts = txtGeneralRemarks.Texts = "";
            txtTenantID.Focus();
        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
