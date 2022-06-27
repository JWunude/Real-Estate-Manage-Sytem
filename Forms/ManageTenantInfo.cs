using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lems.Forms
{
    public partial class ManageTenantInfo : Form
    {
        FormAddTenant frmAddTenant;
        DataSet ds;
        DataTable dt;
        public ManageTenantInfo()
        {
            InitializeComponent();
            frmAddTenant = new FormAddTenant(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddTenant.ClearData();
            frmAddTenant.AddNewTenantInfo();
            frmAddTenant.ShowDialog();
        }

        public void LoadData()
        {
            Connection con = new Connection();
            con.getData(@"Select RECID,TID,FullName,HomePhoneNumber,WorkPhoneNumber,HomeAddress,EmailAddress,MeansOfIdentification,IdentificationNumber,
                                 GurantorName,GuarantorPhoneNumber,GurantorAddress,GurantorRelationShip,Remarks FROM [TenantInfo]");
            ds = new DataSet();
            con.sda.Fill(ds, "TenantInfo");
            dt = ds.Tables["TenantInfo"];
            dgvDisplayTenantInfo.DataSource = dt;

        }

        private void ManageTenantInfo_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.getData(@"Select RECID,TID,FullName,HomePhoneNumber,WorkPhoneNumber,HomeAddress,EmailAddress,MeansOfIdentification,IdentificationNumber,
                                 GurantorName,GuarantorPhoneNumber,GurantorAddress,GurantorRelationShip,Remarks FROM [TenantInfo]
                            WHERE FullName LIKE '%" + txtSearch.Texts + "%' OR GurantorName LIKE '%" + txtSearch.Texts + "%'");
            ds = new DataSet();
            con.sda.Fill(ds, "TenantInfo");
            dt = ds.Tables["TenantInfo"];
            dgvDisplayTenantInfo.DataSource = dt;
        }

        private void dgvDisplayProperty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edit (Update)
            
            if (e.ColumnIndex == 0)
            {
                frmAddTenant.ClearData();
                frmAddTenant.strTenantID = dgvDisplayTenantInfo.Rows[e.RowIndex].Cells["TID"].Value.ToString();
                frmAddTenant.strFullName = dgvDisplayTenantInfo.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                frmAddTenant.strHomePhoneNo = dgvDisplayTenantInfo.Rows[e.RowIndex].Cells["HomePhoneNumber"].Value.ToString();
                frmAddTenant.strWorkPhoneNo = dgvDisplayTenantInfo.Rows[e.RowIndex].Cells["WorkPhoneNumber"].Value.ToString();
                frmAddTenant.strHomeAddress = dgvDisplayTenantInfo.Rows[e.RowIndex].Cells["HomeAddress"].Value.ToString();
                frmAddTenant.strEmailAddress = dgvDisplayTenantInfo.Rows[e.RowIndex].Cells["EmailAddress"].Value.ToString();
                frmAddTenant.strMeansOfID = dgvDisplayTenantInfo.Rows[e.RowIndex].Cells["MeansOfIdentification"].Value.ToString();
                frmAddTenant.strIDNumber = dgvDisplayTenantInfo.Rows[e.RowIndex].Cells["IdentificationNumber"].Value.ToString();
                frmAddTenant.strGuarantorName = dgvDisplayTenantInfo.Rows[e.RowIndex].Cells["GurantorName"].Value.ToString();
                frmAddTenant.strGuarantorPhoneNo = dgvDisplayTenantInfo.Rows[e.RowIndex].Cells["GuarantorPhoneNumber"].Value.ToString();
                frmAddTenant.strGuarantorAddress = dgvDisplayTenantInfo.Rows[e.RowIndex].Cells["GurantorAddress"].Value.ToString();
                frmAddTenant.strGurantorRelationShip = dgvDisplayTenantInfo.Rows[e.RowIndex].Cells["GurantorRelationShip"].Value.ToString();
                frmAddTenant.strRemarks = dgvDisplayTenantInfo.Rows[e.RowIndex].Cells["Remarks"].Value.ToString();

                frmAddTenant.UpdateTenantInfo();
                frmAddTenant.ShowDialog();
                return;
            }

            //Delete
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //lblPID.Text = dgvDisplayProperty.Rows[e.RowIndex].Cells["PID"].Value.ToString();
                    Connection con = new Connection();
                    con.sendData("DELETE FROM [TenantInfo] WHERE TID='" + dgvDisplayTenantInfo.Rows[e.RowIndex].Cells["TID"].Value.ToString() + "'");
                    MessageBox.Show("Record deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                return;
            }
        }
    }
}
