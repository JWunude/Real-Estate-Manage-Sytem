using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lems.Forms
{
    public partial class ManageRentageInfo : Form
    {
        FormAddRentage frmAddRentage;
        DataSet ds;
        DataTable dt;

        public ManageRentageInfo()
        {
            InitializeComponent();
            frmAddRentage = new FormAddRentage(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddRentage.ClearData();
            frmAddRentage.AddNewRentageInfo();
            frmAddRentage.ShowDialog();
        }

        public void LoadData()
        {
            Connection con = new Connection();
            con.getData(@"Select RID,ACDescription,ActualAmount,Amountpaid,DateOfFirstPayment,DateDueForNextPayment,TenancyDuration,DateForGracePeriod,BalanceAmount,
                                 TenancyStatus,Remakrs,Comments,TenantUniqueID FROM [manageRentage]");
            ds = new DataSet();
            con.sda.Fill(ds, "manageRentage");
            dt = ds.Tables["manageRentage"];
            dgvDisplayRentageInfo.DataSource = dt;

        }

        private void ManageRentageInfo_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.getData(@"Select RID,ACDescription,ActualAmount,Amountpaid,DateOfFirstPayment,DateDueForNextPayment,TenancyDuration,DateForGracePeriod,BalanceAmount,
                                 TenancyStatus,Remakrs,Comments,TenantUniqueID FROM [manageRentage]
                                 WHERE TenantUniqueID LIKE '%" + txtSearch.Texts + "%' OR TenancyStatus LIKE '%" + txtSearch.Texts + "%'");
            ds = new DataSet();
            con.sda.Fill(ds, "manageRentage");
            dt = ds.Tables["manageRentage"];
            dgvDisplayRentageInfo.DataSource = dt;
        }

        private void dgvDisplayRentageInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edit (Update)

            if (e.ColumnIndex == 0)
            {
                frmAddRentage.ClearData();
                frmAddRentage.strRID = dgvDisplayRentageInfo.Rows[e.RowIndex].Cells["RID"].Value.ToString();
                frmAddRentage.strAcDescription = dgvDisplayRentageInfo.Rows[e.RowIndex].Cells["ACDescription"].Value.ToString();
                frmAddRentage.strActualAmount = dgvDisplayRentageInfo.Rows[e.RowIndex].Cells["ActualAmount"].Value.ToString();
                frmAddRentage.strAmountPaid = dgvDisplayRentageInfo.Rows[e.RowIndex].Cells["Amountpaid"].Value.ToString();
                frmAddRentage.strDateOfFirstPayment = dgvDisplayRentageInfo.Rows[e.RowIndex].Cells["DateOfFirstPayment"].Value.ToString();
                frmAddRentage.strDateDueForNextPayment = dgvDisplayRentageInfo.Rows[e.RowIndex].Cells["DateDueForNextPayment"].Value.ToString();
                frmAddRentage.strTenancyDuration = dgvDisplayRentageInfo.Rows[e.RowIndex].Cells["TenancyDuration"].Value.ToString();
                frmAddRentage.strDateForGracePeriod = dgvDisplayRentageInfo.Rows[e.RowIndex].Cells["DateForGracePeriod"].Value.ToString();
                frmAddRentage.strBalanceAmount = dgvDisplayRentageInfo.Rows[e.RowIndex].Cells["BalanceAmount"].Value.ToString();
                frmAddRentage.strTenancyStatus = dgvDisplayRentageInfo.Rows[e.RowIndex].Cells["TenancyStatus"].Value.ToString();
                frmAddRentage.strRemarks = dgvDisplayRentageInfo.Rows[e.RowIndex].Cells["Remakrs"].Value.ToString();
                frmAddRentage.strComments = dgvDisplayRentageInfo.Rows[e.RowIndex].Cells["Comments"].Value.ToString();
                frmAddRentage.strTenancyUniqID = dgvDisplayRentageInfo.Rows[e.RowIndex].Cells["TenantUniqueID"].Value.ToString();

                frmAddRentage.UpdateRentageInfo();
                frmAddRentage.ShowDialog();
                return;
            }

            //Delete
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //lblPID.Text = dgvDisplayProperty.Rows[e.RowIndex].Cells["PID"].Value.ToString();
                    Connection con = new Connection();
                    con.sendData("DELETE FROM [manageRentage] WHERE RID='" + dgvDisplayRentageInfo.Rows[e.RowIndex].Cells["RID"].Value.ToString() + "'");
                    MessageBox.Show("Record deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                return;
            }
        }
    }
}
