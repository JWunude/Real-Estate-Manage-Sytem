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
    public partial class FormAddProperty : Form
    {
        private readonly ManagePropertyCatalog _parent;

        public string strPID, strPropType, strPropDescription, strPropAddress, strTotalQty, strPropRemarks;

        DataSet ds;
        DataTable dt;
        SqlDataAdapter da;

        public FormAddProperty(ManagePropertyCatalog parent)
        {
            InitializeComponent();
            _parent = parent;
            proppertyID();

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

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdatePropInfo()
        {
            lblDisplayTitle.Text = "Update Property";
            btnSave.Text = "Update";
            txtPropID.Texts = strPID;
            txtPropType.Texts = strPropType;
            txtPropDescription.Texts = strPropDescription;
            txtPropAddress.Texts = strPropAddress;
            txtTotalQty.Texts = strTotalQty;
            txtPropRemarks.Texts = strPropRemarks;

        }

        public void AddNewPropInfo()
        {
            lblDisplayTitle.Text = "Add New Property";
            btnSave.Text = "Save";
            proppertyID();
        }

        private void FormAddProperty_Load(object sender, EventArgs e)
        {
            
        }

        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtPropID.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPropID, "Property Identification is required");
            }
            else if (string.IsNullOrEmpty(txtPropType.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPropType, "Property Type is required");

            }
            else if (string.IsNullOrEmpty(txtPropDescription.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPropDescription, "Property Description is required");

            }
            else if (string.IsNullOrEmpty(txtPropAddress.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPropAddress, "Property Address is required");

            }
            else if (string.IsNullOrEmpty(txtTotalQty.Texts))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtTotalQty, "Total Quantity is required");

            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        public void proppertyID()
        {
            try
            {
                string sql = (@"Select MAX(PID) FROM [PropertyCatalog]");
                if (conHelper.State != ConnectionState.Open)
                    conHelper.Open();
                SqlCommand cmd = new SqlCommand(sql, conHelper);
                var maxRecID = cmd.ExecuteScalar() as string;
                if (maxRecID == null)
                {
                    txtPropID.Texts = "LEMS-PID-00001";
                }

                else
                {
                    int intval = int.Parse(maxRecID.Substring(9, 5));
                    intval++;
                    txtPropID.Texts = string.Format("LEMS-PID-{0:00000}", intval);
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

        public bool IfPropertyExist(string propID)
        {
            Connection con = new Connection();
            con.getData("Select * FROM [PropertyCatalog] WHERE PID='" + propID + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public void ClearData()
        {
            txtPropAddress.Texts = txtPropDescription.Texts = txtPropID.Texts = txtPropRemarks.Texts = txtPropType.Texts = txtTotalQty.Texts = "";
            txtPropType.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                if (Validation())
                {
                    if (IfPropertyExist(txtPropID.Texts))
                    {
                        MessageBox.Show("Property with ID No" + txtPropID.Texts + "Already Exist in Database...!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        try
                        {
                            string sqlPropAdd = @"INSERT INTO [PropertyCatalog] (PID, PropType,PropDescription,PropAddress,TotalQty,Remarks)
                                            VALUES (@a1,@a2,@a3,@a4,@a5,@a6)";
                            SqlCommand cmd = new SqlCommand(sqlPropAdd, conHelper);
                            cmd.Parameters.Add(new SqlParameter("a1", txtPropID.Texts));
                            cmd.Parameters.Add(new SqlParameter("a2", txtPropType.Texts));
                            cmd.Parameters.Add(new SqlParameter("a3", txtPropDescription.Texts));
                            cmd.Parameters.Add(new SqlParameter("a4", txtPropAddress.Texts));
                            cmd.Parameters.Add(new SqlParameter("a5", txtTotalQty.Texts));
                            cmd.Parameters.Add(new SqlParameter("a6", txtPropRemarks.Texts));

                            if (conHelper.State != ConnectionState.Open)
                                conHelper.Open();

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("New Property Record Save Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _parent.LoadData();
                            ClearData();
                            proppertyID();
                            


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
                        string sqlPropUpd = @"UPDATE [PropertyCatalog]  SET PropType=@a1,PropDescription=@a2,PropAddress=@a3,
                                                                            TotalQty=@a4,Remarks=@a5
                                                                            WHERE PID='" + txtPropID.Texts + "'";

                        SqlCommand cmd = new SqlCommand(sqlPropUpd, conHelper);
                        cmd.Parameters.Add(new SqlParameter("a1", txtPropType.Texts));
                        cmd.Parameters.Add(new SqlParameter("a2", txtPropDescription.Texts));
                        cmd.Parameters.Add(new SqlParameter("a3", txtPropAddress.Texts));
                        cmd.Parameters.Add(new SqlParameter("a4", txtTotalQty.Texts));
                        cmd.Parameters.Add(new SqlParameter("a5", txtPropRemarks.Texts));

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
    }
}
