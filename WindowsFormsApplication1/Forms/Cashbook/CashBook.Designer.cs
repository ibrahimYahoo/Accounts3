
namespace WindowsFormsApplication1.Forms
{
    partial class CashBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvCashBook = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtRefNo = new MetroFramework.Controls.MetroTextBox();
            this.txtInvoiceNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtBankCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtChequeNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtAmount = new MetroFramework.Controls.MetroTextBox();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cmPartyName = new System.Windows.Forms.ComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtPartyName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtInvoiceNoDetail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtChequeNODetail = new MetroFramework.Controls.MetroTextBox();
            this.txtBankCodeDetail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvCashBook)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvCashBook
            // 
            this.gvCashBook.AllowUserToAddRows = false;
            this.gvCashBook.AllowUserToDeleteRows = false;
            this.gvCashBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCashBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvCashBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvCashBook.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvCashBook.Location = new System.Drawing.Point(23, 137);
            this.gvCashBook.Name = "gvCashBook";
            this.gvCashBook.ReadOnly = true;
            this.gvCashBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCashBook.ShowEditingIcon = false;
            this.gvCashBook.Size = new System.Drawing.Size(953, 451);
            this.gvCashBook.TabIndex = 0;
            this.gvCashBook.SelectionChanged += new System.EventHandler(this.gvCashBook_SelectionChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Recipets";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(117, 73);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(111, 39);
            this.metroTile1.TabIndex = 10;
            this.metroTile1.Text = "Add A Reciept";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(246, 73);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(118, 39);
            this.metroTile3.TabIndex = 12;
            this.metroTile3.Text = "Add A Payment";
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(1135, 21);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(111, 39);
            this.metroTile5.TabIndex = 14;
            this.metroTile5.Text = "Back";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(190, 351);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(88, 39);
            this.metroTile2.TabIndex = 19;
            this.metroTile2.Text = "Search";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmPartyName);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroTile2);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.txtRefNo);
            this.groupBox1.Controls.Add(this.txtInvoiceNo);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.txtBankCode);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txtChequeNo);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.dtEndDate);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.dtStartDate);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(983, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 406);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(3, 240);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(71, 19);
            this.metroLabel8.TabIndex = 32;
            this.metroLabel8.Text = "Invoice No";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(7, 265);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(50, 19);
            this.metroLabel7.TabIndex = 31;
            this.metroLabel7.Text = "Ref No";
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
            this.txtRefNo.Location = new System.Drawing.Point(80, 265);
            this.txtRefNo.MaxLength = 32767;
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.PasswordChar = '\0';
            this.txtRefNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRefNo.SelectedText = "";
            this.txtRefNo.SelectionLength = 0;
            this.txtRefNo.SelectionStart = 0;
            this.txtRefNo.ShortcutsEnabled = true;
            this.txtRefNo.Size = new System.Drawing.Size(200, 23);
            this.txtRefNo.TabIndex = 30;
            this.txtRefNo.UseSelectable = true;
            this.txtRefNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRefNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtInvoiceNo
            // 
            // 
            // 
            // 
            this.txtInvoiceNo.CustomButton.Image = null;
            this.txtInvoiceNo.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtInvoiceNo.CustomButton.Name = "";
            this.txtInvoiceNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInvoiceNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInvoiceNo.CustomButton.TabIndex = 1;
            this.txtInvoiceNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvoiceNo.CustomButton.UseSelectable = true;
            this.txtInvoiceNo.CustomButton.Visible = false;
            this.txtInvoiceNo.Lines = new string[0];
            this.txtInvoiceNo.Location = new System.Drawing.Point(80, 236);
            this.txtInvoiceNo.MaxLength = 32767;
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.PasswordChar = '\0';
            this.txtInvoiceNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoiceNo.SelectedText = "";
            this.txtInvoiceNo.SelectionLength = 0;
            this.txtInvoiceNo.SelectionStart = 0;
            this.txtInvoiceNo.ShortcutsEnabled = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(200, 23);
            this.txtInvoiceNo.TabIndex = 29;
            this.txtInvoiceNo.UseSelectable = true;
            this.txtInvoiceNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvoiceNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(7, 186);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(73, 19);
            this.metroLabel6.TabIndex = 28;
            this.metroLabel6.Text = "Bank Code";
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
            this.txtBankCode.Location = new System.Drawing.Point(81, 186);
            this.txtBankCode.MaxLength = 32767;
            this.txtBankCode.Name = "txtBankCode";
            this.txtBankCode.PasswordChar = '\0';
            this.txtBankCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBankCode.SelectedText = "";
            this.txtBankCode.SelectionLength = 0;
            this.txtBankCode.SelectionStart = 0;
            this.txtBankCode.ShortcutsEnabled = true;
            this.txtBankCode.Size = new System.Drawing.Size(200, 23);
            this.txtBankCode.TabIndex = 27;
            this.txtBankCode.UseSelectable = true;
            this.txtBankCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBankCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBankCode.Click += new System.EventHandler(this.metroTextBox3_Click);
            this.txtBankCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBankCode_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(5, 157);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 19);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Cheque No";
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
            this.txtChequeNo.Location = new System.Drawing.Point(81, 157);
            this.txtChequeNo.MaxLength = 32767;
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.PasswordChar = '\0';
            this.txtChequeNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChequeNo.SelectedText = "";
            this.txtChequeNo.SelectionLength = 0;
            this.txtChequeNo.SelectionStart = 0;
            this.txtChequeNo.ShortcutsEnabled = true;
            this.txtChequeNo.Size = new System.Drawing.Size(200, 23);
            this.txtChequeNo.TabIndex = 25;
            this.txtChequeNo.UseSelectable = true;
            this.txtChequeNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChequeNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtChequeNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChequeNo_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 100);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Amount";
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.CustomButton.Image = null;
            this.txtAmount.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtAmount.CustomButton.Name = "";
            this.txtAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmount.CustomButton.TabIndex = 1;
            this.txtAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmount.CustomButton.UseSelectable = true;
            this.txtAmount.CustomButton.Visible = false;
            this.txtAmount.Lines = new string[0];
            this.txtAmount.Location = new System.Drawing.Point(80, 100);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.Size = new System.Drawing.Size(200, 23);
            this.txtAmount.TabIndex = 23;
            this.txtAmount.UseSelectable = true;
            this.txtAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(80, 53);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtEndDate.TabIndex = 22;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 54);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "End Date";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(80, 24);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtStartDate.TabIndex = 20;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 25);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "Start Date";
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(380, 73);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(117, 39);
            this.metroTile4.TabIndex = 21;
            this.metroTile4.Text = "Refresh";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel13);
            this.groupBox2.Controls.Add(this.txtBankCodeDetail);
            this.groupBox2.Controls.Add(this.metroLabel11);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Controls.Add(this.txtInvoiceNoDetail);
            this.groupBox2.Controls.Add(this.txtPartyName);
            this.groupBox2.Controls.Add(this.metroLabel12);
            this.groupBox2.Controls.Add(this.txtChequeNODetail);
            this.groupBox2.Location = new System.Drawing.Point(23, 596);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 130);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(1, 314);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(79, 19);
            this.metroLabel9.TabIndex = 34;
            this.metroLabel9.Text = "Party Name";
            // 
            // cmPartyName
            // 
            this.cmPartyName.FormattingEnabled = true;
            this.cmPartyName.Location = new System.Drawing.Point(80, 313);
            this.cmPartyName.Name = "cmPartyName";
            this.cmPartyName.Size = new System.Drawing.Size(198, 21);
            this.cmPartyName.TabIndex = 35;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(6, 35);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(79, 19);
            this.metroLabel10.TabIndex = 37;
            this.metroLabel10.Text = "Party Name";
            // 
            // txtPartyName
            // 
            // 
            // 
            // 
            this.txtPartyName.CustomButton.Image = null;
            this.txtPartyName.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtPartyName.CustomButton.Name = "";
            this.txtPartyName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPartyName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPartyName.CustomButton.TabIndex = 1;
            this.txtPartyName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPartyName.CustomButton.UseSelectable = true;
            this.txtPartyName.CustomButton.Visible = false;
            this.txtPartyName.Lines = new string[0];
            this.txtPartyName.Location = new System.Drawing.Point(94, 35);
            this.txtPartyName.MaxLength = 32767;
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.PasswordChar = '\0';
            this.txtPartyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPartyName.SelectedText = "";
            this.txtPartyName.SelectionLength = 0;
            this.txtPartyName.SelectionStart = 0;
            this.txtPartyName.ShortcutsEnabled = true;
            this.txtPartyName.Size = new System.Drawing.Size(200, 23);
            this.txtPartyName.TabIndex = 36;
            this.txtPartyName.UseSelectable = true;
            this.txtPartyName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPartyName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPartyName.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(6, 76);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(67, 19);
            this.metroLabel11.TabIndex = 39;
            this.metroLabel11.Text = "InvoiceNo";
            this.metroLabel11.Click += new System.EventHandler(this.metroLabel11_Click);
            // 
            // txtInvoiceNoDetail
            // 
            // 
            // 
            // 
            this.txtInvoiceNoDetail.CustomButton.Image = null;
            this.txtInvoiceNoDetail.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtInvoiceNoDetail.CustomButton.Name = "";
            this.txtInvoiceNoDetail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInvoiceNoDetail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInvoiceNoDetail.CustomButton.TabIndex = 1;
            this.txtInvoiceNoDetail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvoiceNoDetail.CustomButton.UseSelectable = true;
            this.txtInvoiceNoDetail.CustomButton.Visible = false;
            this.txtInvoiceNoDetail.Lines = new string[0];
            this.txtInvoiceNoDetail.Location = new System.Drawing.Point(94, 76);
            this.txtInvoiceNoDetail.MaxLength = 32767;
            this.txtInvoiceNoDetail.Name = "txtInvoiceNoDetail";
            this.txtInvoiceNoDetail.PasswordChar = '\0';
            this.txtInvoiceNoDetail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoiceNoDetail.SelectedText = "";
            this.txtInvoiceNoDetail.SelectionLength = 0;
            this.txtInvoiceNoDetail.SelectionStart = 0;
            this.txtInvoiceNoDetail.ShortcutsEnabled = true;
            this.txtInvoiceNoDetail.Size = new System.Drawing.Size(200, 23);
            this.txtInvoiceNoDetail.TabIndex = 38;
            this.txtInvoiceNoDetail.UseSelectable = true;
            this.txtInvoiceNoDetail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvoiceNoDetail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInvoiceNoDetail.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(319, 39);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(76, 19);
            this.metroLabel12.TabIndex = 37;
            this.metroLabel12.Text = "Cheque No";
            // 
            // txtChequeNODetail
            // 
            // 
            // 
            // 
            this.txtChequeNODetail.CustomButton.Image = null;
            this.txtChequeNODetail.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtChequeNODetail.CustomButton.Name = "";
            this.txtChequeNODetail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtChequeNODetail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChequeNODetail.CustomButton.TabIndex = 1;
            this.txtChequeNODetail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChequeNODetail.CustomButton.UseSelectable = true;
            this.txtChequeNODetail.CustomButton.Visible = false;
            this.txtChequeNODetail.Lines = new string[0];
            this.txtChequeNODetail.Location = new System.Drawing.Point(401, 39);
            this.txtChequeNODetail.MaxLength = 32767;
            this.txtChequeNODetail.Name = "txtChequeNODetail";
            this.txtChequeNODetail.PasswordChar = '\0';
            this.txtChequeNODetail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChequeNODetail.SelectedText = "";
            this.txtChequeNODetail.SelectionLength = 0;
            this.txtChequeNODetail.SelectionStart = 0;
            this.txtChequeNODetail.ShortcutsEnabled = true;
            this.txtChequeNODetail.Size = new System.Drawing.Size(200, 23);
            this.txtChequeNODetail.TabIndex = 36;
            this.txtChequeNODetail.UseSelectable = true;
            this.txtChequeNODetail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChequeNODetail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBankCodeDetail
            // 
            // 
            // 
            // 
            this.txtBankCodeDetail.CustomButton.Image = null;
            this.txtBankCodeDetail.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtBankCodeDetail.CustomButton.Name = "";
            this.txtBankCodeDetail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBankCodeDetail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBankCodeDetail.CustomButton.TabIndex = 1;
            this.txtBankCodeDetail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBankCodeDetail.CustomButton.UseSelectable = true;
            this.txtBankCodeDetail.CustomButton.Visible = false;
            this.txtBankCodeDetail.Lines = new string[0];
            this.txtBankCodeDetail.Location = new System.Drawing.Point(401, 76);
            this.txtBankCodeDetail.MaxLength = 32767;
            this.txtBankCodeDetail.Name = "txtBankCodeDetail";
            this.txtBankCodeDetail.PasswordChar = '\0';
            this.txtBankCodeDetail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBankCodeDetail.SelectedText = "";
            this.txtBankCodeDetail.SelectionLength = 0;
            this.txtBankCodeDetail.SelectionStart = 0;
            this.txtBankCodeDetail.ShortcutsEnabled = true;
            this.txtBankCodeDetail.Size = new System.Drawing.Size(200, 23);
            this.txtBankCodeDetail.TabIndex = 40;
            this.txtBankCodeDetail.UseSelectable = true;
            this.txtBankCodeDetail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBankCodeDetail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(319, 76);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(73, 19);
            this.metroLabel13.TabIndex = 41;
            this.metroLabel13.Text = "Bank Code";
            // 
            // CashBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 729);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.gvCashBook);
            this.Name = "CashBook";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 5);
            this.Text = "CashBook";
            this.Load += new System.EventHandler(this.CashBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCashBook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvCashBook;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtAmount;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtRefNo;
        private MetroFramework.Controls.MetroTextBox txtInvoiceNo;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtBankCode;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtChequeNo;
        private MetroFramework.Controls.MetroTile metroTile4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmPartyName;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtInvoiceNoDetail;
        private MetroFramework.Controls.MetroTextBox txtPartyName;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtChequeNODetail;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txtBankCodeDetail;
    }
}
