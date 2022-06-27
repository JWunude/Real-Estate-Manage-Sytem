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
    public partial class MaangeAccomodationInfo : Form
    {
        FormAddAccomodation frmAddAccomdation;
        DataSet ds;
        DataTable dt;
        SqlDataAdapter da;
        public MaangeAccomodationInfo()
        {
            InitializeComponent();
            frmAddAccomdation = new FormAddAccomodation(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //FormAddProperty frmaddNewProperty = new FormAddProperty(this);
            frmAddAccomdation.ClearData();
            frmAddAccomdation.AddNewAccomodation();
            frmAddAccomdation.ShowDialog();
        }

        public void LoadData()
        {
            Connection con = new Connection();
            con.getData("Select RECID,AID,PID,ACDescription,ACNumber,AmountPerMonth,AmountPerYear,ACStatus,Remarks FROM [AccomodationInfo]");
            ds = new DataSet();
            con.sda.Fill(ds, "AccomodationInfo");
            dt = ds.Tables["AccomodationInfo"];
            dgvDisplayAccomodation.DataSource = dt;

        }

        private void MaangeAccomodationInfo_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.getData(@"Select RECID,AID,PID,ACDescription,ACNumber,AmountPerMonth,AmountPerYear,ACStatus,Remarks FROM [AccomodationInfo] 
                            WHERE ACDescription LIKE '%" + txtSearch.Texts + "%' OR ACStatus LIKE '%" + txtSearch.Texts + "%'");
            ds = new DataSet();
            con.sda.Fill(ds, "AccomodationInfo");
            dt = ds.Tables["AccomodationInfo"];
            dgvDisplayAccomodation.DataSource = dt;
        }

        private void dgvDisplayAccomodation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edit (Update)
            if (e.ColumnIndex == 0)
            {
                frmAddAccomdation.ClearData();
                frmAddAccomdation.LoadPropDescription();
                frmAddAccomdation.strACID = dgvDisplayAccomodation.Rows[e.RowIndex].Cells["AID"].Value.ToString();
                frmAddAccomdation.strAcDescription = dgvDisplayAccomodation.Rows[e.RowIndex].Cells["ACDescription"].Value.ToString();
                frmAddAccomdation.strPropID = dgvDisplayAccomodation.Rows[e.RowIndex].Cells["PID"].Value.ToString();
                frmAddAccomdation.strACNumber = dgvDisplayAccomodation.Rows[e.RowIndex].Cells["ACNumber"].Value.ToString();
                frmAddAccomdation.strAmtPerMonth = dgvDisplayAccomodation.Rows[e.RowIndex].Cells["AmountPerMonth"].Value.ToString();
                frmAddAccomdation.strAmtPerYear = dgvDisplayAccomodation.Rows[e.RowIndex].Cells["AmountPerYear"].Value.ToString();
                frmAddAccomdation.strACStatus = dgvDisplayAccomodation.Rows[e.RowIndex].Cells["ACStatus"].Value.ToString();
                frmAddAccomdation.strRemarks = dgvDisplayAccomodation.Rows[e.RowIndex].Cells["Remarks"].Value.ToString();
                frmAddAccomdation.UpdateAccomodationInfo();
                frmAddAccomdation.ShowDialog();
                return;
            }

            //Delete
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //lblPID.Text = dgvDisplayProperty.Rows[e.RowIndex].Cells["PID"].Value.ToString();
                    Connection con = new Connection();
                    con.sendData("DELETE FROM [AccomodationInfo] WHERE AID='" + dgvDisplayAccomodation.Rows[e.RowIndex].Cells["AID"].Value.ToString() + "'");
                    MessageBox.Show("Record deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                return;
            }
        }
    }
}
