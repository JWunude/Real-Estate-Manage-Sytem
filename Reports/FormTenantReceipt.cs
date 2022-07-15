using Lems.RptData;
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
using Microsoft.Reporting.WinForms;

namespace Lems.Reports
{
    public partial class FormTenantReceipt : Form
    {
        SqlConnection conHelper = new SqlConnection(Helper.ConnectionString);
        //SqlDataAdapter sda;
        //TenantReceipt ds = new TenantReceipt(); // Dataset

        public FormTenantReceipt()
        {
            InitializeComponent();
        }

        private void FormTenantReceipt_Load(object sender, EventArgs e)
        {

            this.reportViewerTenantReceipt.RefreshReport();
            LoadUTenantUniqueID();
        }

        //private void btnDisplayReceipt_Click(object sender, EventArgs e)
        //{
            

        //}

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadUTenantUniqueID()
        {
            cboTenantUniqueID.Items.Clear();
            Connection con = new Connection();
            con.getData(@"SELECT DISTINCT TenantUniqueID FROM [manageRentage]");
            DataTable dtpTuniqID = new DataTable();
            con.sda.Fill(dtpTuniqID);
            if (dtpTuniqID.Rows.Count > 0)
            {
                foreach (DataRow dr in dtpTuniqID.Rows)
                {
                    cboTenantUniqueID.Items.Add(dr["TenantUniqueID"].ToString());
                }
            }

        }

        private void cboTenantUniqueID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboReceptNo.Items.Clear();
            Connection con = new Connection();
            con.getData(@"SELECT RID FROM [manageRentage] WHERE TenantUniqueID='" + cboTenantUniqueID.Text + "' ORDER BY RID");
            DataTable dtpRID = new DataTable();
            con.sda.Fill(dtpRID);
            if (dtpRID.Rows.Count > 0)
            {
                foreach (DataRow dr in dtpRID.Rows)
                {
                    cboReceptNo.Items.Add(dr["RID"].ToString());
                }
            }
        }

        private void cboReceptNo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboTenantUniqueID.SelectedIndex != -1 && cboReceptNo.SelectedIndex != -1)
            {
                string sqlquery = @"SELECT * FROM [manageRentage] WHERE RID ='" + cboReceptNo.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sqlquery, conHelper);
                TenantReceipt ds = new TenantReceipt(); // Dataset
                sda.Fill(ds, "manageRentage");

                ReportDataSource dataSource = new ReportDataSource("DataSet_TenantReceipt", ds.Tables[0]);

                this.reportViewerTenantReceipt.LocalReport.DataSources.Clear();
                this.reportViewerTenantReceipt.LocalReport.DataSources.Add(dataSource);

                this.reportViewerTenantReceipt.RefreshReport();
            }

            else
            {
                MessageBox.Show("Please provide expected inputs", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboReceptNo.Focus();
            }
        }
    }
}
