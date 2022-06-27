
namespace Lems.Forms
{
    partial class ManageTenantInfo
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
            this.dgvDisplayTenantInfo = new System.Windows.Forms.DataGridView();
            this.txtSearch = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnAddNew = new FontAwesome.Sharp.IconButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.RecID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomePhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeansOfIdentification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentificationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GurantorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuarantorPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GurantorAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GurantorRelationShip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelDisplayProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayTenantInfo)).BeginInit();
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
            this.panelDisplayProperty.Controls.Add(this.dgvDisplayTenantInfo);
            this.panelDisplayProperty.Controls.Add(this.txtSearch);
            this.panelDisplayProperty.Controls.Add(this.btnSearch);
            this.panelDisplayProperty.Controls.Add(this.btnAddNew);
            this.panelDisplayProperty.Location = new System.Drawing.Point(24, 71);
            this.panelDisplayProperty.Name = "panelDisplayProperty";
            this.panelDisplayProperty.Size = new System.Drawing.Size(1568, 822);
            this.panelDisplayProperty.TabIndex = 5;
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(1125, 0);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(35, 13);
            this.lblPID.TabIndex = 3;
            this.lblPID.Text = "label2";
            this.lblPID.Visible = false;
            // 
            // dgvDisplayTenantInfo
            // 
            this.dgvDisplayTenantInfo.AllowUserToAddRows = false;
            this.dgvDisplayTenantInfo.AllowUserToDeleteRows = false;
            this.dgvDisplayTenantInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisplayTenantInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDisplayTenantInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvDisplayTenantInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisplayTenantInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplayTenantInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisplayTenantInfo.ColumnHeadersHeight = 35;
            this.dgvDisplayTenantInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecID,
            this.TID,
            this.FullName,
            this.HomePhoneNumber,
            this.WorkPhoneNumber,
            this.HomeAddress,
            this.EmailAddress,
            this.MeansOfIdentification,
            this.IdentificationNumber,
            this.GurantorName,
            this.GuarantorPhoneNumber,
            this.GurantorAddress,
            this.GurantorRelationShip,
            this.Remarks,
            this.btnEdit,
            this.btnDelete});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisplayTenantInfo.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDisplayTenantInfo.EnableHeadersVisualStyles = false;
            this.dgvDisplayTenantInfo.Location = new System.Drawing.Point(9, 76);
            this.dgvDisplayTenantInfo.Name = "dgvDisplayTenantInfo";
            this.dgvDisplayTenantInfo.ReadOnly = true;
            this.dgvDisplayTenantInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDisplayTenantInfo.RowHeadersVisible = false;
            this.dgvDisplayTenantInfo.ShowEditingIcon = false;
            this.dgvDisplayTenantInfo.Size = new System.Drawing.Size(1541, 728);
            this.dgvDisplayTenantInfo.TabIndex = 2;
            this.dgvDisplayTenantInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayProperty_CellClick);
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
            this.txtSearch.Location = new System.Drawing.Point(1159, 19);
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
            this.btnSearch.Location = new System.Drawing.Point(1510, 19);
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
            this.btnAddNew.Size = new System.Drawing.Size(192, 42);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New Tenant";
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
            this.panelTop.Size = new System.Drawing.Size(1604, 50);
            this.panelTop.TabIndex = 4;
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
            this.btnExit.Location = new System.Drawing.Point(1566, 15);
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
            this.label1.Location = new System.Drawing.Point(631, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "View  / Manage Tenancy Information";
            // 
            // RecID
            // 
            this.RecID.DataPropertyName = "RecID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RecID.DefaultCellStyle = dataGridViewCellStyle2;
            this.RecID.HeaderText = "Record-ID";
            this.RecID.Name = "RecID";
            this.RecID.ReadOnly = true;
            this.RecID.Visible = false;
            this.RecID.Width = 80;
            // 
            // TID
            // 
            this.TID.DataPropertyName = "TID";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TID.DefaultCellStyle = dataGridViewCellStyle3;
            this.TID.HeaderText = "Tenant-ID";
            this.TID.Name = "TID";
            this.TID.ReadOnly = true;
            this.TID.Width = 120;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 190;
            // 
            // HomePhoneNumber
            // 
            this.HomePhoneNumber.DataPropertyName = "HomePhoneNumber";
            this.HomePhoneNumber.HeaderText = "Home Phone No";
            this.HomePhoneNumber.Name = "HomePhoneNumber";
            this.HomePhoneNumber.ReadOnly = true;
            this.HomePhoneNumber.Width = 150;
            // 
            // WorkPhoneNumber
            // 
            this.WorkPhoneNumber.DataPropertyName = "WorkPhoneNumber";
            this.WorkPhoneNumber.HeaderText = "Work Phone No";
            this.WorkPhoneNumber.Name = "WorkPhoneNumber";
            this.WorkPhoneNumber.ReadOnly = true;
            this.WorkPhoneNumber.Visible = false;
            this.WorkPhoneNumber.Width = 80;
            // 
            // HomeAddress
            // 
            this.HomeAddress.DataPropertyName = "HomeAddress";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HomeAddress.DefaultCellStyle = dataGridViewCellStyle4;
            this.HomeAddress.HeaderText = "Home Address";
            this.HomeAddress.Name = "HomeAddress";
            this.HomeAddress.ReadOnly = true;
            this.HomeAddress.Width = 200;
            // 
            // EmailAddress
            // 
            this.EmailAddress.DataPropertyName = "EmailAddress";
            this.EmailAddress.HeaderText = "Email Address";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            this.EmailAddress.Visible = false;
            this.EmailAddress.Width = 150;
            // 
            // MeansOfIdentification
            // 
            this.MeansOfIdentification.DataPropertyName = "MeansOfIdentification";
            this.MeansOfIdentification.HeaderText = "Means Of ID";
            this.MeansOfIdentification.Name = "MeansOfIdentification";
            this.MeansOfIdentification.ReadOnly = true;
            this.MeansOfIdentification.Width = 120;
            // 
            // IdentificationNumber
            // 
            this.IdentificationNumber.DataPropertyName = "IdentificationNumber";
            this.IdentificationNumber.HeaderText = "ID Number";
            this.IdentificationNumber.Name = "IdentificationNumber";
            this.IdentificationNumber.ReadOnly = true;
            this.IdentificationNumber.Width = 120;
            // 
            // GurantorName
            // 
            this.GurantorName.DataPropertyName = "GurantorName";
            this.GurantorName.HeaderText = "Gurantor Name";
            this.GurantorName.Name = "GurantorName";
            this.GurantorName.ReadOnly = true;
            this.GurantorName.Width = 190;
            // 
            // GuarantorPhoneNumber
            // 
            this.GuarantorPhoneNumber.DataPropertyName = "GuarantorPhoneNumber";
            this.GuarantorPhoneNumber.HeaderText = "Guarantor Phone No";
            this.GuarantorPhoneNumber.Name = "GuarantorPhoneNumber";
            this.GuarantorPhoneNumber.ReadOnly = true;
            this.GuarantorPhoneNumber.Width = 120;
            // 
            // GurantorAddress
            // 
            this.GurantorAddress.DataPropertyName = "GurantorAddress";
            this.GurantorAddress.HeaderText = "Gurantor Address";
            this.GurantorAddress.Name = "GurantorAddress";
            this.GurantorAddress.ReadOnly = true;
            this.GurantorAddress.Width = 190;
            // 
            // GurantorRelationShip
            // 
            this.GurantorRelationShip.DataPropertyName = "GurantorRelationShip";
            this.GurantorRelationShip.HeaderText = "Gurantor Relation Ship";
            this.GurantorRelationShip.Name = "GurantorRelationShip";
            this.GurantorRelationShip.ReadOnly = true;
            this.GurantorRelationShip.Width = 150;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.Visible = false;
            this.Remarks.Width = 190;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.btnEdit.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.btnDelete.DefaultCellStyle = dataGridViewCellStyle6;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.HeaderText = "";
            this.btnDelete.MinimumWidth = 100;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Delete";
            this.btnDelete.ToolTipText = "Click to Delete selected record";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // ManageTenantInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 905);
            this.Controls.Add(this.panelDisplayProperty);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageTenantInfo";
            this.Text = "Manage Tenancy Details";
            this.Shown += new System.EventHandler(this.ManageTenantInfo_Shown);
            this.panelDisplayProperty.ResumeLayout(false);
            this.panelDisplayProperty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayTenantInfo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDisplayProperty;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.DataGridView dgvDisplayTenantInfo;
        private RJCodeAdvance.RJControls.RJTextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnAddNew;
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomePhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeansOfIdentification;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentificationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn GurantorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuarantorPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn GurantorAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn GurantorRelationShip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}