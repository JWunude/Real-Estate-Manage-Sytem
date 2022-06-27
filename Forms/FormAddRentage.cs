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
    public partial class FormAddRentage : Form
    {
        private readonly ManageRentageInfo _parent;

        public string strRID,strAcDescription, strActualAmount, strAmountPaid, strDateOfFirstPayment, strDateDueForNextPayment,
              strTenancyDuration, strDateForGracePeriod, strBalanceAmount, strTenancyStatus, strRemarks, strComments, strTenancyUniqID;

        public string tenantID, accomodationID;
        public string teanatRentStatus = "CLEARED";
        public double amountPaid =0; 
        public double amountActual = 0;
        public double amountBalance = 0;
        public string tenantRentBal;

        DateTime doFirstPayment, doNextPyamnet;

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                if (Validation())
                {
                    if (IfRentageExist(tenantID))
                    {
                        MessageBox.Show(cboTenantName.Text + " is still oweing Rent of " + tenantRentBal + " Naira ", "Tenant On Depth", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnSave.Enabled = false;
                        return;
                    }
                    else
                    {
                        try
                        {
                            string sqlAddNewTenant = @"INSERT INTO [RentageInfo] (RID,TID, AID,ActualAmount,AmountPaid,DateOfFirstPayment,DateDueForNextPayment,
                                                                                 TenancyDuration,DateForGracePeriod,BalanceAmount,TenancyStatus,Remakrs,Comments)
                                            VALUES (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10,@a11,@a12,@a13)";
                            SqlCommand cmd = new SqlCommand(sqlAddNewTenant, conHelper);
                            cmd.Parameters.Add(new SqlParameter("a1", txtRentID.Texts));
                            cmd.Parameters.Add(new SqlParameter("a2", tenantID));
                            cmd.Parameters.Add(new SqlParameter("a3", accomodationID));
                            cmd.Parameters.Add(new SqlParameter("a4", txtActualAmount.Texts));
                            cmd.Parameters.Add(new SqlParameter("a5", txtAmountPaid.Texts));
                            cmd.Parameters.Add(new SqlParameter("a6", dtpDataOfFirstPayment.Value));
                            cmd.Parameters.Add(new SqlParameter("a7", dtpNextPaymentDueDate.Value));
                            cmd.Parameters.Add(new SqlParameter("a8", txtDuration.Texts));
                            cmd.Parameters.Add(new SqlParameter("a9", dtpGracePeriodDate.Value));
                            cmd.Parameters.Add(new SqlParameter("a10", txtBalanceAmount.Texts));
                            cmd.Parameters.Add(new SqlParameter("a11", cboTenancyStatus.Text));
                            cmd.Parameters.Add(new SqlParameter("a12", txtRemarks.Texts));
                            cmd.Parameters.Add(new SqlParameter("a13", txtComments.Texts));

                            if (conHelper.State != ConnectionState.Open)
                                conHelper.Open();

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("New Rentage Record Save Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _parent.LoadData();
                            ClearData();
                            GenerateRentageID();

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
                        string sqlPropUpd = @"UPDATE [RentageInfo]  SET AmountPaid=@a1,DateOfFirstPayment=@a2,DateDueForNextPayment=@a3,DateForGracePeriod=@a4,BalanceAmount=@a5,
                                                                    TenancyStatus=@a6,Remakrs=@a7,Comments=@a8 WHERE RID='" + txtRentID.Texts + "'";

                        SqlCommand cmd = new SqlCommand(sqlPropUpd, conHelper);
                        cmd.Parameters.Add(new SqlParameter("a1", txtAmountPaid.Texts));
                        cmd.Parameters.Add(new SqlParameter("a2", dtpDataOfFirstPayment.Value));
                        cmd.Parameters.Add(new SqlParameter("a3", dtpNextPaymentDueDate.Value));
                        cmd.Parameters.Add(new SqlParameter("a4", dtpGracePeriodDate.Value));
                        cmd.Parameters.Add(new SqlParameter("a5", txtBalanceAmount.Texts));
                        cmd.Parameters.Add(new SqlParameter("a6", cboTenancyStatus.Text));
                        cmd.Parameters.Add(new SqlParameter("a7", txtRemarks.Texts));
                        cmd.Parameters.Add(new SqlParameter("a8", txtComments.Texts));
                        if (conHelper.State != ConnectionState.Open)
                            conHelper.Open();

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Rentage Info Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtAmountPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                errorProvider1.SetError(txtAmountPaid, "Allow only Numeric Values !");
            }
            else
            {
                errorProvider1.SetError(txtAmountPaid, "");
            }
        }

        private void txtAmountPaid__TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtAmountPaid.Texts, out amountPaid))
            {
                txtBalanceAmount.Texts = (amountActual - amountPaid).ToString();
            }
        }

        private void cboACDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboACDescription.SelectedIndex > -1)
            {
                Connection con = new Connection();
                con.getData(@"SELECT AID,AmountPerYear FROM [AccomodationInfo] WHERE ACDescription='" + cboACDescription.Text + "'");

                DataTable dtpAcNo = new DataTable();
                con.sda.Fill(dtpAcNo);
                if (dtpAcNo.Rows.Count > 0)
                {
                    txtActualAmount.Texts = dtpAcNo.Rows[0]["AmountPerYear"].ToString();
                    accomodationID = dtpAcNo.Rows[0]["AID"].ToString();
                    amountActual = double.Parse(txtActualAmount.Texts);
                    txtAmountPaid.Enabled = true;
                }
            }
        }

        private void cboTenantName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenantName.SelectedIndex > -1)
            {
                Connection con = new Connection();
                con.getData(@"SELECT TID FROM [TenantInfo] WHERE TenantUniqueID='" + cboTenantName.Text + "'");

                DataTable dtpTIDNo = new DataTable();
                con.sda.Fill(dtpTIDNo);
                if (dtpTIDNo.Rows.Count > 0)
                {
                    tenantID = dtpTIDNo.Rows[0]["TID"].ToString();
                    CheckTenantRentStaus();
                }
            }
        }

        public FormAddRentage(ManageRentageInfo parent)
        {
            InitializeComponent();
            _parent = parent;
            GenerateRentageID();
            LoadAccomodation();
            LoadTenancyInfo();

        }

        private void dtpDataOfFirstPayment_ValueChanged(object sender, EventArgs e)
        {
            doFirstPayment = dtpDataOfFirstPayment.Value;
            dtpNextPaymentDueDate.Value = doFirstPayment.AddDays(365);
        }

        private void dtpNextPaymentDueDate_ValueChanged(object sender, EventArgs e)
        {
            doNextPyamnet = dtpNextPaymentDueDate.Value;

            txtDuration.Texts = (((doNextPyamnet.Year - doFirstPayment.Year) * 12) + (doNextPyamnet.Month - doFirstPayment.Month)).ToString();

            dtpGracePeriodDate.Value = doNextPyamnet.AddMonths(2);
        }

        public void GenerateRentageID()
        {
            try
            {
                string sql = (@"Select MAX(RID) FROM [RentageInfo]");
                if (conHelper.State != ConnectionState.Open)
                    conHelper.Open();
                SqlCommand cmd = new SqlCommand(sql, conHelper);
                var maxRecID = cmd.ExecuteScalar() as string;
                if (maxRecID == null)
                {
                    txtRentID.Texts = "LEMS-RID-00001";
                }

                else
                {
                    int intval = int.Parse(maxRecID.Substring(9, 5));
                    intval++;
                    txtRentID.Texts = string.Format("LEMS-RID-{0:00000}", intval);
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

        public void UpdateRentageInfo()
        {
            lblDisplayTitle.Text = "Update Rentage Info";
            btnSave.Text = "Update";
            btnSave.Enabled = true;
            txtRentID.Texts = strRID;
            cboACDescription.Text = strAcDescription;
            cboTenantName.Text = strTenancyUniqID;
            txtActualAmount.Texts = strActualAmount;
            txtAmountPaid.Texts = strAmountPaid;
            txtBalanceAmount.Texts = strBalanceAmount;
            dtpDataOfFirstPayment.Value = DateTime.Parse(strDateOfFirstPayment);
            dtpNextPaymentDueDate.Value = DateTime.Parse(strDateDueForNextPayment);
            dtpGracePeriodDate.Value = DateTime.Parse(strDateForGracePeriod);
            cboTenancyStatus.Text = strTenancyStatus;
            txtDuration.Texts = strTenancyDuration;
            txtRemarks.Texts = strRemarks;
            txtComments.Texts = strComments;

        }

        public void AddNewRentageInfo()
        {
            lblDisplayTitle.Text = "Add New Rent";
            btnSave.Text = "Save";
            btnSave.Enabled = true;
            GenerateRentageID();
            LoadTenancyInfo();
            LoadAccomodation();
        }

        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtRentID.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtRentID, "Rentage Identification is required");
            }
            else if (string.IsNullOrEmpty(cboACDescription.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cboACDescription, "Accomodation Description is required");

            }
            else if (string.IsNullOrEmpty(cboTenantName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cboTenantName, "Tenant Name is required");

            }
            else if (string.IsNullOrEmpty(txtActualAmount.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtActualAmount, "Acutaul Amount is required");

            }
            else if (string.IsNullOrEmpty(txtAmountPaid.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtAmountPaid, "Amount paid is required");

            }
           
            else if (string.IsNullOrEmpty(txtDuration.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtDuration, "Tenancy Period is required");

            }
            else if (string.IsNullOrEmpty(cboTenancyStatus.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cboTenancyStatus, "Tenancy Status is required");

            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        public bool IfRentageExist(string TenantID)
        {
            Connection con = new Connection();
            con.getData("Select * FROM [RentageInfo] WHERE TID='" + TenantID + "' AND TenancyStatus ='" + "NOT-CLEARED" + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public void ClearData()
        {
            txtRentID.Texts = txtActualAmount.Texts = txtAmountPaid.Texts = txtBalanceAmount.Texts = txtDuration.Texts = "";
            cboACDescription.SelectedIndex = -1; cboTenantName.SelectedIndex = -1;cboTenancyStatus.SelectedIndex = -1;
            txtRemarks.Texts = txtComments.Texts = "";
            dtpDataOfFirstPayment.Value = DateTime.Today;
            dtpNextPaymentDueDate.Value = DateTime.Today;
            dtpGracePeriodDate.Value = DateTime.Today;
            txtRentID.Focus();
        }

        public void LoadAccomodation()
        {
            cboACDescription.Items.Clear();
            Connection con = new Connection();
            con.getData(@"SELECT DISTINCT ACDescription FROM [AccomodationInfo]");
            DataTable dtp = new DataTable();
            con.sda.Fill(dtp);
            if (dtp.Rows.Count > 0)
            {
                foreach (DataRow dr in dtp.Rows)
                {
                    cboACDescription.Items.Add(dr["ACDescription"].ToString());
                }
            }

        }

        public void LoadTenancyInfo()
        {
            cboTenantName.Items.Clear();
            Connection con = new Connection();
            con.getData(@"SELECT TenantUniqueID FROM [TenantInfo]");
            DataTable dtpTuniqID = new DataTable();
            con.sda.Fill(dtpTuniqID);
            if (dtpTuniqID.Rows.Count > 0)
            {
                foreach (DataRow dr in dtpTuniqID.Rows)
                {
                    cboTenantName.Items.Add(dr["TenantUniqueID"].ToString());
                }
            }

        }

        public void CheckTenantRentStaus()
        {
            Connection con = new Connection();
            con.getData("Select TenancyStatus,BalanceAmount FROM [RentageInfo] WHERE TID='" + tenantID + "'");
            DataTable dtpTRS = new DataTable();
            con.sda.Fill(dtpTRS);
            if (dtpTRS.Rows.Count > 0)
            {
               
                teanatRentStatus = dtpTRS.Rows[0]["TenancyStatus"].ToString();
                tenantRentBal = dtpTRS.Rows[0]["BalanceAmount"].ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
