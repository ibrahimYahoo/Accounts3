namespace WindowsFormsApplication1.Forms
{
    partial class transactions
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
            MetroFramework.Controls.MetroLabel metroLabel2;
            MetroFramework.Controls.MetroLabel metroLabel3;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.gvTransactions = new MetroFramework.Controls.MetroGrid();
            this.txtPartyName = new MetroFramework.Controls.MetroTextBox();
            this.btnback = new MetroFramework.Controls.MetroTile();
            this.lblPartyBalance = new MetroFramework.Controls.MetroLabel();
            this.lblCompanyBalance = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel2.Location = new System.Drawing.Point(112, 603);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new System.Drawing.Size(130, 25);
            metroLabel2.TabIndex = 89;
            metroLabel2.Text = "Party Balance";
            metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel3
            // 
            metroLabel3.AutoSize = true;
            metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel3.Location = new System.Drawing.Point(112, 656);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new System.Drawing.Size(164, 25);
            metroLabel3.TabIndex = 90;
            metroLabel3.Text = "Company Balance";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(24, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Search Party";
            // 
            // gvTransactions
            // 
            this.gvTransactions.AllowUserToAddRows = false;
            this.gvTransactions.AllowUserToDeleteRows = false;
            this.gvTransactions.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            this.gvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTransactions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvTransactions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvTransactions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gvTransactions.ColumnHeadersHeight = 25;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvTransactions.DefaultCellStyle = dataGridViewCellStyle11;
            this.gvTransactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvTransactions.EnableHeadersVisualStyles = false;
            this.gvTransactions.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvTransactions.Location = new System.Drawing.Point(24, 96);
            this.gvTransactions.Name = "gvTransactions";
            this.gvTransactions.ReadOnly = true;
            this.gvTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gvTransactions.RowHeadersWidth = 60;
            this.gvTransactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvTransactions.RowTemplate.Height = 30;
            this.gvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTransactions.Size = new System.Drawing.Size(962, 485);
            this.gvTransactions.TabIndex = 1;
            // 
            // txtPartyName
            // 
            // 
            // 
            // 
            this.txtPartyName.CustomButton.Image = null;
            this.txtPartyName.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtPartyName.CustomButton.Name = "";
            this.txtPartyName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPartyName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPartyName.CustomButton.TabIndex = 1;
            this.txtPartyName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPartyName.CustomButton.UseSelectable = true;
            this.txtPartyName.CustomButton.Visible = false;
            this.txtPartyName.Lines = new string[0];
            this.txtPartyName.Location = new System.Drawing.Point(134, 64);
            this.txtPartyName.MaxLength = 32767;
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.PasswordChar = '\0';
            this.txtPartyName.PromptText = "Enter Party Name";
            this.txtPartyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPartyName.SelectedText = "";
            this.txtPartyName.SelectionLength = 0;
            this.txtPartyName.SelectionStart = 0;
            this.txtPartyName.ShortcutsEnabled = true;
            this.txtPartyName.Size = new System.Drawing.Size(174, 23);
            this.txtPartyName.TabIndex = 2;
            this.txtPartyName.UseSelectable = true;
            this.txtPartyName.WaterMark = "Enter Party Name";
            this.txtPartyName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPartyName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPartyName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPartyName_KeyUp);
            // 
            // btnback
            // 
            this.btnback.ActiveControl = null;
            this.btnback.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnback.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnback.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnback.Location = new System.Drawing.Point(691, 614);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(98, 92);
            this.btnback.TabIndex = 87;
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
            // lblPartyBalance
            // 
            this.lblPartyBalance.AutoSize = true;
            this.lblPartyBalance.Location = new System.Drawing.Point(284, 603);
            this.lblPartyBalance.Name = "lblPartyBalance";
            this.lblPartyBalance.Size = new System.Drawing.Size(0, 0);
            this.lblPartyBalance.TabIndex = 91;
            // 
            // lblCompanyBalance
            // 
            this.lblCompanyBalance.AutoSize = true;
            this.lblCompanyBalance.Location = new System.Drawing.Point(284, 662);
            this.lblCompanyBalance.Name = "lblCompanyBalance";
            this.lblCompanyBalance.Size = new System.Drawing.Size(0, 0);
            this.lblCompanyBalance.TabIndex = 92;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.umbra_logo_small;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(919, 640);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(66, 66);
            this.panel1.TabIndex = 193;
            // 
            // transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCompanyBalance);
            this.Controls.Add(this.lblPartyBalance);
            this.Controls.Add(metroLabel3);
            this.Controls.Add(metroLabel2);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txtPartyName);
            this.Controls.Add(this.gvTransactions);
            this.Controls.Add(this.metroLabel1);
            this.Name = "transactions";
            this.Text = "transactions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid gvTransactions;
        private MetroFramework.Controls.MetroTextBox txtPartyName;
        private MetroFramework.Controls.MetroTile btnback;
        private MetroFramework.Controls.MetroLabel lblPartyBalance;
        private MetroFramework.Controls.MetroLabel lblCompanyBalance;
        private System.Windows.Forms.Panel panel1;
    }
}