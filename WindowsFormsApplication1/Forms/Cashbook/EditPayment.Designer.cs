namespace WindowsFormsApplication1.Forms.Cashbook
{
    partial class EditPayment
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
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtPaymentAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cmPaymentMethod = new MetroFramework.Controls.MetroComboBox();
            this.txtPaymentsNarration = new System.Windows.Forms.RichTextBox();
            this.PaymentsDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblInvoiceNo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmInvoiceNo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cmPaymentType = new MetroFramework.Controls.MetroComboBox();
            this.lblPaymento = new MetroFramework.Controls.MetroLabel();
            this.cmPaymentPartyName = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblRefNo = new MetroFramework.Controls.MetroLabel();
            this.txtRefNo = new MetroFramework.Controls.MetroTextBox();
            this.txtBankCode = new MetroFramework.Controls.MetroTextBox();
            this.txtChequeNo = new MetroFramework.Controls.MetroTextBox();
            this.lblCheqeNo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroButton2.Location = new System.Drawing.Point(292, 576);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 46);
            this.metroButton2.TabIndex = 28;
            this.metroButton2.Text = "Close";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroButton1.Location = new System.Drawing.Point(23, 576);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(90, 46);
            this.metroButton1.TabIndex = 27;
            this.metroButton1.Text = "Edit And\r\nPrint";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtPaymentAmount
            // 
            // 
            // 
            // 
            this.txtPaymentAmount.CustomButton.Image = null;
            this.txtPaymentAmount.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtPaymentAmount.CustomButton.Name = "";
            this.txtPaymentAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPaymentAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaymentAmount.CustomButton.TabIndex = 1;
            this.txtPaymentAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaymentAmount.CustomButton.UseSelectable = true;
            this.txtPaymentAmount.CustomButton.Visible = false;
            this.txtPaymentAmount.Lines = new string[0];
            this.txtPaymentAmount.Location = new System.Drawing.Point(162, 533);
            this.txtPaymentAmount.MaxLength = 32767;
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.PasswordChar = '\0';
            this.txtPaymentAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaymentAmount.SelectedText = "";
            this.txtPaymentAmount.SelectionLength = 0;
            this.txtPaymentAmount.SelectionStart = 0;
            this.txtPaymentAmount.ShortcutsEnabled = true;
            this.txtPaymentAmount.Size = new System.Drawing.Size(204, 23);
            this.txtPaymentAmount.TabIndex = 26;
            this.txtPaymentAmount.UseSelectable = true;
            this.txtPaymentAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaymentAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPaymentAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaymentAmount_KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(35, 537);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(56, 19);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Amount";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // cmPaymentMethod
            // 
            this.cmPaymentMethod.FormattingEnabled = true;
            this.cmPaymentMethod.ItemHeight = 23;
            this.cmPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Cheque"});
            this.cmPaymentMethod.Location = new System.Drawing.Point(167, 390);
            this.cmPaymentMethod.Name = "cmPaymentMethod";
            this.cmPaymentMethod.Size = new System.Drawing.Size(200, 29);
            this.cmPaymentMethod.TabIndex = 22;
            this.cmPaymentMethod.UseSelectable = true;
            this.cmPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmPaymentMethod_SelectedIndexChanged);
            // 
            // txtPaymentsNarration
            // 
            this.txtPaymentsNarration.Location = new System.Drawing.Point(167, 122);
            this.txtPaymentsNarration.Name = "txtPaymentsNarration";
            this.txtPaymentsNarration.Size = new System.Drawing.Size(200, 50);
            this.txtPaymentsNarration.TabIndex = 20;
            this.txtPaymentsNarration.Text = "";
            // 
            // PaymentsDatePicker
            // 
            this.PaymentsDatePicker.Location = new System.Drawing.Point(167, 70);
            this.PaymentsDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.PaymentsDatePicker.Name = "PaymentsDatePicker";
            this.PaymentsDatePicker.Size = new System.Drawing.Size(200, 29);
            this.PaymentsDatePicker.TabIndex = 19;
            this.PaymentsDatePicker.ValueChanged += new System.EventHandler(this.PaymentsDatePicker_ValueChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(32, 131);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Narrations";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(3, 63);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(74, 19);
            this.lblInvoiceNo.TabIndex = 17;
            this.lblInvoiceNo.Text = "Invoice No.";
            this.lblInvoiceNo.Visible = false;
            this.lblInvoiceNo.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 390);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(109, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Payment Method";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Date";
            // 
            // cmInvoiceNo
            // 
            this.cmInvoiceNo.FormattingEnabled = true;
            this.cmInvoiceNo.ItemHeight = 23;
            this.cmInvoiceNo.Location = new System.Drawing.Point(131, 53);
            this.cmInvoiceNo.Name = "cmInvoiceNo";
            this.cmInvoiceNo.PromptText = "Optional";
            this.cmInvoiceNo.Size = new System.Drawing.Size(196, 29);
            this.cmInvoiceNo.TabIndex = 30;
            this.cmInvoiceNo.UseSelectable = true;
            this.cmInvoiceNo.Visible = false;
            this.cmInvoiceNo.SelectedIndexChanged += new System.EventHandler(this.cmInvoiceNo_SelectedIndexChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(32, 198);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(90, 19);
            this.metroLabel7.TabIndex = 31;
            this.metroLabel7.Text = "Payment Type";
            // 
            // cmPaymentType
            // 
            this.cmPaymentType.FormattingEnabled = true;
            this.cmPaymentType.ItemHeight = 23;
            this.cmPaymentType.Items.AddRange(new object[] {
            "Purchase",
            "Expenses"});
            this.cmPaymentType.Location = new System.Drawing.Point(167, 198);
            this.cmPaymentType.Name = "cmPaymentType";
            this.cmPaymentType.Size = new System.Drawing.Size(200, 29);
            this.cmPaymentType.TabIndex = 32;
            this.cmPaymentType.UseSelectable = true;
            this.cmPaymentType.SelectedIndexChanged += new System.EventHandler(this.cmPaymentType_SelectedIndexChanged);
            // 
            // lblPaymento
            // 
            this.lblPaymento.AutoSize = true;
            this.lblPaymento.Location = new System.Drawing.Point(3, 28);
            this.lblPaymento.Name = "lblPaymento";
            this.lblPaymento.Size = new System.Drawing.Size(76, 19);
            this.lblPaymento.TabIndex = 23;
            this.lblPaymento.Text = "Payment To";
            this.lblPaymento.Visible = false;
            // 
            // cmPaymentPartyName
            // 
            this.cmPaymentPartyName.FormattingEnabled = true;
            this.cmPaymentPartyName.ItemHeight = 23;
            this.cmPaymentPartyName.Location = new System.Drawing.Point(131, 18);
            this.cmPaymentPartyName.Name = "cmPaymentPartyName";
            this.cmPaymentPartyName.Size = new System.Drawing.Size(196, 29);
            this.cmPaymentPartyName.TabIndex = 24;
            this.cmPaymentPartyName.UseSelectable = true;
            this.cmPaymentPartyName.Visible = false;
            this.cmPaymentPartyName.SelectedIndexChanged += new System.EventHandler(this.cmPaymentPartyName_SelectedIndexChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.lblPaymento);
            this.metroPanel1.Controls.Add(this.cmInvoiceNo);
            this.metroPanel1.Controls.Add(this.cmPaymentPartyName);
            this.metroPanel1.Controls.Add(this.lblInvoiceNo);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(35, 240);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(332, 94);
            this.metroPanel1.TabIndex = 33;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblRefNo
            // 
            this.lblRefNo.AutoSize = true;
            this.lblRefNo.Location = new System.Drawing.Point(35, 350);
            this.lblRefNo.Name = "lblRefNo";
            this.lblRefNo.Size = new System.Drawing.Size(53, 19);
            this.lblRefNo.TabIndex = 31;
            this.lblRefNo.Text = "Ref No.";
            // 
            // txtRefNo
            // 
            // 
            // 
            // 
            this.txtRefNo.CustomButton.Image = null;
            this.txtRefNo.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtRefNo.CustomButton.Name = "";
            this.txtRefNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRefNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRefNo.CustomButton.TabIndex = 1;
            this.txtRefNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRefNo.CustomButton.UseSelectable = true;
            this.txtRefNo.CustomButton.Visible = false;
            this.txtRefNo.Lines = new string[0];
            this.txtRefNo.Location = new System.Drawing.Point(167, 346);
            this.txtRefNo.MaxLength = 32767;
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.PasswordChar = '\0';
            this.txtRefNo.PromptText = "Enter Ref No.";
            this.txtRefNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRefNo.SelectedText = "";
            this.txtRefNo.SelectionLength = 0;
            this.txtRefNo.SelectionStart = 0;
            this.txtRefNo.ShortcutsEnabled = true;
            this.txtRefNo.Size = new System.Drawing.Size(200, 23);
            this.txtRefNo.TabIndex = 34;
            this.txtRefNo.UseSelectable = true;
            this.txtRefNo.WaterMark = "Enter Ref No.";
            this.txtRefNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRefNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBankCode
            // 
            // 
            // 
            // 
            this.txtBankCode.CustomButton.Image = null;
            this.txtBankCode.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtBankCode.CustomButton.Name = "";
            this.txtBankCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBankCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBankCode.CustomButton.TabIndex = 1;
            this.txtBankCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBankCode.CustomButton.UseSelectable = true;
            this.txtBankCode.CustomButton.Visible = false;
            this.txtBankCode.Lines = new string[0];
            this.txtBankCode.Location = new System.Drawing.Point(163, 492);
            this.txtBankCode.MaxLength = 32767;
            this.txtBankCode.Name = "txtBankCode";
            this.txtBankCode.PasswordChar = '\0';
            this.txtBankCode.PromptText = "Enter Bank Code (optional)";
            this.txtBankCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBankCode.SelectedText = "";
            this.txtBankCode.SelectionLength = 0;
            this.txtBankCode.SelectionStart = 0;
            this.txtBankCode.ShortcutsEnabled = true;
            this.txtBankCode.Size = new System.Drawing.Size(200, 23);
            this.txtBankCode.TabIndex = 35;
            this.txtBankCode.UseSelectable = true;
            this.txtBankCode.WaterMark = "Enter Bank Code (optional)";
            this.txtBankCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBankCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBankCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBankCode_KeyPress);
            // 
            // txtChequeNo
            // 
            // 
            // 
            // 
            this.txtChequeNo.CustomButton.Image = null;
            this.txtChequeNo.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtChequeNo.CustomButton.Name = "";
            this.txtChequeNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtChequeNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChequeNo.CustomButton.TabIndex = 1;
            this.txtChequeNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChequeNo.CustomButton.UseSelectable = true;
            this.txtChequeNo.CustomButton.Visible = false;
            this.txtChequeNo.Lines = new string[0];
            this.txtChequeNo.Location = new System.Drawing.Point(162, 440);
            this.txtChequeNo.MaxLength = 32767;
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.PasswordChar = '\0';
            this.txtChequeNo.PromptText = "Enter Cheque No. (optional)";
            this.txtChequeNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChequeNo.SelectedText = "";
            this.txtChequeNo.SelectionLength = 0;
            this.txtChequeNo.SelectionStart = 0;
            this.txtChequeNo.ShortcutsEnabled = true;
            this.txtChequeNo.Size = new System.Drawing.Size(200, 23);
            this.txtChequeNo.TabIndex = 24;
            this.txtChequeNo.UseSelectable = true;
            this.txtChequeNo.WaterMark = "Enter Cheque No. (optional)";
            this.txtChequeNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChequeNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtChequeNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChequeNo_KeyPress);
            // 
            // lblCheqeNo
            // 
            this.lblCheqeNo.AutoSize = true;
            this.lblCheqeNo.Location = new System.Drawing.Point(35, 444);
            this.lblCheqeNo.Name = "lblCheqeNo";
            this.lblCheqeNo.Size = new System.Drawing.Size(79, 19);
            this.lblCheqeNo.TabIndex = 23;
            this.lblCheqeNo.Text = "Cheque No.";
            this.lblCheqeNo.Click += new System.EventHandler(this.lblCheqeNo_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(35, 492);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(73, 19);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "Bank Code";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroButton4.Location = new System.Drawing.Point(152, 576);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(90, 46);
            this.metroButton4.TabIndex = 35;
            this.metroButton4.Text = "Edit And\r\nClose";
            this.metroButton4.UseCustomBackColor = true;
            this.metroButton4.UseCustomForeColor = true;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.UseStyleColors = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // EditPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 645);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.txtBankCode);
            this.Controls.Add(this.txtRefNo);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtChequeNo);
            this.Controls.Add(this.lblRefNo);
            this.Controls.Add(this.lblCheqeNo);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.cmPaymentType);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cmPaymentMethod);
            this.Controls.Add(this.txtPaymentsNarration);
            this.Controls.Add(this.PaymentsDatePicker);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "EditPayment";
            this.Text = "Edit Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPayment_FormClosing);
            this.Load += new System.EventHandler(this.AddPayment_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblRefNo;
        private MetroFramework.Controls.MetroLabel lblCheqeNo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton metroButton4;
        public MetroFramework.Controls.MetroTextBox txtPaymentAmount;
        public MetroFramework.Controls.MetroComboBox cmPaymentMethod;
        public System.Windows.Forms.RichTextBox txtPaymentsNarration;
        public MetroFramework.Controls.MetroDateTime PaymentsDatePicker;
        public MetroFramework.Controls.MetroComboBox cmInvoiceNo;
        public MetroFramework.Controls.MetroComboBox cmPaymentType;
        public MetroFramework.Controls.MetroComboBox cmPaymentPartyName;
        public MetroFramework.Controls.MetroTextBox txtRefNo;
        public MetroFramework.Controls.MetroTextBox txtBankCode;
        public MetroFramework.Controls.MetroTextBox txtChequeNo;
        public MetroFramework.Controls.MetroLabel lblInvoiceNo;
        public MetroFramework.Controls.MetroLabel lblPaymento;
    }
}