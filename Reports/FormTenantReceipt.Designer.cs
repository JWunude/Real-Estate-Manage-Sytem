
namespace Lems.Reports
{
    partial class FormTenantReceipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.cboReceptNo = new System.Windows.Forms.ComboBox();
            this.cboTenantUniqueID = new System.Windows.Forms.ComboBox();
            this.btnDisplayReceipt = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDisplayTitle = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.reportViewerTenantReceipt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.panelTitleBar.Controls.Add(this.cboReceptNo);
            this.panelTitleBar.Controls.Add(this.cboTenantUniqueID);
            this.panelTitleBar.Controls.Add(this.btnDisplayReceipt);
            this.panelTitleBar.Controls.Add(this.label2);
            this.panelTitleBar.Controls.Add(this.iconButton1);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.lblDisplayTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1279, 41);
            this.panelTitleBar.TabIndex = 3;
            // 
            // cboReceptNo
            // 
            this.cboReceptNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboReceptNo.BackColor = System.Drawing.Color.White;
            this.cboReceptNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReceptNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReceptNo.FormattingEnabled = true;
            this.cboReceptNo.Items.AddRange(new object[] {
            "Driver\'s License",
            "Int\'l Passport",
            "National ID",
            "Voters Passport"});
            this.cboReceptNo.Location = new System.Drawing.Point(805, 4);
            this.cboReceptNo.Name = "cboReceptNo";
            this.cboReceptNo.Size = new System.Drawing.Size(243, 28);
            this.cboReceptNo.Sorted = true;
            this.cboReceptNo.TabIndex = 6;
            this.cboReceptNo.SelectedIndexChanged += new System.EventHandler(this.cboReceptNo_SelectedIndexChanged);
            // 
            // cboTenantUniqueID
            // 
            this.cboTenantUniqueID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboTenantUniqueID.BackColor = System.Drawing.Color.White;
            this.cboTenantUniqueID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenantUniqueID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenantUniqueID.FormattingEnabled = true;
            this.cboTenantUniqueID.Items.AddRange(new object[] {
            "Driver\'s License",
            "Int\'l Passport",
            "National ID",
            "Voters Passport"});
            this.cboTenantUniqueID.Location = new System.Drawing.Point(349, 6);
            this.cboTenantUniqueID.Name = "cboTenantUniqueID";
            this.cboTenantUniqueID.Size = new System.Drawing.Size(342, 28);
            this.cboTenantUniqueID.Sorted = true;
            this.cboTenantUniqueID.TabIndex = 6;
            this.cboTenantUniqueID.SelectedIndexChanged += new System.EventHandler(this.cboTenantUniqueID_SelectedIndexChanged);
            // 
            // btnDisplayReceipt
            // 
            this.btnDisplayReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.btnDisplayReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplayReceipt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDisplayReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayReceipt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayReceipt.ForeColor = System.Drawing.Color.White;
            this.btnDisplayReceipt.IconChar = FontAwesome.Sharp.IconChar.Readme;
            this.btnDisplayReceipt.IconColor = System.Drawing.Color.GhostWhite;
            this.btnDisplayReceipt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDisplayReceipt.IconSize = 32;
            this.btnDisplayReceipt.Location = new System.Drawing.Point(1054, 0);
            this.btnDisplayReceipt.Name = "btnDisplayReceipt";
            this.btnDisplayReceipt.Size = new System.Drawing.Size(163, 34);
            this.btnDisplayReceipt.TabIndex = 5;
            this.btnDisplayReceipt.Text = "&Display Receipt";
            this.btnDisplayReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisplayReceipt.UseVisualStyleBackColor = false;
            this.btnDisplayReceipt.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(697, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Receipt No:";
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(1247, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(32, 41);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(220, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tenant Name";
            // 
            // lblDisplayTitle
            // 
            this.lblDisplayTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDisplayTitle.AutoSize = true;
            this.lblDisplayTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTitle.ForeColor = System.Drawing.Color.White;
            this.lblDisplayTitle.Location = new System.Drawing.Point(3, 7);
            this.lblDisplayTitle.Name = "lblDisplayTitle";
            this.lblDisplayTitle.Size = new System.Drawing.Size(194, 23);
            this.lblDisplayTitle.TabIndex = 1;
            this.lblDisplayTitle.Text = "Print Renant Receipt";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 830);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1279, 20);
            this.panelBottom.TabIndex = 4;
            // 
            // reportViewerTenantReceipt
            // 
            this.reportViewerTenantReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerTenantReceipt.LocalReport.ReportEmbeddedResource = "Lems.Reports.ReportTenantReceipt.rdlc";
            this.reportViewerTenantReceipt.Location = new System.Drawing.Point(0, 41);
            this.reportViewerTenantReceipt.Name = "reportViewerTenantReceipt";
            this.reportViewerTenantReceipt.ServerReport.BearerToken = null;
            this.reportViewerTenantReceipt.Size = new System.Drawing.Size(1279, 789);
            this.reportViewerTenantReceipt.TabIndex = 5;
            // 
            // FormTenantReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1279, 850);
            this.Controls.Add(this.reportViewerTenantReceipt);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTenantReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTenantReceipt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTenantReceipt_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblDisplayTitle;
        private System.Windows.Forms.Panel panelBottom;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerTenantReceipt;
        private FontAwesome.Sharp.IconButton btnDisplayReceipt;
        private System.Windows.Forms.ComboBox cboTenantUniqueID;
        private System.Windows.Forms.ComboBox cboReceptNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}