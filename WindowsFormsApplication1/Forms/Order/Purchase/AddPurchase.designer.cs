namespace WindowsFormsApplication1.Forms.Purchase
{
    partial class AddPurchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPurchase));
            this.txtCarrage = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txtTulai = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txtBardena = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cmBrokerName = new MetroFramework.Controls.MetroComboBox();
            this.txtBrokeryAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtRatePerKg = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtShortage = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtWeightPerBag = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtTotalBagsQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.txtGrade = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.Garden = new MetroFramework.Controls.MetroLabel();
            this.txtLotNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbsuppname = new MetroFramework.Controls.MetroComboBox();
            this.cmbpaydate = new MetroFramework.Controls.MetroDateTime();
            this.txtGardenName = new MetroFramework.Controls.MetroTextBox();
            this.btnadditem = new MetroFramework.Controls.MetroTile();
            this.btnback = new MetroFramework.Controls.MetroTile();
            this.btnclr = new MetroFramework.Controls.MetroTile();
            this.txtNetWeight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.txtTotalWeight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCost = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.txtTotalCost = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCarrage
            // 
            // 
            // 
            // 
            this.txtCarrage.CustomButton.Image = null;
            this.txtCarrage.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.txtCarrage.CustomButton.Name = "";
            this.txtCarrage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCarrage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCarrage.CustomButton.TabIndex = 1;
            this.txtCarrage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCarrage.CustomButton.UseSelectable = true;
            this.txtCarrage.CustomButton.Visible = false;
            this.txtCarrage.Lines = new string[0];
            this.txtCarrage.Location = new System.Drawing.Point(567, 386);
            this.txtCarrage.MaxLength = 32767;
            this.txtCarrage.Name = "txtCarrage";
            this.txtCarrage.PasswordChar = '\0';
            this.txtCarrage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCarrage.SelectedText = "";
            this.txtCarrage.SelectionLength = 0;
            this.txtCarrage.SelectionStart = 0;
            this.txtCarrage.ShortcutsEnabled = true;
            this.txtCarrage.Size = new System.Drawing.Size(221, 26);
            this.txtCarrage.TabIndex = 167;
            this.txtCarrage.UseSelectable = true;
            this.txtCarrage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCarrage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCarrage.TextChanged += new System.EventHandler(this.txtCarrage_TextChanged);
            this.txtCarrage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarrage_KeyPress);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(470, 386);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(57, 19);
            this.metroLabel15.TabIndex = 166;
            this.metroLabel15.Text = "Carrage";
            // 
            // txtTulai
            // 
            // 
            // 
            // 
            this.txtTulai.CustomButton.Image = null;
            this.txtTulai.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.txtTulai.CustomButton.Name = "";
            this.txtTulai.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTulai.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTulai.CustomButton.TabIndex = 1;
            this.txtTulai.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTulai.CustomButton.UseSelectable = true;
            this.txtTulai.CustomButton.Visible = false;
            this.txtTulai.Lines = new string[0];
            this.txtTulai.Location = new System.Drawing.Point(928, 340);
            this.txtTulai.MaxLength = 32767;
            this.txtTulai.Name = "txtTulai";
            this.txtTulai.PasswordChar = '\0';
            this.txtTulai.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTulai.SelectedText = "";
            this.txtTulai.SelectionLength = 0;
            this.txtTulai.SelectionStart = 0;
            this.txtTulai.ShortcutsEnabled = true;
            this.txtTulai.Size = new System.Drawing.Size(221, 26);
            this.txtTulai.TabIndex = 165;
            this.txtTulai.UseSelectable = true;
            this.txtTulai.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTulai.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTulai.TextChanged += new System.EventHandler(this.txtTulai_TextChanged);
            this.txtTulai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTulai_KeyPress);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(813, 346);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(34, 19);
            this.metroLabel14.TabIndex = 164;
            this.metroLabel14.Text = "Tulai";
            // 
            // txtBardena
            // 
            // 
            // 
            // 
            this.txtBardena.CustomButton.Image = null;
            this.txtBardena.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.txtBardena.CustomButton.Name = "";
            this.txtBardena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBardena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBardena.CustomButton.TabIndex = 1;
            this.txtBardena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBardena.CustomButton.UseSelectable = true;
            this.txtBardena.CustomButton.Visible = false;
            this.txtBardena.Lines = new string[0];
            this.txtBardena.Location = new System.Drawing.Point(568, 340);
            this.txtBardena.MaxLength = 32767;
            this.txtBardena.Name = "txtBardena";
            this.txtBardena.PasswordChar = '\0';
            this.txtBardena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBardena.SelectedText = "";
            this.txtBardena.SelectionLength = 0;
            this.txtBardena.SelectionStart = 0;
            this.txtBardena.ShortcutsEnabled = true;
            this.txtBardena.Size = new System.Drawing.Size(221, 26);
            this.txtBardena.TabIndex = 163;
            this.txtBardena.UseSelectable = true;
            this.txtBardena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBardena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBardena.TextChanged += new System.EventHandler(this.txtBardena_TextChanged);
            this.txtBardena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBardena_KeyPress);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(470, 346);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(58, 19);
            this.metroLabel13.TabIndex = 162;
            this.metroLabel13.Text = "Bardena";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.ForeColor = System.Drawing.Color.Black;
            this.metroLabel8.Location = new System.Drawing.Point(469, 300);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(99, 19);
            this.metroLabel8.TabIndex = 161;
            this.metroLabel8.Text = "Broker Name : ";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // cmBrokerName
            // 
            this.cmBrokerName.FormattingEnabled = true;
            this.cmBrokerName.ItemHeight = 23;
            this.cmBrokerName.Location = new System.Drawing.Point(568, 297);
            this.cmBrokerName.Name = "cmBrokerName";
            this.cmBrokerName.PromptText = "Select Broker Name";
            this.cmBrokerName.Size = new System.Drawing.Size(221, 29);
            this.cmBrokerName.TabIndex = 160;
            this.cmBrokerName.UseSelectable = true;
            // 
            // txtBrokeryAmount
            // 
            // 
            // 
            // 
            this.txtBrokeryAmount.CustomButton.Image = null;
            this.txtBrokeryAmount.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.txtBrokeryAmount.CustomButton.Name = "";
            this.txtBrokeryAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBrokeryAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBrokeryAmount.CustomButton.TabIndex = 1;
            this.txtBrokeryAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBrokeryAmount.CustomButton.UseSelectable = true;
            this.txtBrokeryAmount.CustomButton.Visible = false;
            this.txtBrokeryAmount.Lines = new string[0];
            this.txtBrokeryAmount.Location = new System.Drawing.Point(928, 295);
            this.txtBrokeryAmount.MaxLength = 32767;
            this.txtBrokeryAmount.Name = "txtBrokeryAmount";
            this.txtBrokeryAmount.PasswordChar = '\0';
            this.txtBrokeryAmount.PromptText = "enter brokery amount";
            this.txtBrokeryAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBrokeryAmount.SelectedText = "";
            this.txtBrokeryAmount.SelectionLength = 0;
            this.txtBrokeryAmount.SelectionStart = 0;
            this.txtBrokeryAmount.ShortcutsEnabled = true;
            this.txtBrokeryAmount.Size = new System.Drawing.Size(221, 26);
            this.txtBrokeryAmount.TabIndex = 159;
            this.txtBrokeryAmount.UseSelectable = true;
            this.txtBrokeryAmount.WaterMark = "enter brokery amount";
            this.txtBrokeryAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBrokeryAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBrokeryAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrokeryAmount_KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(813, 297);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(109, 19);
            this.metroLabel6.TabIndex = 158;
            this.metroLabel6.Text = "Brokery Amount:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.Black;
            this.metroLabel5.Location = new System.Drawing.Point(600, 247);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(221, 25);
            this.metroLabel5.TabIndex = 157;
            this.metroLabel5.Text = "Purchase Details (optional)";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // txtRatePerKg
            // 
            // 
            // 
            // 
            this.txtRatePerKg.CustomButton.Image = null;
            this.txtRatePerKg.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.txtRatePerKg.CustomButton.Name = "";
            this.txtRatePerKg.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRatePerKg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRatePerKg.CustomButton.TabIndex = 1;
            this.txtRatePerKg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRatePerKg.CustomButton.UseSelectable = true;
            this.txtRatePerKg.CustomButton.Visible = false;
            this.txtRatePerKg.Lines = new string[0];
            this.txtRatePerKg.Location = new System.Drawing.Point(123, 461);
            this.txtRatePerKg.MaxLength = 32767;
            this.txtRatePerKg.Name = "txtRatePerKg";
            this.txtRatePerKg.PasswordChar = '\0';
            this.txtRatePerKg.PromptText = "Enter Rate Per Kg";
            this.txtRatePerKg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRatePerKg.SelectedText = "";
            this.txtRatePerKg.SelectionLength = 0;
            this.txtRatePerKg.SelectionStart = 0;
            this.txtRatePerKg.ShortcutsEnabled = true;
            this.txtRatePerKg.Size = new System.Drawing.Size(221, 26);
            this.txtRatePerKg.TabIndex = 156;
            this.txtRatePerKg.UseSelectable = true;
            this.txtRatePerKg.WaterMark = "Enter Rate Per Kg";
            this.txtRatePerKg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRatePerKg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRatePerKg.TextChanged += new System.EventHandler(this.txtRatePerKg_TextChanged);
            this.txtRatePerKg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRatePerKg_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 455);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 19);
            this.metroLabel2.TabIndex = 155;
            this.metroLabel2.Text = "Rate";
            // 
            // txtShortage
            // 
            // 
            // 
            // 
            this.txtShortage.CustomButton.Image = null;
            this.txtShortage.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.txtShortage.CustomButton.Name = "";
            this.txtShortage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtShortage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtShortage.CustomButton.TabIndex = 1;
            this.txtShortage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtShortage.CustomButton.UseSelectable = true;
            this.txtShortage.CustomButton.Visible = false;
            this.txtShortage.Lines = new string[0];
            this.txtShortage.Location = new System.Drawing.Point(123, 411);
            this.txtShortage.MaxLength = 32767;
            this.txtShortage.Name = "txtShortage";
            this.txtShortage.PasswordChar = '\0';
            this.txtShortage.PromptText = "Enter  Quantity shortage (optional)";
            this.txtShortage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtShortage.SelectedText = "";
            this.txtShortage.SelectionLength = 0;
            this.txtShortage.SelectionStart = 0;
            this.txtShortage.ShortcutsEnabled = true;
            this.txtShortage.Size = new System.Drawing.Size(221, 26);
            this.txtShortage.TabIndex = 154;
            this.txtShortage.UseSelectable = true;
            this.txtShortage.WaterMark = "Enter  Quantity shortage (optional)";
            this.txtShortage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtShortage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtShortage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShortage_KeyPress);
            this.txtShortage.Leave += new System.EventHandler(this.txtShortage_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 413);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.TabIndex = 153;
            this.metroLabel1.Text = "Shortage (Kg)";
            // 
            // txtWeightPerBag
            // 
            // 
            // 
            // 
            this.txtWeightPerBag.CustomButton.Image = null;
            this.txtWeightPerBag.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.txtWeightPerBag.CustomButton.Name = "";
            this.txtWeightPerBag.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtWeightPerBag.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWeightPerBag.CustomButton.TabIndex = 1;
            this.txtWeightPerBag.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWeightPerBag.CustomButton.UseSelectable = true;
            this.txtWeightPerBag.CustomButton.Visible = false;
            this.txtWeightPerBag.Lines = new string[0];
            this.txtWeightPerBag.Location = new System.Drawing.Point(123, 314);
            this.txtWeightPerBag.MaxLength = 32767;
            this.txtWeightPerBag.Name = "txtWeightPerBag";
            this.txtWeightPerBag.PasswordChar = '\0';
            this.txtWeightPerBag.PromptText = "Enter Weight Per Bag";
            this.txtWeightPerBag.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWeightPerBag.SelectedText = "";
            this.txtWeightPerBag.SelectionLength = 0;
            this.txtWeightPerBag.SelectionStart = 0;
            this.txtWeightPerBag.ShortcutsEnabled = true;
            this.txtWeightPerBag.Size = new System.Drawing.Size(221, 26);
            this.txtWeightPerBag.TabIndex = 152;
            this.txtWeightPerBag.UseSelectable = true;
            this.txtWeightPerBag.WaterMark = "Enter Weight Per Bag";
            this.txtWeightPerBag.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWeightPerBag.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtWeightPerBag.TextChanged += new System.EventHandler(this.txtWeightPerBag_TextChanged);
            this.txtWeightPerBag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeightPerBag_KeyPress);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(25, 308);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(77, 38);
            this.metroLabel12.TabIndex = 151;
            this.metroLabel12.Text = "Weight Per \r\nBag (Kg)";
            // 
            // txtTotalBagsQuantity
            // 
            // 
            // 
            // 
            this.txtTotalBagsQuantity.CustomButton.Image = null;
            this.txtTotalBagsQuantity.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.txtTotalBagsQuantity.CustomButton.Name = "";
            this.txtTotalBagsQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalBagsQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalBagsQuantity.CustomButton.TabIndex = 1;
            this.txtTotalBagsQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalBagsQuantity.CustomButton.UseSelectable = true;
            this.txtTotalBagsQuantity.CustomButton.Visible = false;
            this.txtTotalBagsQuantity.Lines = new string[0];
            this.txtTotalBagsQuantity.Location = new System.Drawing.Point(123, 267);
            this.txtTotalBagsQuantity.MaxLength = 32767;
            this.txtTotalBagsQuantity.Name = "txtTotalBagsQuantity";
            this.txtTotalBagsQuantity.PasswordChar = '\0';
            this.txtTotalBagsQuantity.PromptText = "Enter Quantity";
            this.txtTotalBagsQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalBagsQuantity.SelectedText = "";
            this.txtTotalBagsQuantity.SelectionLength = 0;
            this.txtTotalBagsQuantity.SelectionStart = 0;
            this.txtTotalBagsQuantity.ShortcutsEnabled = true;
            this.txtTotalBagsQuantity.Size = new System.Drawing.Size(221, 26);
            this.txtTotalBagsQuantity.TabIndex = 150;
            this.txtTotalBagsQuantity.UseSelectable = true;
            this.txtTotalBagsQuantity.WaterMark = "Enter Quantity";
            this.txtTotalBagsQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalBagsQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalBagsQuantity.TextChanged += new System.EventHandler(this.txtTotalBagsQuantity_TextChanged);
            this.txtTotalBagsQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalBagsQuantity_KeyPress);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(25, 268);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(101, 19);
            this.metroLabel11.TabIndex = 149;
            this.metroLabel11.Text = "Total Bags (Qty)";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(631, 48);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(93, 25);
            this.metroLabel9.TabIndex = 148;
            this.metroLabel9.Text = "Items Cart";
            this.metroLabel9.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(469, 94);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(680, 150);
            this.metroGrid1.TabIndex = 147;
            // 
            // txtGrade
            // 
            // 
            // 
            // 
            this.txtGrade.CustomButton.Image = null;
            this.txtGrade.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.txtGrade.CustomButton.Name = "";
            this.txtGrade.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGrade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGrade.CustomButton.TabIndex = 1;
            this.txtGrade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGrade.CustomButton.UseSelectable = true;
            this.txtGrade.CustomButton.Visible = false;
            this.txtGrade.Lines = new string[0];
            this.txtGrade.Location = new System.Drawing.Point(123, 218);
            this.txtGrade.MaxLength = 32767;
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.PasswordChar = '\0';
            this.txtGrade.PromptText = "Enter Grade";
            this.txtGrade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGrade.SelectedText = "";
            this.txtGrade.SelectionLength = 0;
            this.txtGrade.SelectionStart = 0;
            this.txtGrade.ShortcutsEnabled = true;
            this.txtGrade.Size = new System.Drawing.Size(221, 26);
            this.txtGrade.TabIndex = 146;
            this.txtGrade.UseSelectable = true;
            this.txtGrade.WaterMark = "Enter Grade";
            this.txtGrade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGrade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(25, 224);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(45, 19);
            this.metroLabel10.TabIndex = 145;
            this.metroLabel10.Text = "Grade";
            // 
            // Garden
            // 
            this.Garden.AutoSize = true;
            this.Garden.Location = new System.Drawing.Point(25, 175);
            this.Garden.Name = "Garden";
            this.Garden.Size = new System.Drawing.Size(52, 19);
            this.Garden.TabIndex = 144;
            this.Garden.Text = "Garden";
            // 
            // txtLotNo
            // 
            // 
            // 
            // 
            this.txtLotNo.CustomButton.Image = null;
            this.txtLotNo.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.txtLotNo.CustomButton.Name = "";
            this.txtLotNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLotNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLotNo.CustomButton.TabIndex = 1;
            this.txtLotNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLotNo.CustomButton.UseSelectable = true;
            this.txtLotNo.CustomButton.Visible = false;
            this.txtLotNo.Lines = new string[0];
            this.txtLotNo.Location = new System.Drawing.Point(123, 119);
            this.txtLotNo.MaxLength = 32767;
            this.txtLotNo.Name = "txtLotNo";
            this.txtLotNo.PasswordChar = '\0';
            this.txtLotNo.PromptText = "Enter LotNo.";
            this.txtLotNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLotNo.SelectedText = "";
            this.txtLotNo.SelectionLength = 0;
            this.txtLotNo.SelectionStart = 0;
            this.txtLotNo.ShortcutsEnabled = true;
            this.txtLotNo.Size = new System.Drawing.Size(221, 26);
            this.txtLotNo.TabIndex = 143;
            this.txtLotNo.UseSelectable = true;
            this.txtLotNo.WaterMark = "Enter LotNo.";
            this.txtLotNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLotNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLotNo.TextChanged += new System.EventHandler(this.txtLotNo_TextChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(25, 119);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(52, 19);
            this.metroLabel7.TabIndex = 142;
            this.metroLabel7.Text = "Lot No.";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(25, 62);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 19);
            this.metroLabel3.TabIndex = 138;
            this.metroLabel3.Text = "Party Name : ";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(964, 48);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 137;
            this.metroLabel4.Text = "Date :";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // cmbsuppname
            // 
            this.cmbsuppname.FormattingEnabled = true;
            this.cmbsuppname.ItemHeight = 23;
            this.cmbsuppname.Location = new System.Drawing.Point(123, 62);
            this.cmbsuppname.Name = "cmbsuppname";
            this.cmbsuppname.PromptText = "Select Party Name";
            this.cmbsuppname.Size = new System.Drawing.Size(221, 29);
            this.cmbsuppname.TabIndex = 136;
            this.cmbsuppname.UseSelectable = true;
            // 
            // cmbpaydate
            // 
            this.cmbpaydate.Location = new System.Drawing.Point(1030, 42);
            this.cmbpaydate.MinimumSize = new System.Drawing.Size(0, 29);
            this.cmbpaydate.Name = "cmbpaydate";
            this.cmbpaydate.Size = new System.Drawing.Size(221, 29);
            this.cmbpaydate.TabIndex = 135;
            // 
            // txtGardenName
            // 
            // 
            // 
            // 
            this.txtGardenName.CustomButton.Image = null;
            this.txtGardenName.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txtGardenName.CustomButton.Name = "";
            this.txtGardenName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGardenName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGardenName.CustomButton.TabIndex = 1;
            this.txtGardenName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGardenName.CustomButton.UseSelectable = true;
            this.txtGardenName.CustomButton.Visible = false;
            this.txtGardenName.Lines = new string[] {
        " "};
            this.txtGardenName.Location = new System.Drawing.Point(123, 175);
            this.txtGardenName.MaxLength = 32767;
            this.txtGardenName.Name = "txtGardenName";
            this.txtGardenName.PasswordChar = '\0';
            this.txtGardenName.PromptText = "Enter Garden Name";
            this.txtGardenName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGardenName.SelectedText = "";
            this.txtGardenName.SelectionLength = 0;
            this.txtGardenName.SelectionStart = 0;
            this.txtGardenName.ShortcutsEnabled = true;
            this.txtGardenName.Size = new System.Drawing.Size(221, 23);
            this.txtGardenName.TabIndex = 168;
            this.txtGardenName.Text = " ";
            this.txtGardenName.UseSelectable = true;
            this.txtGardenName.WaterMark = "Enter Garden Name";
            this.txtGardenName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGardenName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnadditem
            // 
            this.btnadditem.ActiveControl = null;
            this.btnadditem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnadditem.BackColor = System.Drawing.Color.White;
            this.btnadditem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadditem.Location = new System.Drawing.Point(468, 494);
            this.btnadditem.Name = "btnadditem";
            this.btnadditem.Size = new System.Drawing.Size(116, 92);
            this.btnadditem.TabIndex = 141;
            this.btnadditem.Text = "Add To";
            this.btnadditem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadditem.TileImage = global::WindowsFormsApplication1.Properties.Resources.Add_32px;
            this.btnadditem.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnadditem.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnadditem.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnadditem.UseSelectable = true;
            this.btnadditem.UseTileImage = true;
            this.btnadditem.Click += new System.EventHandler(this.btnadditem_Click);
            // 
            // btnback
            // 
            this.btnback.ActiveControl = null;
            this.btnback.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnback.BackColor = System.Drawing.Color.White;
            this.btnback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnback.Location = new System.Drawing.Point(712, 494);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(116, 92);
            this.btnback.TabIndex = 140;
            this.btnback.Text = "Back";
            this.btnback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnback.TileImage = global::WindowsFormsApplication1.Properties.Resources.Back_32px;
            this.btnback.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnback.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnback.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnback.UseSelectable = true;
            this.btnback.UseTileImage = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnclr
            // 
            this.btnclr.ActiveControl = null;
            this.btnclr.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnclr.BackColor = System.Drawing.Color.White;
            this.btnclr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclr.Location = new System.Drawing.Point(590, 494);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(116, 92);
            this.btnclr.TabIndex = 139;
            this.btnclr.Text = "Clear";
            this.btnclr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnclr.TileImage = global::WindowsFormsApplication1.Properties.Resources.Eraser;
            this.btnclr.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnclr.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnclr.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnclr.UseSelectable = true;
            this.btnclr.UseTileImage = true;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // txtNetWeight
            // 
            this.txtNetWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtNetWeight.CustomButton.Image = null;
            this.txtNetWeight.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.txtNetWeight.CustomButton.Name = "";
            this.txtNetWeight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNetWeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNetWeight.CustomButton.TabIndex = 1;
            this.txtNetWeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNetWeight.CustomButton.UseSelectable = true;
            this.txtNetWeight.CustomButton.Visible = false;
            this.txtNetWeight.Lines = new string[0];
            this.txtNetWeight.Location = new System.Drawing.Point(360, 411);
            this.txtNetWeight.MaxLength = 32767;
            this.txtNetWeight.Name = "txtNetWeight";
            this.txtNetWeight.PasswordChar = '\0';
            this.txtNetWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNetWeight.SelectedText = "";
            this.txtNetWeight.SelectionLength = 0;
            this.txtNetWeight.SelectionStart = 0;
            this.txtNetWeight.ShortcutsEnabled = true;
            this.txtNetWeight.Size = new System.Drawing.Size(88, 23);
            this.txtNetWeight.TabIndex = 187;
            this.txtNetWeight.UseSelectable = true;
            this.txtNetWeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNetWeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNetWeight.TextChanged += new System.EventHandler(this.txtNetWeight_TextChanged);
            // 
            // metroLabel18
            // 
            this.metroLabel18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel18.Location = new System.Drawing.Point(360, 389);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(75, 19);
            this.metroLabel18.TabIndex = 186;
            this.metroLabel18.Text = "Net Weight";
            this.metroLabel18.UseCustomBackColor = true;
            this.metroLabel18.UseCustomForeColor = true;
            // 
            // txtTotalWeight
            // 
            // 
            // 
            // 
            this.txtTotalWeight.CustomButton.Image = null;
            this.txtTotalWeight.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txtTotalWeight.CustomButton.Name = "";
            this.txtTotalWeight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalWeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalWeight.CustomButton.TabIndex = 1;
            this.txtTotalWeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalWeight.CustomButton.UseSelectable = true;
            this.txtTotalWeight.CustomButton.Visible = false;
            this.txtTotalWeight.Enabled = false;
            this.txtTotalWeight.Lines = new string[0];
            this.txtTotalWeight.Location = new System.Drawing.Point(123, 364);
            this.txtTotalWeight.MaxLength = 32767;
            this.txtTotalWeight.Name = "txtTotalWeight";
            this.txtTotalWeight.PasswordChar = '\0';
            this.txtTotalWeight.PromptText = "Total Weight";
            this.txtTotalWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalWeight.SelectedText = "";
            this.txtTotalWeight.SelectionLength = 0;
            this.txtTotalWeight.SelectionStart = 0;
            this.txtTotalWeight.ShortcutsEnabled = true;
            this.txtTotalWeight.Size = new System.Drawing.Size(221, 23);
            this.txtTotalWeight.TabIndex = 189;
            this.txtTotalWeight.UseSelectable = true;
            this.txtTotalWeight.WaterMark = "Total Weight";
            this.txtTotalWeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalWeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel16.Location = new System.Drawing.Point(25, 366);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(81, 19);
            this.metroLabel16.TabIndex = 188;
            this.metroLabel16.Text = "Total Weight";
            this.metroLabel16.UseCustomBackColor = true;
            this.metroLabel16.UseCustomForeColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.umbra_logo_small;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(1197, 524);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(66, 66);
            this.panel1.TabIndex = 190;
            // 
            // txtCost
            // 
            // 
            // 
            // 
            this.txtCost.CustomButton.Image = null;
            this.txtCost.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.txtCost.CustomButton.Name = "";
            this.txtCost.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCost.CustomButton.TabIndex = 1;
            this.txtCost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCost.CustomButton.UseSelectable = true;
            this.txtCost.CustomButton.Visible = false;
            this.txtCost.Enabled = false;
            this.txtCost.Lines = new string[0];
            this.txtCost.Location = new System.Drawing.Point(121, 511);
            this.txtCost.MaxLength = 32767;
            this.txtCost.Name = "txtCost";
            this.txtCost.PasswordChar = '\0';
            this.txtCost.PromptText = "Cost";
            this.txtCost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCost.SelectedText = "";
            this.txtCost.SelectionLength = 0;
            this.txtCost.SelectionStart = 0;
            this.txtCost.ShortcutsEnabled = true;
            this.txtCost.Size = new System.Drawing.Size(221, 26);
            this.txtCost.TabIndex = 192;
            this.txtCost.UseSelectable = true;
            this.txtCost.WaterMark = "Cost";
            this.txtCost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(23, 514);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(35, 19);
            this.metroLabel17.TabIndex = 191;
            this.metroLabel17.Text = "Cost";
            // 
            // txtTotalCost
            // 
            // 
            // 
            // 
            this.txtTotalCost.CustomButton.Image = null;
            this.txtTotalCost.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.txtTotalCost.CustomButton.Name = "";
            this.txtTotalCost.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalCost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalCost.CustomButton.TabIndex = 1;
            this.txtTotalCost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalCost.CustomButton.UseSelectable = true;
            this.txtTotalCost.CustomButton.Visible = false;
            this.txtTotalCost.Enabled = false;
            this.txtTotalCost.Lines = new string[0];
            this.txtTotalCost.Location = new System.Drawing.Point(928, 386);
            this.txtTotalCost.MaxLength = 32767;
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.PasswordChar = '\0';
            this.txtTotalCost.PromptText = "Total Cost";
            this.txtTotalCost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalCost.SelectedText = "";
            this.txtTotalCost.SelectionLength = 0;
            this.txtTotalCost.SelectionStart = 0;
            this.txtTotalCost.ShortcutsEnabled = true;
            this.txtTotalCost.Size = new System.Drawing.Size(221, 26);
            this.txtTotalCost.TabIndex = 194;
            this.txtTotalCost.UseSelectable = true;
            this.txtTotalCost.WaterMark = "Total Cost";
            this.txtTotalCost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalCost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Enabled = false;
            this.metroLabel19.Location = new System.Drawing.Point(816, 384);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(62, 19);
            this.metroLabel19.TabIndex = 193;
            this.metroLabel19.Text = "TotalCost";
            // 
            // AddPurchase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1286, 603);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTotalWeight);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.txtNetWeight);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.txtGardenName);
            this.Controls.Add(this.txtCarrage);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.txtTulai);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.txtBardena);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.cmBrokerName);
            this.Controls.Add(this.txtBrokeryAmount);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtRatePerKg);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtShortage);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtWeightPerBag);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.txtTotalBagsQuantity);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.Garden);
            this.Controls.Add(this.txtLotNo);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.btnadditem);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cmbsuppname);
            this.Controls.Add(this.cmbpaydate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPurchase";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 10);
            this.Text = "AddPurchase";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.AddPurchase_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPurchase_FormClosing);
            this.Load += new System.EventHandler(this.AddPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtCarrage;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox txtTulai;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txtBardena;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox cmBrokerName;
        private MetroFramework.Controls.MetroTextBox txtBrokeryAmount;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtRatePerKg;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtShortage;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtWeightPerBag;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtTotalBagsQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox txtGrade;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel Garden;
        private MetroFramework.Controls.MetroTextBox txtLotNo;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTile btnadditem;
        private MetroFramework.Controls.MetroTile btnback;
        private MetroFramework.Controls.MetroTile btnclr;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmbsuppname;
        private MetroFramework.Controls.MetroDateTime cmbpaydate;
        private MetroFramework.Controls.MetroTextBox txtGardenName;
        private MetroFramework.Controls.MetroTextBox txtNetWeight;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroTextBox txtTotalWeight;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox txtCost;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox txtTotalCost;
        private MetroFramework.Controls.MetroLabel metroLabel19;
    }
}