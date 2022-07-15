
namespace Lems.Forms
{
    partial class FormAddAccomodation
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMontlyPayment = new RJCodeAdvance.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtACID = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtPropID = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtACNumber = new RJCodeAdvance.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboACDescription = new System.Windows.Forms.ComboBox();
            this.cboACStatus = new System.Windows.Forms.ComboBox();
            this.txtGeneralRemarks = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtYearlyPayment = new RJCodeAdvance.RJControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.panelTitleBar.Size = new System.Drawing.Size(788, 50);
            this.panelTitleBar.TabIndex = 2;
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
            this.btnExit.Location = new System.Drawing.Point(752, 10);
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
            this.lblDisplayTitle.Location = new System.Drawing.Point(335, 14);
            this.lblDisplayTitle.Name = "lblDisplayTitle";
            this.lblDisplayTitle.Size = new System.Drawing.Size(195, 23);
            this.lblDisplayTitle.TabIndex = 1;
            this.lblDisplayTitle.Text = "Add Accomodation";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(16, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 422);
            this.panel1.TabIndex = 3;
            // 
            // btnSave
            // 
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
            this.btnSave.Location = new System.Drawing.Point(209, 379);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 36);
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
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtMontlyPayment, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtACID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPropID, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtACNumber, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboACDescription, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboACStatus, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtGeneralRemarks, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtYearlyPayment, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(721, 349);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.label2.Size = new System.Drawing.Size(189, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Accomodation Type :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 44);
            this.label3.TabIndex = 0;
            this.label3.Text = "Property ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 39);
            this.label6.TabIndex = 0;
            this.label6.Text = "Amount Per Year :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMontlyPayment
            // 
            this.txtMontlyPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMontlyPayment.BackColor = System.Drawing.SystemColors.Window;
            this.txtMontlyPayment.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMontlyPayment.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMontlyPayment.BorderRadius = 0;
            this.txtMontlyPayment.BorderSize = 2;
            this.txtMontlyPayment.Enabled = false;
            this.txtMontlyPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontlyPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMontlyPayment.Location = new System.Drawing.Point(199, 205);
            this.txtMontlyPayment.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontlyPayment.Multiline = true;
            this.txtMontlyPayment.Name = "txtMontlyPayment";
            this.txtMontlyPayment.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMontlyPayment.PasswordChar = false;
            this.txtMontlyPayment.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMontlyPayment.PlaceholderText = "";
            this.txtMontlyPayment.Size = new System.Drawing.Size(125, 32);
            this.txtMontlyPayment.TabIndex = 5;
            this.txtMontlyPayment.Texts = "";
            this.txtMontlyPayment.UnderlinedStyle = false;
            this.txtMontlyPayment._TextChanged += new System.EventHandler(this.txtMontlyPayment__TextChanged);
            this.txtMontlyPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontlyPayment_KeyPress);
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
            this.label4.Text = "Give (Flat / Room) No. :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "Accomodation Status :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 72);
            this.label8.TabIndex = 0;
            this.label8.Text = "Remarks :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtACID
            // 
            this.txtACID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtACID.BackColor = System.Drawing.SystemColors.Window;
            this.txtACID.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtACID.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtACID.BorderRadius = 0;
            this.txtACID.BorderSize = 2;
            this.txtACID.Enabled = false;
            this.txtACID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtACID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtACID.Location = new System.Drawing.Point(199, 4);
            this.txtACID.Margin = new System.Windows.Forms.Padding(4);
            this.txtACID.Multiline = false;
            this.txtACID.Name = "txtACID";
            this.txtACID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtACID.PasswordChar = false;
            this.txtACID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtACID.PlaceholderText = "";
            this.txtACID.Size = new System.Drawing.Size(498, 31);
            this.txtACID.TabIndex = 0;
            this.txtACID.Texts = "";
            this.txtACID.UnderlinedStyle = false;
            // 
            // txtPropID
            // 
            this.txtPropID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPropID.BackColor = System.Drawing.SystemColors.Window;
            this.txtPropID.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPropID.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPropID.BorderRadius = 0;
            this.txtPropID.BorderSize = 2;
            this.txtPropID.Enabled = false;
            this.txtPropID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPropID.Location = new System.Drawing.Point(199, 80);
            this.txtPropID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropID.Multiline = false;
            this.txtPropID.Name = "txtPropID";
            this.txtPropID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPropID.PasswordChar = false;
            this.txtPropID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPropID.PlaceholderText = "";
            this.txtPropID.Size = new System.Drawing.Size(498, 31);
            this.txtPropID.TabIndex = 2;
            this.txtPropID.Texts = "";
            this.txtPropID.UnderlinedStyle = false;
            // 
            // txtACNumber
            // 
            this.txtACNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtACNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtACNumber.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtACNumber.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtACNumber.BorderRadius = 0;
            this.txtACNumber.BorderSize = 2;
            this.txtACNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtACNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtACNumber.Location = new System.Drawing.Point(199, 124);
            this.txtACNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtACNumber.Multiline = false;
            this.txtACNumber.Name = "txtACNumber";
            this.txtACNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtACNumber.PasswordChar = false;
            this.txtACNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtACNumber.PlaceholderText = "";
            this.txtACNumber.Size = new System.Drawing.Size(498, 31);
            this.txtACNumber.TabIndex = 3;
            this.txtACNumber.Texts = "";
            this.txtACNumber.UnderlinedStyle = false;
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
            this.label1.Text = "Accomationa ID :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboACDescription
            // 
            this.cboACDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboACDescription.BackColor = System.Drawing.Color.White;
            this.cboACDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboACDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboACDescription.FormattingEnabled = true;
            this.cboACDescription.Items.AddRange(new object[] {
            "Driver\'s License",
            "Int\'l Passport",
            "National ID",
            "Voters Passport"});
            this.cboACDescription.Location = new System.Drawing.Point(198, 43);
            this.cboACDescription.Name = "cboACDescription";
            this.cboACDescription.Size = new System.Drawing.Size(500, 28);
            this.cboACDescription.Sorted = true;
            this.cboACDescription.TabIndex = 1;
            this.cboACDescription.SelectedIndexChanged += new System.EventHandler(this.cboACDescription_SelectedIndexChanged);
            // 
            // cboACStatus
            // 
            this.cboACStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboACStatus.BackColor = System.Drawing.Color.White;
            this.cboACStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboACStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboACStatus.FormattingEnabled = true;
            this.cboACStatus.Items.AddRange(new object[] {
            "Occupied",
            "Under Maintenance",
            "Vaccant"});
            this.cboACStatus.Location = new System.Drawing.Point(198, 244);
            this.cboACStatus.Name = "cboACStatus";
            this.cboACStatus.Size = new System.Drawing.Size(500, 28);
            this.cboACStatus.Sorted = true;
            this.cboACStatus.TabIndex = 6;
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
            this.txtGeneralRemarks.Location = new System.Drawing.Point(199, 281);
            this.txtGeneralRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtGeneralRemarks.Multiline = true;
            this.txtGeneralRemarks.Name = "txtGeneralRemarks";
            this.txtGeneralRemarks.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGeneralRemarks.PasswordChar = false;
            this.txtGeneralRemarks.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGeneralRemarks.PlaceholderText = "";
            this.txtGeneralRemarks.Size = new System.Drawing.Size(498, 64);
            this.txtGeneralRemarks.TabIndex = 7;
            this.txtGeneralRemarks.Texts = "";
            this.txtGeneralRemarks.UnderlinedStyle = false;
            // 
            // txtYearlyPayment
            // 
            this.txtYearlyPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtYearlyPayment.BackColor = System.Drawing.SystemColors.Window;
            this.txtYearlyPayment.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtYearlyPayment.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtYearlyPayment.BorderRadius = 0;
            this.txtYearlyPayment.BorderSize = 2;
            this.txtYearlyPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearlyPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtYearlyPayment.Location = new System.Drawing.Point(199, 166);
            this.txtYearlyPayment.Margin = new System.Windows.Forms.Padding(4);
            this.txtYearlyPayment.Multiline = true;
            this.txtYearlyPayment.Name = "txtYearlyPayment";
            this.txtYearlyPayment.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtYearlyPayment.PasswordChar = false;
            this.txtYearlyPayment.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtYearlyPayment.PlaceholderText = "";
            this.txtYearlyPayment.Size = new System.Drawing.Size(125, 31);
            this.txtYearlyPayment.TabIndex = 4;
            this.txtYearlyPayment.Texts = "";
            this.txtYearlyPayment.UnderlinedStyle = false;
            this.txtYearlyPayment._TextChanged += new System.EventHandler(this.txtYearlyPayment__TextChanged);
            this.txtYearlyPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearlyPayment_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "Amount Per Month :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAddAccomodation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(788, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddAccomodation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddAccomodation";
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
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJTextBox txtGeneralRemarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private RJCodeAdvance.RJControls.RJTextBox txtACID;
        private RJCodeAdvance.RJControls.RJTextBox txtPropID;
        private RJCodeAdvance.RJControls.RJTextBox txtACNumber;
        private RJCodeAdvance.RJControls.RJTextBox txtMontlyPayment;
        private RJCodeAdvance.RJControls.RJTextBox txtYearlyPayment;
        private System.Windows.Forms.ComboBox cboACDescription;
        private System.Windows.Forms.ComboBox cboACStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}