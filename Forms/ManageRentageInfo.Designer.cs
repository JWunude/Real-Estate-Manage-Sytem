
namespace Lems.Forms
{
    partial class ManageRentageInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDisplayProperty = new System.Windows.Forms.Panel();
            this.lblPID = new System.Windows.Forms.Label();
            this.dgvDisplayRentageInfo = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenantUniqueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfFirstPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDueForNextPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenancyDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateForGracePeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenancyStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remakrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnAddNew = new FontAwesome.Sharp.IconButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintReceipt = new FontAwesome.Sharp.IconButton();
            this.panelDisplayProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayRentageInfo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDisplayProperty
            // 
            this.panelDisplayProperty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDisplayProperty.BackColor = System.Drawing.Color.White;
            this.panelDisplayProperty.Controls.Add(this.lblPID);
            this.panelDisplayProperty.Controls.Add(this.dgvDisplayRentageInfo);
            this.panelDisplayProperty.Controls.Add(this.txtSearch);
            this.panelDisplayProperty.Controls.Add(this.btnSearch);
            this.panelDisplayProperty.Controls.Add(this.btnPrintReceipt);
            this.panelDisplayProperty.Controls.Add(this.btnAddNew);
            this.panelDisplayProperty.Location = new System.Drawing.Point(12, 75);
            this.panelDisplayProperty.Name = "panelDisplayProperty";
            this.panelDisplayProperty.Size = new System.Drawing.Size(1537, 771);
            this.panelDisplayProperty.TabIndex = 3;
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(1099, 10);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(35, 13);
            this.lblPID.TabIndex = 3;
            this.lblPID.Text = "label2";
            this.lblPID.Visible = false;
            // 
            // dgvDisplayRentageInfo
            // 
            this.dgvDisplayRentageInfo.AllowUserToAddRows = false;
            this.dgvDisplayRentageInfo.AllowUserToDeleteRows = false;
            this.dgvDisplayRentageInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisplayRentageInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDisplayRentageInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvDisplayRentageInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisplayRentageInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplayRentageInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisplayRentageInfo.ColumnHeadersHeight = 35;
            this.dgvDisplayRentageInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEdit,
            this.btnDelete,
            this.RID,
            this.TenantUniqueID,
            this.ACDescription,
            this.ActualAmount,
            this.AmountPaid,
            this.DateOfFirstPayment,
            this.DateDueForNextPayment,
            this.TenancyDuration,
            this.DateForGracePeriod,
            this.BalanceAmount,
            this.TenancyStatus,
            this.Remakrs,
            this.Comments});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisplayRentageInfo.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDisplayRentageInfo.EnableHeadersVisualStyles = false;
            this.dgvDisplayRentageInfo.Location = new System.Drawing.Point(9, 76);
            this.dgvDisplayRentageInfo.Name = "dgvDisplayRentageInfo";
            this.dgvDisplayRentageInfo.ReadOnly = true;
            this.dgvDisplayRentageInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDisplayRentageInfo.RowHeadersVisible = false;
            this.dgvDisplayRentageInfo.ShowEditingIcon = false;
            this.dgvDisplayRentageInfo.Size = new System.Drawing.Size(1510, 677);
            this.dgvDisplayRentageInfo.TabIndex = 2;
            this.dgvDisplayRentageInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayRentageInfo_CellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.btnEdit.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.HeaderText = "";
            this.btnEdit.MinimumWidth = 100;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.Text = "Edit";
            this.btnEdit.ToolTipText = "Click to Edit selected record";
            this.btnEdit.UseColumnTextForButtonValue = true;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.btnDelete.DefaultCellStyle = dataGridViewCellStyle3;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.HeaderText = "";
            this.btnDelete.MinimumWidth = 100;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Delete";
            this.btnDelete.ToolTipText = "Click to Delete selected record";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // RID
            // 
            this.RID.DataPropertyName = "RID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RID.DefaultCellStyle = dataGridViewCellStyle4;
            this.RID.HeaderText = "Rentage-ID";
            this.RID.Name = "RID";
            this.RID.ReadOnly = true;
            this.RID.Width = 120;
            // 
            // TenantUniqueID
            // 
            this.TenantUniqueID.DataPropertyName = "TenantUniqueID";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenantUniqueID.DefaultCellStyle = dataGridViewCellStyle5;
            this.TenantUniqueID.HeaderText = "Tenant-Unique ID";
            this.TenantUniqueID.Name = "TenantUniqueID";
            this.TenantUniqueID.ReadOnly = true;
            this.TenantUniqueID.Width = 150;
            // 
            // ACDescription
            // 
            this.ACDescription.DataPropertyName = "ACDescription";
            this.ACDescription.HeaderText = "Accomodation Type";
            this.ACDescription.Name = "ACDescription";
            this.ACDescription.ReadOnly = true;
            this.ACDescription.Width = 150;
            // 
            // ActualAmount
            // 
            this.ActualAmount.DataPropertyName = "ActualAmount";
            this.ActualAmount.HeaderText = "Actual Amount";
            this.ActualAmount.Name = "ActualAmount";
            this.ActualAmount.ReadOnly = true;
            this.ActualAmount.Width = 120;
            // 
            // AmountPaid
            // 
            this.AmountPaid.DataPropertyName = "AmountPaid";
            this.AmountPaid.HeaderText = "Amount Paid";
            this.AmountPaid.Name = "AmountPaid";
            this.AmountPaid.ReadOnly = true;
            this.AmountPaid.Width = 110;
            // 
            // DateOfFirstPayment
            // 
            this.DateOfFirstPayment.DataPropertyName = "DateOfFirstPayment";
            this.DateOfFirstPayment.HeaderText = "Date of Payment";
            this.DateOfFirstPayment.Name = "DateOfFirstPayment";
            this.DateOfFirstPayment.ReadOnly = true;
            this.DateOfFirstPayment.Width = 120;
            // 
            // DateDueForNextPayment
            // 
            this.DateDueForNextPayment.DataPropertyName = "DateDueForNextPayment";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateDueForNextPayment.DefaultCellStyle = dataGridViewCellStyle6;
            this.DateDueForNextPayment.HeaderText = "Next Due Date";
            this.DateDueForNextPayment.Name = "DateDueForNextPayment";
            this.DateDueForNextPayment.ReadOnly = true;
            this.DateDueForNextPayment.Width = 120;
            // 
            // TenancyDuration
            // 
            this.TenancyDuration.DataPropertyName = "TenancyDuration";
            this.TenancyDuration.HeaderText = "Duration";
            this.TenancyDuration.Name = "TenancyDuration";
            this.TenancyDuration.ReadOnly = true;
            this.TenancyDuration.Width = 60;
            // 
            // DateForGracePeriod
            // 
            this.DateForGracePeriod.DataPropertyName = "DateForGracePeriod";
            this.DateForGracePeriod.HeaderText = "Grace Period Date";
            this.DateForGracePeriod.Name = "DateForGracePeriod";
            this.DateForGracePeriod.ReadOnly = true;
            this.DateForGracePeriod.Width = 130;
            // 
            // BalanceAmount
            // 
            this.BalanceAmount.DataPropertyName = "BalanceAmount";
            this.BalanceAmount.HeaderText = "Balance Amount";
            this.BalanceAmount.Name = "BalanceAmount";
            this.BalanceAmount.ReadOnly = true;
            this.BalanceAmount.Width = 120;
            // 
            // TenancyStatus
            // 
            this.TenancyStatus.DataPropertyName = "TenancyStatus";
            this.TenancyStatus.HeaderText = "Tenancy Status";
            this.TenancyStatus.Name = "TenancyStatus";
            this.TenancyStatus.ReadOnly = true;
            this.TenancyStatus.Width = 120;
            // 
            // Remakrs
            // 
            this.Remakrs.DataPropertyName = "Remakrs";
            this.Remakrs.HeaderText = "Remarks";
            this.Remakrs.Name = "Remakrs";
            this.Remakrs.ReadOnly = true;
            this.Remakrs.Width = 200;
            // 
            // Comments
            // 
            this.Comments.DataPropertyName = "Comments";
            this.Comments.HeaderText = "Comment";
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            this.Comments.Width = 200;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderColor = System.Drawing.Color.Indigo;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearch.BorderRadius = 0;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(1137, 7);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.Size = new System.Drawing.Size(354, 35);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Indigo;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Indigo;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 35;
            this.btnSearch.Location = new System.Drawing.Point(1488, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 35);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Indigo;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddNew.IconColor = System.Drawing.Color.GhostWhite;
            this.btnAddNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNew.IconSize = 32;
            this.btnAddNew.Location = new System.Drawing.Point(9, 12);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(151, 42);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Take New Rent";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Indigo;
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1573, 50);
            this.panelTop.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Silver;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.Location = new System.Drawing.Point(1535, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 36);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(615, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "View  / Manage Rentage Information";
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.BackColor = System.Drawing.Color.Indigo;
            this.btnPrintReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintReceipt.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnPrintReceipt.FlatAppearance.BorderSize = 0;
            this.btnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReceipt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReceipt.ForeColor = System.Drawing.Color.White;
            this.btnPrintReceipt.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnPrintReceipt.IconColor = System.Drawing.Color.GhostWhite;
            this.btnPrintReceipt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrintReceipt.IconSize = 32;
            this.btnPrintReceipt.Location = new System.Drawing.Point(166, 12);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(151, 42);
            this.btnPrintReceipt.TabIndex = 0;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintReceipt.UseVisualStyleBackColor = false;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // ManageRentageInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1573, 865);
            this.Controls.Add(this.panelDisplayProperty);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageRentageInfo";
            this.Text = "Rentage Information";
            this.Shown += new System.EventHandler(this.ManageRentageInfo_Shown);
            this.panelDisplayProperty.ResumeLayout(false);
            this.panelDisplayProperty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayRentageInfo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDisplayProperty;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.DataGridView dgvDisplayRentageInfo;
        private RJCodeAdvance.RJControls.RJTextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnAddNew;
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn RID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenantUniqueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfFirstPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDueForNextPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenancyDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateForGracePeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenancyStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remakrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private FontAwesome.Sharp.IconButton btnPrintReceipt;
    }
}