
namespace Lems.Forms
{
    partial class FormAddProperty
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPropID = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtPropDescription = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtPropAddress = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtTotalQty = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtPropRemarks = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtPropType = new RJCodeAdvance.RJControls.RJTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTitleBar.SuspendLayout();
            this.panelContainer.SuspendLayout();
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
            this.panelTitleBar.Size = new System.Drawing.Size(780, 50);
            this.panelTitleBar.TabIndex = 0;
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
            this.btnExit.Location = new System.Drawing.Point(744, 10);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDisplayTitle
            // 
            this.lblDisplayTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDisplayTitle.AutoSize = true;
            this.lblDisplayTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTitle.ForeColor = System.Drawing.Color.White;
            this.lblDisplayTitle.Location = new System.Drawing.Point(331, 14);
            this.lblDisplayTitle.Name = "lblDisplayTitle";
            this.lblDisplayTitle.Size = new System.Drawing.Size(178, 23);
            this.lblDisplayTitle.TabIndex = 1;
            this.lblDisplayTitle.Text = "Add New Property";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.btnSave);
            this.panelContainer.Controls.Add(this.tableLayoutPanel1);
            this.panelContainer.Location = new System.Drawing.Point(10, 59);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(754, 513);
            this.panelContainer.TabIndex = 1;
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
            this.btnSave.Location = new System.Drawing.Point(179, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtPropID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPropDescription, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPropAddress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalQty, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPropRemarks, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtPropType, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(716, 446);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Property ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "Property Type:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 80);
            this.label4.TabIndex = 0;
            this.label4.Text = "Property Description:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 80);
            this.label5.TabIndex = 0;
            this.label5.Text = "Property Address:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 50);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Quantity:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 136);
            this.label7.TabIndex = 0;
            this.label7.Text = "Property Remarks:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPropID
            // 
            this.txtPropID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPropID.BackColor = System.Drawing.SystemColors.Window;
            this.txtPropID.BorderColor = System.Drawing.Color.Indigo;
            this.txtPropID.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPropID.BorderRadius = 0;
            this.txtPropID.BorderSize = 1;
            this.txtPropID.Enabled = false;
            this.txtPropID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPropID.Location = new System.Drawing.Point(159, 9);
            this.txtPropID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropID.Multiline = false;
            this.txtPropID.Name = "txtPropID";
            this.txtPropID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPropID.PasswordChar = false;
            this.txtPropID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPropID.PlaceholderText = "";
            this.txtPropID.Size = new System.Drawing.Size(533, 31);
            this.txtPropID.TabIndex = 0;
            this.txtPropID.Texts = "";
            this.txtPropID.UnderlinedStyle = false;
            // 
            // txtPropDescription
            // 
            this.txtPropDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPropDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtPropDescription.BorderColor = System.Drawing.Color.Indigo;
            this.txtPropDescription.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPropDescription.BorderRadius = 5;
            this.txtPropDescription.BorderSize = 1;
            this.txtPropDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPropDescription.Location = new System.Drawing.Point(159, 104);
            this.txtPropDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropDescription.Multiline = true;
            this.txtPropDescription.Name = "txtPropDescription";
            this.txtPropDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPropDescription.PasswordChar = false;
            this.txtPropDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPropDescription.PlaceholderText = "";
            this.txtPropDescription.Size = new System.Drawing.Size(533, 72);
            this.txtPropDescription.TabIndex = 2;
            this.txtPropDescription.Texts = "";
            this.txtPropDescription.UnderlinedStyle = false;
            // 
            // txtPropAddress
            // 
            this.txtPropAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPropAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtPropAddress.BorderColor = System.Drawing.Color.Indigo;
            this.txtPropAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPropAddress.BorderRadius = 5;
            this.txtPropAddress.BorderSize = 1;
            this.txtPropAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPropAddress.Location = new System.Drawing.Point(159, 184);
            this.txtPropAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropAddress.Multiline = true;
            this.txtPropAddress.Name = "txtPropAddress";
            this.txtPropAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPropAddress.PasswordChar = false;
            this.txtPropAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPropAddress.PlaceholderText = "";
            this.txtPropAddress.Size = new System.Drawing.Size(533, 72);
            this.txtPropAddress.TabIndex = 3;
            this.txtPropAddress.Texts = "";
            this.txtPropAddress.UnderlinedStyle = false;
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalQty.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalQty.BorderColor = System.Drawing.Color.Indigo;
            this.txtTotalQty.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTotalQty.BorderRadius = 0;
            this.txtTotalQty.BorderSize = 1;
            this.txtTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalQty.Location = new System.Drawing.Point(159, 269);
            this.txtTotalQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalQty.Multiline = false;
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTotalQty.PasswordChar = false;
            this.txtTotalQty.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotalQty.PlaceholderText = "";
            this.txtTotalQty.Size = new System.Drawing.Size(533, 31);
            this.txtTotalQty.TabIndex = 4;
            this.txtTotalQty.Texts = "";
            this.txtTotalQty.UnderlinedStyle = false;
            // 
            // txtPropRemarks
            // 
            this.txtPropRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPropRemarks.AutoSize = true;
            this.txtPropRemarks.BackColor = System.Drawing.SystemColors.Window;
            this.txtPropRemarks.BorderColor = System.Drawing.Color.Indigo;
            this.txtPropRemarks.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPropRemarks.BorderRadius = 0;
            this.txtPropRemarks.BorderSize = 1;
            this.txtPropRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPropRemarks.Location = new System.Drawing.Point(159, 314);
            this.txtPropRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropRemarks.Multiline = true;
            this.txtPropRemarks.Name = "txtPropRemarks";
            this.txtPropRemarks.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPropRemarks.PasswordChar = false;
            this.txtPropRemarks.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPropRemarks.PlaceholderText = "";
            this.txtPropRemarks.Size = new System.Drawing.Size(533, 128);
            this.txtPropRemarks.TabIndex = 5;
            this.txtPropRemarks.Texts = "";
            this.txtPropRemarks.UnderlinedStyle = false;
            // 
            // txtPropType
            // 
            this.txtPropType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPropType.BackColor = System.Drawing.SystemColors.Window;
            this.txtPropType.BorderColor = System.Drawing.Color.Indigo;
            this.txtPropType.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPropType.BorderRadius = 0;
            this.txtPropType.BorderSize = 1;
            this.txtPropType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPropType.Location = new System.Drawing.Point(159, 59);
            this.txtPropType.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropType.Multiline = false;
            this.txtPropType.Name = "txtPropType";
            this.txtPropType.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPropType.PasswordChar = false;
            this.txtPropType.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPropType.PlaceholderText = "";
            this.txtPropType.Size = new System.Drawing.Size(533, 31);
            this.txtPropType.TabIndex = 1;
            this.txtPropType.Texts = "";
            this.txtPropType.UnderlinedStyle = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAddProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(780, 586);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddProperty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Property";
            this.Load += new System.EventHandler(this.FormAddProperty_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblDisplayTitle;
        private System.Windows.Forms.Panel panelContainer;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private RJCodeAdvance.RJControls.RJTextBox txtPropID;
        private RJCodeAdvance.RJControls.RJTextBox txtPropType;
        private RJCodeAdvance.RJControls.RJTextBox txtPropDescription;
        private RJCodeAdvance.RJControls.RJTextBox txtPropAddress;
        private RJCodeAdvance.RJControls.RJTextBox txtTotalQty;
        private RJCodeAdvance.RJControls.RJTextBox txtPropRemarks;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}