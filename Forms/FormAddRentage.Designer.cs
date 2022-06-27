
namespace Lems.Forms
{
    partial class FormAddRentage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDuration = new RJCodeAdvance.RJControls.RJTextBox();
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
            this.txtRentID = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtActualAmount = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtAmountPaid = new RJCodeAdvance.RJControls.RJTextBox();
            this.cboACDescription = new System.Windows.Forms.ComboBox();
            this.cboTenantName = new System.Windows.Forms.ComboBox();
            this.txtBalanceAmount = new RJCodeAdvance.RJControls.RJTextBox();
            this.dtpDataOfFirstPayment = new System.Windows.Forms.DateTimePicker();
            this.dtpNextPaymentDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpGracePeriodDate = new System.Windows.Forms.DateTimePicker();
            this.cboTenancyStatus = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtComments = new RJCodeAdvance.RJControls.RJTextBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblDisplayTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(21, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 640);
            this.panel1.TabIndex = 4;
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
            this.btnSave.Location = new System.Drawing.Point(201, 594);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 41);
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
            this.tableLayoutPanel1.Controls.Add(this.txtDuration, 1, 10);
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
            this.tableLayoutPanel1.Controls.Add(this.txtRentID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtActualAmount, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtAmountPaid, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cboACDescription, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboTenantName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBalanceAmount, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtpDataOfFirstPayment, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.dtpNextPaymentDueDate, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.dtpGracePeriodDate, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.cboTenancyStatus, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtRemarks, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.txtComments, 1, 12);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(721, 579);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtDuration
            // 
            this.txtDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDuration.BackColor = System.Drawing.SystemColors.Window;
            this.txtDuration.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDuration.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDuration.BorderRadius = 0;
            this.txtDuration.BorderSize = 2;
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDuration.Location = new System.Drawing.Point(199, 367);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuration.Multiline = false;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDuration.PasswordChar = false;
            this.txtDuration.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDuration.PlaceholderText = "";
            this.txtDuration.Size = new System.Drawing.Size(103, 31);
            this.txtDuration.TabIndex = 10;
            this.txtDuration.Texts = "";
            this.txtDuration.UnderlinedStyle = false;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 486);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 93);
            this.label13.TabIndex = 0;
            this.label13.Text = "Comments :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 404);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 82);
            this.label12.TabIndex = 0;
            this.label12.Text = "Remarks. :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 41);
            this.label11.TabIndex = 0;
            this.label11.Text = "Duration (Months) :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 34);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tenancy Status :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 35);
            this.label9.TabIndex = 0;
            this.label9.Text = "Date Of Grace Period :";
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
            this.label1.Text = "Rentage ID :";
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
            this.label2.Size = new System.Drawing.Size(189, 34);
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
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tenant Name :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Actual Amount Per Year:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Amount Paid:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Balance Amount :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 34);
            this.label7.TabIndex = 0;
            this.label7.Text = "Date Of Payment :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 34);
            this.label8.TabIndex = 0;
            this.label8.Text = "Next Payment Due Date :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRentID
            // 
            this.txtRentID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRentID.BackColor = System.Drawing.SystemColors.Window;
            this.txtRentID.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtRentID.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtRentID.BorderRadius = 0;
            this.txtRentID.BorderSize = 2;
            this.txtRentID.Enabled = false;
            this.txtRentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRentID.Location = new System.Drawing.Point(199, 4);
            this.txtRentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtRentID.Multiline = false;
            this.txtRentID.Name = "txtRentID";
            this.txtRentID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRentID.PasswordChar = false;
            this.txtRentID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRentID.PlaceholderText = "";
            this.txtRentID.Size = new System.Drawing.Size(498, 31);
            this.txtRentID.TabIndex = 0;
            this.txtRentID.Texts = "";
            this.txtRentID.UnderlinedStyle = false;
            // 
            // txtActualAmount
            // 
            this.txtActualAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtActualAmount.BackColor = System.Drawing.SystemColors.Window;
            this.txtActualAmount.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtActualAmount.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtActualAmount.BorderRadius = 0;
            this.txtActualAmount.BorderSize = 2;
            this.txtActualAmount.Enabled = false;
            this.txtActualAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActualAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtActualAmount.Location = new System.Drawing.Point(199, 115);
            this.txtActualAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtActualAmount.Multiline = false;
            this.txtActualAmount.Name = "txtActualAmount";
            this.txtActualAmount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtActualAmount.PasswordChar = false;
            this.txtActualAmount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtActualAmount.PlaceholderText = "";
            this.txtActualAmount.Size = new System.Drawing.Size(175, 31);
            this.txtActualAmount.TabIndex = 3;
            this.txtActualAmount.Texts = "";
            this.txtActualAmount.UnderlinedStyle = false;
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAmountPaid.BackColor = System.Drawing.SystemColors.Window;
            this.txtAmountPaid.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAmountPaid.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAmountPaid.BorderRadius = 0;
            this.txtAmountPaid.BorderSize = 2;
            this.txtAmountPaid.Enabled = false;
            this.txtAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAmountPaid.Location = new System.Drawing.Point(199, 155);
            this.txtAmountPaid.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmountPaid.Multiline = true;
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAmountPaid.PasswordChar = false;
            this.txtAmountPaid.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAmountPaid.PlaceholderText = "";
            this.txtAmountPaid.Size = new System.Drawing.Size(175, 30);
            this.txtAmountPaid.TabIndex = 4;
            this.txtAmountPaid.Texts = "";
            this.txtAmountPaid.UnderlinedStyle = false;
            this.txtAmountPaid._TextChanged += new System.EventHandler(this.txtAmountPaid__TextChanged);
            this.txtAmountPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountPaid_KeyPress);
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
            this.cboACDescription.TabIndex = 13;
            this.cboACDescription.SelectedIndexChanged += new System.EventHandler(this.cboACDescription_SelectedIndexChanged);
            // 
            // cboTenantName
            // 
            this.cboTenantName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTenantName.BackColor = System.Drawing.Color.White;
            this.cboTenantName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenantName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenantName.FormattingEnabled = true;
            this.cboTenantName.Items.AddRange(new object[] {
            "Driver\'s License",
            "Int\'l Passport",
            "National ID",
            "Voters Passport"});
            this.cboTenantName.Location = new System.Drawing.Point(198, 77);
            this.cboTenantName.Name = "cboTenantName";
            this.cboTenantName.Size = new System.Drawing.Size(500, 28);
            this.cboTenantName.Sorted = true;
            this.cboTenantName.TabIndex = 13;
            this.cboTenantName.SelectedIndexChanged += new System.EventHandler(this.cboTenantName_SelectedIndexChanged);
            // 
            // txtBalanceAmount
            // 
            this.txtBalanceAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBalanceAmount.BackColor = System.Drawing.SystemColors.Window;
            this.txtBalanceAmount.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBalanceAmount.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBalanceAmount.BorderRadius = 0;
            this.txtBalanceAmount.BorderSize = 2;
            this.txtBalanceAmount.Enabled = false;
            this.txtBalanceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBalanceAmount.Location = new System.Drawing.Point(199, 193);
            this.txtBalanceAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtBalanceAmount.Multiline = true;
            this.txtBalanceAmount.Name = "txtBalanceAmount";
            this.txtBalanceAmount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBalanceAmount.PasswordChar = false;
            this.txtBalanceAmount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBalanceAmount.PlaceholderText = "";
            this.txtBalanceAmount.Size = new System.Drawing.Size(175, 29);
            this.txtBalanceAmount.TabIndex = 14;
            this.txtBalanceAmount.Texts = "";
            this.txtBalanceAmount.UnderlinedStyle = false;
            // 
            // dtpDataOfFirstPayment
            // 
            this.dtpDataOfFirstPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataOfFirstPayment.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataOfFirstPayment.CustomFormat = "dd-MMM-yyyy";
            this.dtpDataOfFirstPayment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataOfFirstPayment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataOfFirstPayment.Location = new System.Drawing.Point(198, 229);
            this.dtpDataOfFirstPayment.Name = "dtpDataOfFirstPayment";
            this.dtpDataOfFirstPayment.Size = new System.Drawing.Size(500, 27);
            this.dtpDataOfFirstPayment.TabIndex = 15;
            this.dtpDataOfFirstPayment.ValueChanged += new System.EventHandler(this.dtpDataOfFirstPayment_ValueChanged);
            // 
            // dtpNextPaymentDueDate
            // 
            this.dtpNextPaymentDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNextPaymentDueDate.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNextPaymentDueDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpNextPaymentDueDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNextPaymentDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNextPaymentDueDate.Location = new System.Drawing.Point(198, 263);
            this.dtpNextPaymentDueDate.Name = "dtpNextPaymentDueDate";
            this.dtpNextPaymentDueDate.Size = new System.Drawing.Size(500, 27);
            this.dtpNextPaymentDueDate.TabIndex = 16;
            this.dtpNextPaymentDueDate.ValueChanged += new System.EventHandler(this.dtpNextPaymentDueDate_ValueChanged);
            // 
            // dtpGracePeriodDate
            // 
            this.dtpGracePeriodDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpGracePeriodDate.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGracePeriodDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpGracePeriodDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGracePeriodDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGracePeriodDate.Location = new System.Drawing.Point(198, 297);
            this.dtpGracePeriodDate.Name = "dtpGracePeriodDate";
            this.dtpGracePeriodDate.Size = new System.Drawing.Size(500, 27);
            this.dtpGracePeriodDate.TabIndex = 16;
            // 
            // cboTenancyStatus
            // 
            this.cboTenancyStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTenancyStatus.BackColor = System.Drawing.Color.White;
            this.cboTenancyStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenancyStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenancyStatus.FormattingEnabled = true;
            this.cboTenancyStatus.Items.AddRange(new object[] {
            "CLEARED",
            "NOT-CLEARED"});
            this.cboTenancyStatus.Location = new System.Drawing.Point(198, 332);
            this.cboTenancyStatus.Name = "cboTenancyStatus";
            this.cboTenancyStatus.Size = new System.Drawing.Size(500, 28);
            this.cboTenancyStatus.Sorted = true;
            this.cboTenancyStatus.TabIndex = 13;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.BackColor = System.Drawing.SystemColors.Window;
            this.txtRemarks.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtRemarks.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtRemarks.BorderRadius = 0;
            this.txtRemarks.BorderSize = 2;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRemarks.Location = new System.Drawing.Point(199, 408);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRemarks.PasswordChar = false;
            this.txtRemarks.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRemarks.PlaceholderText = "";
            this.txtRemarks.Size = new System.Drawing.Size(498, 74);
            this.txtRemarks.TabIndex = 12;
            this.txtRemarks.Texts = "";
            this.txtRemarks.UnderlinedStyle = false;
            // 
            // txtComments
            // 
            this.txtComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComments.BackColor = System.Drawing.SystemColors.Window;
            this.txtComments.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtComments.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtComments.BorderRadius = 0;
            this.txtComments.BorderSize = 2;
            this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtComments.Location = new System.Drawing.Point(199, 490);
            this.txtComments.Margin = new System.Windows.Forms.Padding(4);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtComments.PasswordChar = false;
            this.txtComments.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtComments.PlaceholderText = "";
            this.txtComments.Size = new System.Drawing.Size(498, 85);
            this.txtComments.TabIndex = 12;
            this.txtComments.Texts = "";
            this.txtComments.UnderlinedStyle = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Indigo;
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.lblDisplayTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(799, 50);
            this.panelTitleBar.TabIndex = 3;
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
            this.btnExit.Location = new System.Drawing.Point(763, 10);
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
            this.lblDisplayTitle.Location = new System.Drawing.Point(340, 14);
            this.lblDisplayTitle.Name = "lblDisplayTitle";
            this.lblDisplayTitle.Size = new System.Drawing.Size(145, 23);
            this.lblDisplayTitle.TabIndex = 1;
            this.lblDisplayTitle.Text = "Take New Rent";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAddRentage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddRentage";
            this.Text = "FormAddRentage";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJTextBox txtRemarks;
        private RJCodeAdvance.RJControls.RJTextBox txtDuration;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private RJCodeAdvance.RJControls.RJTextBox txtRentID;
        private RJCodeAdvance.RJControls.RJTextBox txtActualAmount;
        private RJCodeAdvance.RJControls.RJTextBox txtAmountPaid;
        private System.Windows.Forms.ComboBox cboTenancyStatus;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label lblDisplayTitle;
        private System.Windows.Forms.ComboBox cboACDescription;
        private System.Windows.Forms.ComboBox cboTenantName;
        private RJCodeAdvance.RJControls.RJTextBox txtBalanceAmount;
        private System.Windows.Forms.DateTimePicker dtpDataOfFirstPayment;
        private System.Windows.Forms.DateTimePicker dtpNextPaymentDueDate;
        private System.Windows.Forms.DateTimePicker dtpGracePeriodDate;
        private RJCodeAdvance.RJControls.RJTextBox txtComments;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}