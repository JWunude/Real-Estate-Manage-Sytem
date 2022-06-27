
namespace Lems.Forms
{
    partial class FormAddTenant
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
            this.components = new System.ComponentModel.Container();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblDisplayTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtGeneralRemarks = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtGuarantorRelationShip = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtGuarantorAddress = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtGuarantorPhoneNo = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtGuarantorName = new RJCodeAdvance.RJControls.RJTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenantID = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtFullName = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtHomePhoneNo = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtWorkPhoneNo = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtHomeAddress = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtEmailAddress = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtIDNumber = new RJCodeAdvance.RJControls.RJTextBox();
            this.cboMeansOfIdentification = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Indigo;
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.lblDisplayTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(804, 50);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnExit.IconColor = System.Drawing.Color.Red;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 40;
            this.btnExit.Location = new System.Drawing.Point(768, 10);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 35);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDisplayTitle
            // 
            this.lblDisplayTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDisplayTitle.AutoSize = true;
            this.lblDisplayTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTitle.ForeColor = System.Drawing.Color.White;
            this.lblDisplayTitle.Location = new System.Drawing.Point(343, 14);
            this.lblDisplayTitle.Name = "lblDisplayTitle";
            this.lblDisplayTitle.Size = new System.Drawing.Size(162, 23);
            this.lblDisplayTitle.TabIndex = 1;
            this.lblDisplayTitle.Text = "Add New Tenant";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(20, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 636);
            this.panel1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.Color.Indigo;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.GhostWhite;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 32;
            this.btnSave.Location = new System.Drawing.Point(201, 588);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtGeneralRemarks, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.txtGuarantorRelationShip, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.txtGuarantorAddress, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.txtGuarantorPhoneNo, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtGuarantorName, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtTenantID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFullName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtHomePhoneNo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtWorkPhoneNo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtHomeAddress, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtEmailAddress, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtIDNumber, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cboMeansOfIdentification, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(721, 579);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtGeneralRemarks
            // 
            this.txtGeneralRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGeneralRemarks.BackColor = System.Drawing.SystemColors.Window;
            this.txtGeneralRemarks.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtGeneralRemarks.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGeneralRemarks.BorderRadius = 0;
            this.txtGeneralRemarks.BorderSize = 2;
            this.txtGeneralRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneralRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGeneralRemarks.Location = new System.Drawing.Point(199, 519);
            this.txtGeneralRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtGeneralRemarks.Multiline = true;
            this.txtGeneralRemarks.Name = "txtGeneralRemarks";
            this.txtGeneralRemarks.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGeneralRemarks.PasswordChar = false;
            this.txtGeneralRemarks.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGeneralRemarks.PlaceholderText = "";
            this.txtGeneralRemarks.Size = new System.Drawing.Size(498, 56);
            this.txtGeneralRemarks.TabIndex = 12;
            this.txtGeneralRemarks.Texts = "";
            this.txtGeneralRemarks.UnderlinedStyle = false;
            // 
            // txtGuarantorRelationShip
            // 
            this.txtGuarantorRelationShip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGuarantorRelationShip.BackColor = System.Drawing.SystemColors.Window;
            this.txtGuarantorRelationShip.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtGuarantorRelationShip.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGuarantorRelationShip.BorderRadius = 0;
            this.txtGuarantorRelationShip.BorderSize = 2;
            this.txtGuarantorRelationShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuarantorRelationShip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGuarantorRelationShip.Location = new System.Drawing.Point(199, 477);
            this.txtGuarantorRelationShip.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuarantorRelationShip.Multiline = false;
            this.txtGuarantorRelationShip.Name = "txtGuarantorRelationShip";
            this.txtGuarantorRelationShip.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGuarantorRelationShip.PasswordChar = false;
            this.txtGuarantorRelationShip.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGuarantorRelationShip.PlaceholderText = "";
            this.txtGuarantorRelationShip.Size = new System.Drawing.Size(498, 31);
            this.txtGuarantorRelationShip.TabIndex = 11;
            this.txtGuarantorRelationShip.Texts = "";
            this.txtGuarantorRelationShip.UnderlinedStyle = false;
            // 
            // txtGuarantorAddress
            // 
            this.txtGuarantorAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGuarantorAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtGuarantorAddress.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtGuarantorAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGuarantorAddress.BorderRadius = 0;
            this.txtGuarantorAddress.BorderSize = 2;
            this.txtGuarantorAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuarantorAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGuarantorAddress.Location = new System.Drawing.Point(199, 438);
            this.txtGuarantorAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuarantorAddress.Multiline = false;
            this.txtGuarantorAddress.Name = "txtGuarantorAddress";
            this.txtGuarantorAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGuarantorAddress.PasswordChar = false;
            this.txtGuarantorAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGuarantorAddress.PlaceholderText = "";
            this.txtGuarantorAddress.Size = new System.Drawing.Size(498, 31);
            this.txtGuarantorAddress.TabIndex = 10;
            this.txtGuarantorAddress.Texts = "";
            this.txtGuarantorAddress.UnderlinedStyle = false;
            // 
            // txtGuarantorPhoneNo
            // 
            this.txtGuarantorPhoneNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGuarantorPhoneNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtGuarantorPhoneNo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtGuarantorPhoneNo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGuarantorPhoneNo.BorderRadius = 0;
            this.txtGuarantorPhoneNo.BorderSize = 2;
            this.txtGuarantorPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuarantorPhoneNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGuarantorPhoneNo.Location = new System.Drawing.Point(199, 396);
            this.txtGuarantorPhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuarantorPhoneNo.Multiline = false;
            this.txtGuarantorPhoneNo.Name = "txtGuarantorPhoneNo";
            this.txtGuarantorPhoneNo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGuarantorPhoneNo.PasswordChar = false;
            this.txtGuarantorPhoneNo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGuarantorPhoneNo.PlaceholderText = "";
            this.txtGuarantorPhoneNo.Size = new System.Drawing.Size(498, 31);
            this.txtGuarantorPhoneNo.TabIndex = 9;
            this.txtGuarantorPhoneNo.Texts = "";
            this.txtGuarantorPhoneNo.UnderlinedStyle = false;
            // 
            // txtGuarantorName
            // 
            this.txtGuarantorName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGuarantorName.BackColor = System.Drawing.SystemColors.Window;
            this.txtGuarantorName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtGuarantorName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGuarantorName.BorderRadius = 0;
            this.txtGuarantorName.BorderSize = 2;
            this.txtGuarantorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuarantorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGuarantorName.Location = new System.Drawing.Point(199, 353);
            this.txtGuarantorName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuarantorName.Multiline = false;
            this.txtGuarantorName.Name = "txtGuarantorName";
            this.txtGuarantorName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGuarantorName.PasswordChar = false;
            this.txtGuarantorName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGuarantorName.PlaceholderText = "";
            this.txtGuarantorName.Size = new System.Drawing.Size(498, 31);
            this.txtGuarantorName.TabIndex = 8;
            this.txtGuarantorName.Texts = "";
            this.txtGuarantorName.UnderlinedStyle = false;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 515);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 64);
            this.label13.TabIndex = 0;
            this.label13.Text = "General Remarks :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 473);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 42);
            this.label12.TabIndex = 0;
            this.label12.Text = "Guarantor Relationship. :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 434);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 39);
            this.label11.TabIndex = 0;
            this.label11.Text = "Guarantor Address. :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 42);
            this.label10.TabIndex = 0;
            this.label10.Text = "Guarantor Phone No. :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 43);
            this.label9.TabIndex = 0;
            this.label9.Text = "Guarantor Name :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tenant ID :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full Name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Home Phone No. :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 42);
            this.label4.TabIndex = 0;
            this.label4.Text = "Work Phone No. :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 62);
            this.label5.TabIndex = 0;
            this.label5.Text = "Home Address :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 50);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email Address:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 34);
            this.label7.TabIndex = 0;
            this.label7.Text = "Means Of Identification :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 41);
            this.label8.TabIndex = 0;
            this.label8.Text = "Identification No :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTenantID
            // 
            this.txtTenantID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenantID.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenantID.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenantID.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenantID.BorderRadius = 0;
            this.txtTenantID.BorderSize = 2;
            this.txtTenantID.Enabled = false;
            this.txtTenantID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenantID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenantID.Location = new System.Drawing.Point(199, 4);
            this.txtTenantID.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenantID.Multiline = false;
            this.txtTenantID.Name = "txtTenantID";
            this.txtTenantID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTenantID.PasswordChar = false;
            this.txtTenantID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenantID.PlaceholderText = "";
            this.txtTenantID.Size = new System.Drawing.Size(498, 31);
            this.txtTenantID.TabIndex = 0;
            this.txtTenantID.Texts = "";
            this.txtTenantID.UnderlinedStyle = false;
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFullName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtFullName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtFullName.BorderRadius = 0;
            this.txtFullName.BorderSize = 2;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFullName.Location = new System.Drawing.Point(199, 44);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Multiline = false;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFullName.PasswordChar = false;
            this.txtFullName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFullName.PlaceholderText = "";
            this.txtFullName.Size = new System.Drawing.Size(498, 31);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.Texts = "";
            this.txtFullName.UnderlinedStyle = false;
            // 
            // txtHomePhoneNo
            // 
            this.txtHomePhoneNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHomePhoneNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtHomePhoneNo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtHomePhoneNo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtHomePhoneNo.BorderRadius = 0;
            this.txtHomePhoneNo.BorderSize = 2;
            this.txtHomePhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomePhoneNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHomePhoneNo.Location = new System.Drawing.Point(199, 84);
            this.txtHomePhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtHomePhoneNo.Multiline = false;
            this.txtHomePhoneNo.Name = "txtHomePhoneNo";
            this.txtHomePhoneNo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHomePhoneNo.PasswordChar = false;
            this.txtHomePhoneNo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHomePhoneNo.PlaceholderText = "";
            this.txtHomePhoneNo.Size = new System.Drawing.Size(498, 31);
            this.txtHomePhoneNo.TabIndex = 2;
            this.txtHomePhoneNo.Texts = "";
            this.txtHomePhoneNo.UnderlinedStyle = false;
            // 
            // txtWorkPhoneNo
            // 
            this.txtWorkPhoneNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkPhoneNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtWorkPhoneNo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtWorkPhoneNo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtWorkPhoneNo.BorderRadius = 0;
            this.txtWorkPhoneNo.BorderSize = 2;
            this.txtWorkPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkPhoneNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWorkPhoneNo.Location = new System.Drawing.Point(199, 124);
            this.txtWorkPhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkPhoneNo.Multiline = false;
            this.txtWorkPhoneNo.Name = "txtWorkPhoneNo";
            this.txtWorkPhoneNo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtWorkPhoneNo.PasswordChar = false;
            this.txtWorkPhoneNo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtWorkPhoneNo.PlaceholderText = "";
            this.txtWorkPhoneNo.Size = new System.Drawing.Size(498, 31);
            this.txtWorkPhoneNo.TabIndex = 3;
            this.txtWorkPhoneNo.Texts = "";
            this.txtWorkPhoneNo.UnderlinedStyle = false;
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHomeAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtHomeAddress.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtHomeAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtHomeAddress.BorderRadius = 0;
            this.txtHomeAddress.BorderSize = 2;
            this.txtHomeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomeAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHomeAddress.Location = new System.Drawing.Point(199, 166);
            this.txtHomeAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtHomeAddress.Multiline = true;
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHomeAddress.PasswordChar = false;
            this.txtHomeAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHomeAddress.PlaceholderText = "";
            this.txtHomeAddress.Size = new System.Drawing.Size(498, 54);
            this.txtHomeAddress.TabIndex = 4;
            this.txtHomeAddress.Texts = "";
            this.txtHomeAddress.UnderlinedStyle = false;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmailAddress.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEmailAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmailAddress.BorderRadius = 0;
            this.txtEmailAddress.BorderSize = 2;
            this.txtEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmailAddress.Location = new System.Drawing.Point(199, 228);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailAddress.Multiline = true;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmailAddress.PasswordChar = false;
            this.txtEmailAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmailAddress.PlaceholderText = "";
            this.txtEmailAddress.Size = new System.Drawing.Size(498, 42);
            this.txtEmailAddress.TabIndex = 5;
            this.txtEmailAddress.Texts = "";
            this.txtEmailAddress.UnderlinedStyle = false;
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDNumber.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtIDNumber.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIDNumber.BorderRadius = 0;
            this.txtIDNumber.BorderSize = 2;
            this.txtIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIDNumber.Location = new System.Drawing.Point(199, 312);
            this.txtIDNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDNumber.Multiline = false;
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIDNumber.PasswordChar = false;
            this.txtIDNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIDNumber.PlaceholderText = "";
            this.txtIDNumber.Size = new System.Drawing.Size(498, 31);
            this.txtIDNumber.TabIndex = 7;
            this.txtIDNumber.Texts = "";
            this.txtIDNumber.UnderlinedStyle = false;
            // 
            // cboMeansOfIdentification
            // 
            this.cboMeansOfIdentification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMeansOfIdentification.BackColor = System.Drawing.Color.White;
            this.cboMeansOfIdentification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMeansOfIdentification.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMeansOfIdentification.FormattingEnabled = true;
            this.cboMeansOfIdentification.Items.AddRange(new object[] {
            "Driver\'s License",
            "Int\'l Passport",
            "National ID",
            "Voters Passport"});
            this.cboMeansOfIdentification.Location = new System.Drawing.Point(198, 277);
            this.cboMeansOfIdentification.Name = "cboMeansOfIdentification";
            this.cboMeansOfIdentification.Size = new System.Drawing.Size(500, 28);
            this.cboMeansOfIdentification.Sorted = true;
            this.cboMeansOfIdentification.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAddTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(804, 725);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddTenant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddTenant";
            this.Load += new System.EventHandler(this.FormAddTenant_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label lblDisplayTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private RJCodeAdvance.RJControls.RJTextBox txtGeneralRemarks;
        private RJCodeAdvance.RJControls.RJTextBox txtGuarantorRelationShip;
        private RJCodeAdvance.RJControls.RJTextBox txtGuarantorAddress;
        private RJCodeAdvance.RJControls.RJTextBox txtGuarantorPhoneNo;
        private RJCodeAdvance.RJControls.RJTextBox txtGuarantorName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private RJCodeAdvance.RJControls.RJTextBox txtTenantID;
        private RJCodeAdvance.RJControls.RJTextBox txtFullName;
        private RJCodeAdvance.RJControls.RJTextBox txtHomePhoneNo;
        private RJCodeAdvance.RJControls.RJTextBox txtWorkPhoneNo;
        private RJCodeAdvance.RJControls.RJTextBox txtHomeAddress;
        private RJCodeAdvance.RJControls.RJTextBox txtEmailAddress;
        private RJCodeAdvance.RJControls.RJTextBox txtIDNumber;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.ComboBox cboMeansOfIdentification;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}