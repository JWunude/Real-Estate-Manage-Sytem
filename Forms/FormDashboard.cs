using Lems.Models;
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
    public partial class FormDashboard : Form
    {
        //Fields 
        private Dashboard model;
        //Contructor
        public FormDashboard()
        {
            InitializeComponent();
            //default  - Last 7 days
            dtpStartDate.Value = DateTime.Today.AddDays(7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();

            model = new Dashboard();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData == true)
            {
                lblAmountReecived.Text = model.TotalAmountReceived.ToString();
                lblAmountOweing.Text = model.TotalAmountOwing.ToString();
                lblOneBedFlats.Text = model.TotalOneBedFlats.ToString();
                lblSelfContain.Text = model.TotalselfConFlats.ToString();
                lblTwoBedFlats.Text = model.TotalTwoBedFlats.ToString();

                dgvListOfAllTenants.DataSource = model.AllTenantList;
                dgvListOfAllTenants.Columns[0].HeaderText = "Tenant Name";
                dgvListOfAllTenants.Columns[1].HeaderText = "Amount Paid";
                dgvListOfAllTenants.Columns[2].HeaderText = "Date Of First Payment";
                dgvListOfAllTenants.Columns[3].HeaderText = "Date Of Next Payment";
                dgvListOfAllTenants.Columns[4].HeaderText = "Balance Amount";

                dgvListofTenantOweing.DataSource = model.TenantOwingtList;
                dgvListofTenantOweing.Columns[0].HeaderText = "Tenant Name";
                dgvListofTenantOweing.Columns[1].HeaderText = "Amount Paid";
                dgvListofTenantOweing.Columns[2].HeaderText = "Date Of First Payment";
                dgvListofTenantOweing.Columns[3].HeaderText = "Date Of Next Payment";
                dgvListofTenantOweing.Columns[4].HeaderText = "Balance Amount";

                Console.WriteLine("Loaded view :");
            }
            else
            {
                Console.WriteLine("View not loaded, same query");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOkCustomDate.Visible = false;
        }

        //Event methos
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadDashboardData();
            DisableCustomDates();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadDashboardData();
            DisableCustomDates();
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadDashboardData();
            DisableCustomDates();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadDashboardData();
            DisableCustomDates();
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOkCustomDate.Visible = true;
        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
        }
    }
}
