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
    public partial class ManagePropertyCatalog : Form
    {
        FormAddProperty frmAddProperty;
        DataSet ds;
        DataTable dt;
        SqlDataAdapter da;
        public ManagePropertyCatalog()
        {
            InitializeComponent();
            frmAddProperty = new FormAddProperty(this);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //FormAddProperty frmaddNewProperty = new FormAddProperty(this);
            frmAddProperty.ClearData();
            frmAddProperty.AddNewPropInfo();
            frmAddProperty.ShowDialog();
            
        }

        private void ManagePropertyCatalog_Load(object sender, EventArgs e)
        {
            //LoadData();
        }

        public void LoadData()
        {
            Connection con = new Connection();
            con.getData("Select RECID,PID,PropType,PropDescription,PropAddress,TotalQty,Remarks FROM [PropertyCatalog]");
            ds = new DataSet();
            con.sda.Fill(ds, "PropertyCatalog");
            dt = ds.Tables["PropertyCatalog"];
            dgvDisplayProperty.DataSource = dt;
            
        }

        private void ManagePropertyCatalog_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.getData(@"Select RECID, PID,PropType,PropDescription,PropAddress,TotalQty,Remarks FROM [PropertyCatalog] 
                            WHERE PropDescription LIKE '%" + txtSearch.Texts + "%' OR PropAddress LIKE '%" + txtSearch.Texts + "%'");
            ds = new DataSet();
            con.sda.Fill(ds, "PropertyCatalog");
            dt = ds.Tables["PropertyCatalog"];
            dgvDisplayProperty.DataSource = dt;
        }

        private void dgvDisplayProperty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edit (Update)
            if (e.ColumnIndex == 0)
            {
                frmAddProperty.ClearData();
                frmAddProperty.strPID = dgvDisplayProperty.Rows[e.RowIndex].Cells["PID"].Value.ToString();
                frmAddProperty.strPropType = dgvDisplayProperty.Rows[e.RowIndex].Cells["PropType"].Value.ToString();
                frmAddProperty.strPropDescription = dgvDisplayProperty.Rows[e.RowIndex].Cells["PropDescription"].Value.ToString();
                frmAddProperty.strPropAddress = dgvDisplayProperty.Rows[e.RowIndex].Cells["PropAddress"].Value.ToString();
                frmAddProperty.strTotalQty = dgvDisplayProperty.Rows[e.RowIndex].Cells["TotalQty"].Value.ToString();
                frmAddProperty.strPropRemarks = dgvDisplayProperty.Rows[e.RowIndex].Cells["Remarks"].Value.ToString();
                frmAddProperty.UpdatePropInfo();
                frmAddProperty.ShowDialog();
                return;
            }

            //Delete
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    //lblPID.Text = dgvDisplayProperty.Rows[e.RowIndex].Cells["PID"].Value.ToString();
                    Connection con = new Connection();
                    con.sendData("DELETE FROM [PropertyCatalog] WHERE PID='" + dgvDisplayProperty.Rows[e.RowIndex].Cells["PID"].Value.ToString() + "'");
                    MessageBox.Show("Record deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                return;
            }
        }
    }
}
