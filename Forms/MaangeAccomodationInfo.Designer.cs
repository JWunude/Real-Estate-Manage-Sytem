
namespace Lems.Forms
{
    partial class MaangeAccomodationInfo
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panelDisplayProperty = new System.Windows.Forms.Panel();
            this.btnAddNew = new FontAwesome.Sharp.IconButton();
            this.lblPID = new System.Windows.Forms.Label();
            this.dgvDisplayAccomodation = new System.Windows.Forms.DataGridView();
            this.txtSearch = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.RecID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPerMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPerYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelTop.SuspendLayout();
            this.panelDisplayProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAccomodation)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Indigo;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1442, 50);
            this.panelTop.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(571, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "View  / Manage Accomodation ";
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
            this.btnExit.Location = new System.Drawing.Point(1404, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 36);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelDisplayProperty
            // 
            this.panelDisplayProperty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDisplayProperty.BackColor = System.Drawing.Color.White;
            this.panelDisplayProperty.Controls.Add(this.btnAddNew);
            this.panelDisplayProperty.Controls.Add(this.lblPID);
            this.panelDisplayProperty.Controls.Add(this.dgvDisplayAccomodation);
            this.panelDisplayProperty.Controls.Add(this.txtSearch);
            this.panelDisplayProperty.Controls.Add(this.btnSearch);
            this.panelDisplayProperty.Location = new System.Drawing.Point(16, 71);
            this.panelDisplayProperty.Name = "panelDisplayProperty";
            this.panelDisplayProperty.Size = new System.Drawing.Size(1407, 779);
            this.panelDisplayProperty.TabIndex = 6;
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
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "New Accomodation";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
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
            // dgvDisplayAccomodation
            // 
            this.dgvDisplayAccomodation.AllowUserToAddRows = false;
            this.dgvDisplayAccomodation.AllowUserToDeleteRows = false;
            this.dgvDisplayAccomodation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisplayAccomodation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDisplayAccomodation.BackgroundColor = System.Drawing.Color.White;
            this.dgvDisplayAccomodation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisplayAccomodation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplayAccomodation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisplayAccomodation.ColumnHeadersHeight = 35;
            this.dgvDisplayAccomodation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecID,
            this.AID,
            this.PID,
            this.ACDescription,
            this.ACNumber,
            this.AmountPerMonth,
            this.AmountPerYear,
            this.ACStatus,
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
            this.dgvDisplayAccomodation.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDisplayAccomodation.EnableHeadersVisualStyles = false;
            this.dgvDisplayAccomodation.Location = new System.Drawing.Point(9, 76);
            this.dgvDisplayAccomodation.Name = "dgvDisplayAccomodation";
            this.dgvDisplayAccomodation.ReadOnly = true;
            this.dgvDisplayAccomodation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDisplayAccomodation.RowHeadersVisible = false;
            this.dgvDisplayAccomodation.ShowEditingIcon = false;
            this.dgvDisplayAccomodation.Size = new System.Drawing.Size(1380, 685);
            this.dgvDisplayAccomodation.TabIndex = 2;
            this.dgvDisplayAccomodation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayAccomodation_CellClick);
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
            this.txtSearch.Location = new System.Drawing.Point(998, 19);
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
            this.btnSearch.Location = new System.Drawing.Point(1349, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 35);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.UseVisualStyleBackColor = false;
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
            // AID
            // 
            this.AID.DataPropertyName = "AID";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AID.DefaultCellStyle = dataGridViewCellStyle3;
            this.AID.HeaderText = "Accomation-ID";
            this.AID.Name = "AID";
            this.AID.ReadOnly = true;
            this.AID.Width = 130;
            // 
            // PID
            // 
            this.PID.DataPropertyName = "PID";
            this.PID.HeaderText = "Property ID";
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            this.PID.Width = 130;
            // 
            // ACDescription
            // 
            this.ACDescription.DataPropertyName = "ACDescription";
            this.ACDescription.HeaderText = "Description";
            this.ACDescription.Name = "ACDescription";
            this.ACDescription.ReadOnly = true;
            this.ACDescription.Width = 300;
            // 
            // ACNumber
            // 
            this.ACNumber.DataPropertyName = "ACNumber";
            this.ACNumber.HeaderText = "Flat / Room No";
            this.ACNumber.Name = "ACNumber";
            this.ACNumber.ReadOnly = true;
            this.ACNumber.Width = 120;
            // 
            // AmountPerMonth
            // 
            this.AmountPerMonth.DataPropertyName = "AmountPerMonth";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AmountPerMonth.DefaultCellStyle = dataGridViewCellStyle4;
            this.AmountPerMonth.HeaderText = "Monthly Payment";
            this.AmountPerMonth.Name = "AmountPerMonth";
            this.AmountPerMonth.ReadOnly = true;
            this.AmountPerMonth.Width = 130;
            // 
            // AmountPerYear
            // 
            this.AmountPerYear.DataPropertyName = "AmountPerYear";
            this.AmountPerYear.HeaderText = "Yearly Payment";
            this.AmountPerYear.Name = "AmountPerYear";
            this.AmountPerYear.ReadOnly = true;
            this.AmountPerYear.Width = 130;
            // 
            // ACStatus
            // 
            this.ACStatus.DataPropertyName = "ACStatus";
            this.ACStatus.HeaderText = "Status";
            this.ACStatus.Name = "ACStatus";
            this.ACStatus.ReadOnly = true;
            this.ACStatus.Width = 180;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.Width = 250;
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
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Delete";
            this.btnDelete.ToolTipText = "Click to Delete selected record";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // MaangeAccomodationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1442, 886);
            this.Controls.Add(this.panelDisplayProperty);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MaangeAccomodationInfo";
            this.Text = "Manage Accomodation";
            this.Shown += new System.EventHandler(this.MaangeAccomodationInfo_Shown);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelDisplayProperty.ResumeLayout(false);
            this.panelDisplayProperty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAccomodation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel panelDisplayProperty;
        private FontAwesome.Sharp.IconButton btnAddNew;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.DataGridView dgvDisplayAccomodation;
        private RJCodeAdvance.RJControls.RJTextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPerMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPerYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}