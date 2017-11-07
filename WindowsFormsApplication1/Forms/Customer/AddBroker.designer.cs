namespace WindowsFormsApplication1.Forms
{
    partial class AddBroker
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
            this.msmAddCus = new MetroFramework.Components.MetroStyleManager(this.components);
            this.txtCName = new MetroFramework.Controls.MetroTextBox();
            this.txtCAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtCPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtCEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtBack = new MetroFramework.Controls.MetroTile();
            this.mtClear = new MetroFramework.Controls.MetroTile();
            this.mtCreate = new MetroFramework.Controls.MetroTile();
            this.lblmsg = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.msmAddCus)).BeginInit();
            this.SuspendLayout();
            // 
            // msmAddCus
            // 
            this.msmAddCus.Owner = null;
            // 
            // txtCName
            // 
            this.txtCName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtCName.CustomButton.Image = null;
            this.txtCName.CustomButton.Location = new System.Drawing.Point(213, 2);
            this.txtCName.CustomButton.Name = "";
            this.txtCName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCName.CustomButton.TabIndex = 1;
            this.txtCName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCName.CustomButton.UseSelectable = true;
            this.txtCName.CustomButton.Visible = false;
            this.txtCName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCName.Lines = new string[0];
            this.txtCName.Location = new System.Drawing.Point(144, 91);
            this.txtCName.MaxLength = 32767;
            this.txtCName.Name = "txtCName";
            this.txtCName.PasswordChar = '\0';
            this.txtCName.PromptText = "Full Name";
            this.txtCName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCName.SelectedText = "";
            this.txtCName.SelectionLength = 0;
            this.txtCName.SelectionStart = 0;
            this.txtCName.ShortcutsEnabled = true;
            this.txtCName.Size = new System.Drawing.Size(241, 30);
            this.txtCName.TabIndex = 0;
            this.txtCName.UseSelectable = true;
            this.txtCName.WaterMark = "Full Name";
            this.txtCName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCName.Click += new System.EventHandler(this.txtCName_Click);
            // 
            // txtCAddress
            // 
            this.txtCAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtCAddress.CustomButton.Image = null;
            this.txtCAddress.CustomButton.Location = new System.Drawing.Point(187, 2);
            this.txtCAddress.CustomButton.Name = "";
            this.txtCAddress.CustomButton.Size = new System.Drawing.Size(51, 51);
            this.txtCAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCAddress.CustomButton.TabIndex = 1;
            this.txtCAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCAddress.CustomButton.UseSelectable = true;
            this.txtCAddress.CustomButton.Visible = false;
            this.txtCAddress.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCAddress.Lines = new string[0];
            this.txtCAddress.Location = new System.Drawing.Point(144, 140);
            this.txtCAddress.MaxLength = 32767;
            this.txtCAddress.Multiline = true;
            this.txtCAddress.Name = "txtCAddress";
            this.txtCAddress.PasswordChar = '\0';
            this.txtCAddress.PromptText = "Address";
            this.txtCAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCAddress.SelectedText = "";
            this.txtCAddress.SelectionLength = 0;
            this.txtCAddress.SelectionStart = 0;
            this.txtCAddress.ShortcutsEnabled = true;
            this.txtCAddress.Size = new System.Drawing.Size(241, 56);
            this.txtCAddress.TabIndex = 1;
            this.txtCAddress.UseSelectable = true;
            this.txtCAddress.WaterMark = "Address";
            this.txtCAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCPhone
            // 
            this.txtCPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtCPhone.CustomButton.Image = null;
            this.txtCPhone.CustomButton.Location = new System.Drawing.Point(213, 2);
            this.txtCPhone.CustomButton.Name = "";
            this.txtCPhone.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCPhone.CustomButton.TabIndex = 1;
            this.txtCPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCPhone.CustomButton.UseSelectable = true;
            this.txtCPhone.CustomButton.Visible = false;
            this.txtCPhone.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCPhone.Lines = new string[0];
            this.txtCPhone.Location = new System.Drawing.Point(144, 215);
            this.txtCPhone.MaxLength = 32767;
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.PasswordChar = '\0';
            this.txtCPhone.PromptText = "Phone";
            this.txtCPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCPhone.SelectedText = "";
            this.txtCPhone.SelectionLength = 0;
            this.txtCPhone.SelectionStart = 0;
            this.txtCPhone.ShortcutsEnabled = true;
            this.txtCPhone.Size = new System.Drawing.Size(241, 30);
            this.txtCPhone.TabIndex = 2;
            this.txtCPhone.UseSelectable = true;
            this.txtCPhone.WaterMark = "Phone";
            this.txtCPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCEmail
            // 
            this.txtCEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtCEmail.CustomButton.Image = null;
            this.txtCEmail.CustomButton.Location = new System.Drawing.Point(213, 2);
            this.txtCEmail.CustomButton.Name = "";
            this.txtCEmail.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCEmail.CustomButton.TabIndex = 1;
            this.txtCEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCEmail.CustomButton.UseSelectable = true;
            this.txtCEmail.CustomButton.Visible = false;
            this.txtCEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCEmail.Lines = new string[0];
            this.txtCEmail.Location = new System.Drawing.Point(144, 265);
            this.txtCEmail.MaxLength = 32767;
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.PasswordChar = '\0';
            this.txtCEmail.PromptText = "Email";
            this.txtCEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCEmail.SelectedText = "";
            this.txtCEmail.SelectionLength = 0;
            this.txtCEmail.SelectionStart = 0;
            this.txtCEmail.ShortcutsEnabled = true;
            this.txtCEmail.Size = new System.Drawing.Size(241, 30);
            this.txtCEmail.TabIndex = 3;
            this.txtCEmail.UseSelectable = true;
            this.txtCEmail.WaterMark = "Email";
            this.txtCEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(52, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Name : ";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(52, 140);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 25);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Address :";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(52, 215);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 25);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Phone :";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(52, 265);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 25);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Email  :";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // mtBack
            // 
            this.mtBack.ActiveControl = null;
            this.mtBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mtBack.BackColor = System.Drawing.Color.SkyBlue;
            this.mtBack.Location = new System.Drawing.Point(288, 339);
            this.mtBack.Name = "mtBack";
            this.mtBack.Size = new System.Drawing.Size(96, 92);
            this.mtBack.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtBack.TabIndex = 12;
            this.mtBack.Text = "Back";
            this.mtBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtBack.TileImage = global::WindowsFormsApplication1.Properties.Resources.Back_32px;
            this.mtBack.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtBack.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtBack.UseCustomBackColor = true;
            this.mtBack.UseSelectable = true;
            this.mtBack.UseTileImage = true;
            this.mtBack.Click += new System.EventHandler(this.mtBack_Click);
            // 
            // mtClear
            // 
            this.mtClear.ActiveControl = null;
            this.mtClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mtClear.BackColor = System.Drawing.Color.SkyBlue;
            this.mtClear.Location = new System.Drawing.Point(170, 339);
            this.mtClear.Name = "mtClear";
            this.mtClear.Size = new System.Drawing.Size(96, 92);
            this.mtClear.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtClear.TabIndex = 11;
            this.mtClear.Text = "Clear";
            this.mtClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtClear.TileImage = global::WindowsFormsApplication1.Properties.Resources.Eraser;
            this.mtClear.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtClear.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtClear.UseCustomBackColor = true;
            this.mtClear.UseSelectable = true;
            this.mtClear.UseTileImage = true;
            this.mtClear.Click += new System.EventHandler(this.mtClear_Click);
            // 
            // mtCreate
            // 
            this.mtCreate.ActiveControl = null;
            this.mtCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mtCreate.BackColor = System.Drawing.Color.SkyBlue;
            this.mtCreate.Location = new System.Drawing.Point(53, 339);
            this.mtCreate.Name = "mtCreate";
            this.mtCreate.Size = new System.Drawing.Size(98, 92);
            this.mtCreate.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtCreate.TabIndex = 10;
            this.mtCreate.Text = "Create";
            this.mtCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtCreate.TileImage = global::WindowsFormsApplication1.Properties.Resources.icons8_Add_User_Male_32;
            this.mtCreate.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCreate.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCreate.UseCustomBackColor = true;
            this.mtCreate.UseSelectable = true;
            this.mtCreate.UseTileImage = true;
            this.mtCreate.Click += new System.EventHandler(this.mtCreate_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblmsg.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblmsg.ForeColor = System.Drawing.Color.Black;
            this.lblmsg.Location = new System.Drawing.Point(144, 298);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 0);
            this.lblmsg.TabIndex = 57;
            this.lblmsg.UseCustomBackColor = true;
            this.lblmsg.UseCustomForeColor = true;
            // 
            // AddBroker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(474, 454);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.mtBack);
            this.Controls.Add(this.mtClear);
            this.Controls.Add(this.mtCreate);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtCEmail);
            this.Controls.Add(this.txtCPhone);
            this.Controls.Add(this.txtCAddress);
            this.Controls.Add(this.txtCName);
            this.Name = "AddBroker";
            this.Text = "Add Broker";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCus_FormClosing);
            this.Load += new System.EventHandler(this.AddCus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmAddCus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmAddCus;
        private MetroFramework.Controls.MetroTextBox txtCName;
        private MetroFramework.Controls.MetroTextBox txtCAddress;
        private MetroFramework.Controls.MetroTextBox txtCPhone;
        private MetroFramework.Controls.MetroTextBox txtCEmail;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile mtBack;
        private MetroFramework.Controls.MetroTile mtClear;
        private MetroFramework.Controls.MetroTile mtCreate;
        private MetroFramework.Controls.MetroLabel lblmsg;
    }
}