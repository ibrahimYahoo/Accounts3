namespace WindowsFormsApplication1.Forms.Journals
{
    partial class AddJournal
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
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.txtDebitAmount = new MetroFramework.Controls.MetroTextBox();
            this.txtCredtiAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.dtDate = new MetroFramework.Controls.MetroDateTime();
            this.cmDebitAccount = new MetroFramework.Controls.MetroComboBox();
            this.cmCreditAccount = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtJournalId = new MetroFramework.Controls.MetroTextBox();
            this.lblError = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(71, 120);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "AccountName";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(69, 171);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "AccountName";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(71, 239);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Description";
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(360, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(181, 235);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PromptText = "Enter Description";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(382, 23);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMark = "Enter Description";
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDebitAmount
            // 
            // 
            // 
            // 
            this.txtDebitAmount.CustomButton.Image = null;
            this.txtDebitAmount.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtDebitAmount.CustomButton.Name = "";
            this.txtDebitAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDebitAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDebitAmount.CustomButton.TabIndex = 1;
            this.txtDebitAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDebitAmount.CustomButton.UseSelectable = true;
            this.txtDebitAmount.CustomButton.Visible = false;
            this.txtDebitAmount.Lines = new string[0];
            this.txtDebitAmount.Location = new System.Drawing.Point(569, 118);
            this.txtDebitAmount.MaxLength = 32767;
            this.txtDebitAmount.Name = "txtDebitAmount";
            this.txtDebitAmount.PasswordChar = '\0';
            this.txtDebitAmount.PromptText = "Enter Debit Amount";
            this.txtDebitAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDebitAmount.SelectedText = "";
            this.txtDebitAmount.SelectionLength = 0;
            this.txtDebitAmount.SelectionStart = 0;
            this.txtDebitAmount.ShortcutsEnabled = true;
            this.txtDebitAmount.Size = new System.Drawing.Size(125, 23);
            this.txtDebitAmount.TabIndex = 7;
            this.txtDebitAmount.UseSelectable = true;
            this.txtDebitAmount.WaterMark = "Enter Debit Amount";
            this.txtDebitAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDebitAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDebitAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDebitAmount_KeyPress);
            // 
            // txtCredtiAmount
            // 
            // 
            // 
            // 
            this.txtCredtiAmount.CustomButton.Image = null;
            this.txtCredtiAmount.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtCredtiAmount.CustomButton.Name = "";
            this.txtCredtiAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCredtiAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCredtiAmount.CustomButton.TabIndex = 1;
            this.txtCredtiAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCredtiAmount.CustomButton.UseSelectable = true;
            this.txtCredtiAmount.CustomButton.Visible = false;
            this.txtCredtiAmount.Lines = new string[0];
            this.txtCredtiAmount.Location = new System.Drawing.Point(569, 174);
            this.txtCredtiAmount.MaxLength = 32767;
            this.txtCredtiAmount.Name = "txtCredtiAmount";
            this.txtCredtiAmount.PasswordChar = '\0';
            this.txtCredtiAmount.PromptText = "Enter Credit Amount";
            this.txtCredtiAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCredtiAmount.SelectedText = "";
            this.txtCredtiAmount.SelectionLength = 0;
            this.txtCredtiAmount.SelectionStart = 0;
            this.txtCredtiAmount.ShortcutsEnabled = true;
            this.txtCredtiAmount.Size = new System.Drawing.Size(125, 23);
            this.txtCredtiAmount.TabIndex = 8;
            this.txtCredtiAmount.UseSelectable = true;
            this.txtCredtiAmount.WaterMark = "Enter Credit Amount";
            this.txtCredtiAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCredtiAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCredtiAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCredtiAmount_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(700, 171);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Credit";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(700, 115);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(40, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Debit";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(426, 69);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(36, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Date";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(288, 311);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(127, 51);
            this.metroTile1.TabIndex = 12;
            this.metroTile1.Text = "ADD";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(122, 311);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(127, 51);
            this.metroTile2.TabIndex = 13;
            this.metroTile2.Text = "NEW ";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(453, 311);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(127, 51);
            this.metroTile3.TabIndex = 14;
            this.metroTile3.Text = "CLOSE";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(481, 63);
            this.dtDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(213, 29);
            this.dtDate.TabIndex = 15;
            // 
            // cmDebitAccount
            // 
            this.cmDebitAccount.FormattingEnabled = true;
            this.cmDebitAccount.ItemHeight = 23;
            this.cmDebitAccount.Location = new System.Drawing.Point(181, 117);
            this.cmDebitAccount.Name = "cmDebitAccount";
            this.cmDebitAccount.Size = new System.Drawing.Size(382, 29);
            this.cmDebitAccount.TabIndex = 16;
            this.cmDebitAccount.UseSelectable = true;
            // 
            // cmCreditAccount
            // 
            this.cmCreditAccount.FormattingEnabled = true;
            this.cmCreditAccount.ItemHeight = 23;
            this.cmCreditAccount.Location = new System.Drawing.Point(181, 171);
            this.cmCreditAccount.Name = "cmCreditAccount";
            this.cmCreditAccount.Size = new System.Drawing.Size(382, 29);
            this.cmCreditAccount.TabIndex = 17;
            this.cmCreditAccount.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(179, 69);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(67, 19);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Journal ID";
            // 
            // txtJournalId
            // 
            // 
            // 
            // 
            this.txtJournalId.CustomButton.Image = null;
            this.txtJournalId.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtJournalId.CustomButton.Name = "";
            this.txtJournalId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtJournalId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtJournalId.CustomButton.TabIndex = 1;
            this.txtJournalId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtJournalId.CustomButton.UseSelectable = true;
            this.txtJournalId.CustomButton.Visible = false;
            this.txtJournalId.Lines = new string[0];
            this.txtJournalId.Location = new System.Drawing.Point(252, 69);
            this.txtJournalId.MaxLength = 32767;
            this.txtJournalId.Name = "txtJournalId";
            this.txtJournalId.PasswordChar = '\0';
            this.txtJournalId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJournalId.SelectedText = "";
            this.txtJournalId.SelectionLength = 0;
            this.txtJournalId.SelectionStart = 0;
            this.txtJournalId.ShortcutsEnabled = true;
            this.txtJournalId.Size = new System.Drawing.Size(139, 23);
            this.txtJournalId.TabIndex = 19;
            this.txtJournalId.UseSelectable = true;
            this.txtJournalId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtJournalId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(616, 238);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 0);
            this.lblError.TabIndex = 20;
            this.lblError.Visible = false;
            // 
            // AddJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 385);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtJournalId);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.cmCreditAccount);
            this.Controls.Add(this.cmDebitAccount);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtCredtiAmount);
            this.Controls.Add(this.txtDebitAmount);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddJournal";
            this.Text = "AddJournal";
            this.Load += new System.EventHandler(this.AddJournal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroTextBox txtDebitAmount;
        private MetroFramework.Controls.MetroTextBox txtCredtiAmount;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroDateTime dtDate;
        private MetroFramework.Controls.MetroComboBox cmDebitAccount;
        private MetroFramework.Controls.MetroComboBox cmCreditAccount;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtJournalId;
        private MetroFramework.Controls.MetroLabel lblError;
    }
}