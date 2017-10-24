namespace WindowsFormsApplication1.Forms.Cashbook
{
    partial class AddReciept
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.RecieptDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.txtRecieptNarration = new System.Windows.Forms.RichTextBox();
            this.cmRecieptPayment = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmPartyName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtRecieptAmount = new MetroFramework.Controls.MetroTextBox();
            this.cmInvoiceNo = new MetroFramework.Controls.MetroComboBox();
            this.lblRemInvBal = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroTile();
            this.metroButton1 = new MetroFramework.Controls.MetroTile();
            this.metroButton2 = new MetroFramework.Controls.MetroTile();
            this.txtRefNo = new MetroFramework.Controls.MetroTextBox();
            this.lblRefNo = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.txtBankCode = new MetroFramework.Controls.MetroTextBox();
            this.txtChequeNo = new MetroFramework.Controls.MetroTextBox();
            this.lblCheqeNo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblRemPartyRecBal = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(9, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Date";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(9, 316);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(109, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Payment Method";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(9, 261);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "InvoiceNo";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(9, 140);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Description";
            // 
            // RecieptDatePicker
            // 
            this.RecieptDatePicker.Location = new System.Drawing.Point(144, 79);
            this.RecieptDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.RecieptDatePicker.Name = "RecieptDatePicker";
            this.RecieptDatePicker.Size = new System.Drawing.Size(200, 29);
            this.RecieptDatePicker.TabIndex = 4;
            this.RecieptDatePicker.ValueChanged += new System.EventHandler(this.RecieptDatePicker_ValueChanged);
            // 
            // txtRecieptNarration
            // 
            this.txtRecieptNarration.Location = new System.Drawing.Point(144, 131);
            this.txtRecieptNarration.Name = "txtRecieptNarration";
            this.txtRecieptNarration.Size = new System.Drawing.Size(200, 50);
            this.txtRecieptNarration.TabIndex = 5;
            this.txtRecieptNarration.Text = "";
            // 
            // cmRecieptPayment
            // 
            this.cmRecieptPayment.FormattingEnabled = true;
            this.cmRecieptPayment.ItemHeight = 23;
            this.cmRecieptPayment.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Online Bank Transfer"});
            this.cmRecieptPayment.Location = new System.Drawing.Point(144, 316);
            this.cmRecieptPayment.Name = "cmRecieptPayment";
            this.cmRecieptPayment.Size = new System.Drawing.Size(200, 29);
            this.cmRecieptPayment.TabIndex = 7;
            this.cmRecieptPayment.UseSelectable = true;
            this.cmRecieptPayment.SelectedIndexChanged += new System.EventHandler(this.cmRecieptPayment_SelectedIndexChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(9, 199);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(95, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Payment From";
            // 
            // cmPartyName
            // 
            this.cmPartyName.FormattingEnabled = true;
            this.cmPartyName.ItemHeight = 23;
            this.cmPartyName.Location = new System.Drawing.Point(144, 199);
            this.cmPartyName.Name = "cmPartyName";
            this.cmPartyName.PromptText = "Payee Name";
            this.cmPartyName.Size = new System.Drawing.Size(200, 29);
            this.cmPartyName.TabIndex = 9;
            this.cmPartyName.UseSelectable = true;
            this.cmPartyName.SelectedValueChanged += new System.EventHandler(this.cmPartyName_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(9, 498);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(56, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Amount";
            // 
            // txtRecieptAmount
            // 
            // 
            // 
            // 
            this.txtRecieptAmount.CustomButton.Image = null;
            this.txtRecieptAmount.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtRecieptAmount.CustomButton.Name = "";
            this.txtRecieptAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRecieptAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRecieptAmount.CustomButton.TabIndex = 1;
            this.txtRecieptAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRecieptAmount.CustomButton.UseSelectable = true;
            this.txtRecieptAmount.CustomButton.Visible = false;
            this.txtRecieptAmount.Lines = new string[0];
            this.txtRecieptAmount.Location = new System.Drawing.Point(144, 498);
            this.txtRecieptAmount.MaxLength = 32767;
            this.txtRecieptAmount.Name = "txtRecieptAmount";
            this.txtRecieptAmount.PasswordChar = '\0';
            this.txtRecieptAmount.PromptText = "Enter Amount";
            this.txtRecieptAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRecieptAmount.SelectedText = "";
            this.txtRecieptAmount.SelectionLength = 0;
            this.txtRecieptAmount.SelectionStart = 0;
            this.txtRecieptAmount.ShortcutsEnabled = true;
            this.txtRecieptAmount.Size = new System.Drawing.Size(200, 23);
            this.txtRecieptAmount.TabIndex = 11;
            this.txtRecieptAmount.UseSelectable = true;
            this.txtRecieptAmount.WaterMark = "Enter Amount";
            this.txtRecieptAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRecieptAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRecieptAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecieptAmount_KeyPress);
            // 
            // cmInvoiceNo
            // 
            this.cmInvoiceNo.FormattingEnabled = true;
            this.cmInvoiceNo.ItemHeight = 23;
            this.cmInvoiceNo.Location = new System.Drawing.Point(144, 257);
            this.cmInvoiceNo.Name = "cmInvoiceNo";
            this.cmInvoiceNo.PromptText = "Optional";
            this.cmInvoiceNo.Size = new System.Drawing.Size(200, 29);
            this.cmInvoiceNo.TabIndex = 15;
            this.cmInvoiceNo.UseSelectable = true;
            this.cmInvoiceNo.SelectedIndexChanged += new System.EventHandler(this.cmInvoiceNo_SelectedIndexChanged);
            // 
            // lblRemInvBal
            // 
            this.lblRemInvBal.AutoSize = true;
            this.lblRemInvBal.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblRemInvBal.Location = new System.Drawing.Point(144, 293);
            this.lblRemInvBal.Name = "lblRemInvBal";
            this.lblRemInvBal.Size = new System.Drawing.Size(83, 19);
            this.lblRemInvBal.TabIndex = 17;
            this.lblRemInvBal.Text = "metroLabel7";
            this.lblRemInvBal.Visible = false;
            // 
            // metroButton3
            // 
            this.metroButton3.ActiveControl = null;
            this.metroButton3.Location = new System.Drawing.Point(9, 545);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(109, 54);
            this.metroButton3.TabIndex = 18;
            this.metroButton3.Text = "New Reciept";
            this.metroButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.ActiveControl = null;
            this.metroButton1.Location = new System.Drawing.Point(144, 545);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(106, 54);
            this.metroButton1.TabIndex = 19;
            this.metroButton1.Text = "Save and \r\nPrint Reciept";
            this.metroButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.ActiveControl = null;
            this.metroButton2.Location = new System.Drawing.Point(272, 545);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(102, 54);
            this.metroButton2.TabIndex = 20;
            this.metroButton2.Text = "Close";
            this.metroButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
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
            this.txtRefNo.Location = new System.Drawing.Point(144, 457);
            this.txtRefNo.MaxLength = 32767;
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.PasswordChar = '\0';
            this.txtRefNo.PromptText = "Enter Ref No. (optional)";
            this.txtRefNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRefNo.SelectedText = "";
            this.txtRefNo.SelectionLength = 0;
            this.txtRefNo.SelectionStart = 0;
            this.txtRefNo.ShortcutsEnabled = true;
            this.txtRefNo.Size = new System.Drawing.Size(200, 23);
            this.txtRefNo.TabIndex = 22;
            this.txtRefNo.UseSelectable = true;
            this.txtRefNo.WaterMark = "Enter Ref No. (optional)";
            this.txtRefNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRefNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblRefNo
            // 
            this.lblRefNo.AutoSize = true;
            this.lblRefNo.Location = new System.Drawing.Point(12, 457);
            this.lblRefNo.Name = "lblRefNo";
            this.lblRefNo.Size = new System.Drawing.Size(53, 19);
            this.lblRefNo.TabIndex = 21;
            this.lblRefNo.Text = "Ref No.";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.txtBankCode);
            this.metroPanel2.Controls.Add(this.txtChequeNo);
            this.metroPanel2.Controls.Add(this.lblCheqeNo);
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(12, 351);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(332, 92);
            this.metroPanel2.TabIndex = 35;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
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
            this.txtBankCode.Location = new System.Drawing.Point(127, 52);
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
            this.txtChequeNo.Location = new System.Drawing.Point(127, 13);
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
            // 
            // lblCheqeNo
            // 
            this.lblCheqeNo.AutoSize = true;
            this.lblCheqeNo.Location = new System.Drawing.Point(10, 17);
            this.lblCheqeNo.Name = "lblCheqeNo";
            this.lblCheqeNo.Size = new System.Drawing.Size(83, 19);
            this.lblCheqeNo.TabIndex = 23;
            this.lblCheqeNo.Text = " Cheque No.";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(14, 52);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(73, 19);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "Bank Code";
            // 
            // lblRemPartyRecBal
            // 
            this.lblRemPartyRecBal.AutoSize = true;
            this.lblRemPartyRecBal.BackColor = System.Drawing.Color.Transparent;
            this.lblRemPartyRecBal.CausesValidation = false;
            this.lblRemPartyRecBal.ForeColor = System.Drawing.Color.Lime;
            this.lblRemPartyRecBal.Location = new System.Drawing.Point(144, 233);
            this.lblRemPartyRecBal.Name = "lblRemPartyRecBal";
            this.lblRemPartyRecBal.Size = new System.Drawing.Size(83, 19);
            this.lblRemPartyRecBal.TabIndex = 16;
            this.lblRemPartyRecBal.Text = "metroLabel7";
            this.lblRemPartyRecBal.Visible = false;
            // 
            // AddReciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 613);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.txtRefNo);
            this.Controls.Add(this.lblRefNo);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.lblRemInvBal);
            this.Controls.Add(this.lblRemPartyRecBal);
            this.Controls.Add(this.cmInvoiceNo);
            this.Controls.Add(this.txtRecieptAmount);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cmPartyName);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cmRecieptPayment);
            this.Controls.Add(this.txtRecieptNarration);
            this.Controls.Add(this.RecieptDatePicker);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddReciept";
            this.Text = "AddReciept";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddReciept_FormClosing);
            this.Load += new System.EventHandler(this.AddReciept_Load);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime RecieptDatePicker;
        private System.Windows.Forms.RichTextBox txtRecieptNarration;
        private MetroFramework.Controls.MetroComboBox cmRecieptPayment;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cmPartyName;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtRecieptAmount;
        private MetroFramework.Controls.MetroComboBox cmInvoiceNo;
        private MetroFramework.Controls.MetroLabel lblRemInvBal;
        private MetroFramework.Controls.MetroTile metroButton3;
        private MetroFramework.Controls.MetroTile metroButton1;
        private MetroFramework.Controls.MetroTile metroButton2;
        private MetroFramework.Controls.MetroTextBox txtRefNo;
        private MetroFramework.Controls.MetroLabel lblRefNo;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox txtBankCode;
        private MetroFramework.Controls.MetroTextBox txtChequeNo;
        private MetroFramework.Controls.MetroLabel lblCheqeNo;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lblRemPartyRecBal;
    }
}