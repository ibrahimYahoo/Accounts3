namespace WindowsFormsApplication1.Forms.Setttings
{
    partial class AccountChart
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
            this.gvAccountChart = new System.Windows.Forms.DataGridView();
            this.btnExpense = new MetroFramework.Controls.MetroTile();
            this.btnLiability = new MetroFramework.Controls.MetroTile();
            this.btnAsset = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.lblconfirm = new MetroFramework.Controls.MetroLabel();
            this.btnIncome = new MetroFramework.Controls.MetroTile();
            this.gbAddAccount = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnAddAccName = new MetroFramework.Controls.MetroTile();
            this.txtAccounName = new System.Windows.Forms.RichTextBox();
            this.cmDetailType = new MetroFramework.Controls.MetroComboBox();
            this.lblAccHeader = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvAccountChart)).BeginInit();
            this.gbAddAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvAccountChart
            // 
            this.gvAccountChart.AllowUserToAddRows = false;
            this.gvAccountChart.AllowUserToDeleteRows = false;
            this.gvAccountChart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvAccountChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAccountChart.Location = new System.Drawing.Point(46, 116);
            this.gvAccountChart.Name = "gvAccountChart";
            this.gvAccountChart.ReadOnly = true;
            this.gvAccountChart.Size = new System.Drawing.Size(448, 481);
            this.gvAccountChart.TabIndex = 0;
            this.gvAccountChart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnExpense
            // 
            this.btnExpense.ActiveControl = null;
            this.btnExpense.Location = new System.Drawing.Point(982, 355);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(180, 51);
            this.btnExpense.TabIndex = 1;
            this.btnExpense.Text = "Add Expense";
            this.btnExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExpense.UseSelectable = true;
            this.btnExpense.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // btnLiability
            // 
            this.btnLiability.ActiveControl = null;
            this.btnLiability.Location = new System.Drawing.Point(982, 204);
            this.btnLiability.Name = "btnLiability";
            this.btnLiability.Size = new System.Drawing.Size(180, 51);
            this.btnLiability.TabIndex = 3;
            this.btnLiability.Text = "Add Liabiality/ CreditCard";
            this.btnLiability.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLiability.UseSelectable = true;
            this.btnLiability.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // btnAsset
            // 
            this.btnAsset.ActiveControl = null;
            this.btnAsset.Location = new System.Drawing.Point(982, 280);
            this.btnAsset.Name = "btnAsset";
            this.btnAsset.Size = new System.Drawing.Size(180, 51);
            this.btnAsset.TabIndex = 4;
            this.btnAsset.Text = "Add ASSET";
            this.btnAsset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAsset.UseSelectable = true;
            this.btnAsset.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(1115, 37);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(150, 51);
            this.metroTile5.TabIndex = 5;
            this.metroTile5.Text = "BACK";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // lblconfirm
            // 
            this.lblconfirm.AutoSize = true;
            this.lblconfirm.Location = new System.Drawing.Point(664, 495);
            this.lblconfirm.Name = "lblconfirm";
            this.lblconfirm.Size = new System.Drawing.Size(0, 0);
            this.lblconfirm.TabIndex = 9;
            // 
            // btnIncome
            // 
            this.btnIncome.ActiveControl = null;
            this.btnIncome.Location = new System.Drawing.Point(982, 426);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(180, 51);
            this.btnIncome.TabIndex = 2;
            this.btnIncome.Text = "Add Income";
            this.btnIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIncome.UseSelectable = true;
            this.btnIncome.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // gbAddAccount
            // 
            this.gbAddAccount.Controls.Add(this.lblAccHeader);
            this.gbAddAccount.Controls.Add(this.cmDetailType);
            this.gbAddAccount.Controls.Add(this.metroLabel3);
            this.gbAddAccount.Controls.Add(this.metroLabel2);
            this.gbAddAccount.Controls.Add(this.btnAddAccName);
            this.gbAddAccount.Controls.Add(this.txtAccounName);
            this.gbAddAccount.Location = new System.Drawing.Point(513, 243);
            this.gbAddAccount.Name = "gbAddAccount";
            this.gbAddAccount.Size = new System.Drawing.Size(422, 272);
            this.gbAddAccount.TabIndex = 13;
            this.gbAddAccount.TabStop = false;
            this.gbAddAccount.Text = "Add Account";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(36, 144);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(92, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "AccountName";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(36, 84);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Detail Type";
            // 
            // btnAddAccName
            // 
            this.btnAddAccName.ActiveControl = null;
            this.btnAddAccName.Location = new System.Drawing.Point(269, 200);
            this.btnAddAccName.Name = "btnAddAccName";
            this.btnAddAccName.Size = new System.Drawing.Size(118, 43);
            this.btnAddAccName.TabIndex = 14;
            this.btnAddAccName.Text = "ADD";
            this.btnAddAccName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddAccName.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAddAccName.UseSelectable = true;
            this.btnAddAccName.Visible = false;
            this.btnAddAccName.Click += new System.EventHandler(this.btnAddAccName_Click);
            // 
            // txtAccounName
            // 
            this.txtAccounName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccounName.Location = new System.Drawing.Point(160, 135);
            this.txtAccounName.Name = "txtAccounName";
            this.txtAccounName.Size = new System.Drawing.Size(227, 37);
            this.txtAccounName.TabIndex = 13;
            this.txtAccounName.Text = "";
            this.txtAccounName.Visible = false;
            // 
            // cmDetailType
            // 
            this.cmDetailType.FormattingEnabled = true;
            this.cmDetailType.ItemHeight = 23;
            this.cmDetailType.Location = new System.Drawing.Point(160, 74);
            this.cmDetailType.Name = "cmDetailType";
            this.cmDetailType.Size = new System.Drawing.Size(227, 29);
            this.cmDetailType.TabIndex = 18;
            this.cmDetailType.UseSelectable = true;
            this.cmDetailType.Visible = false;
            // 
            // lblAccHeader
            // 
            this.lblAccHeader.AutoSize = true;
            this.lblAccHeader.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAccHeader.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAccHeader.Location = new System.Drawing.Point(160, 16);
            this.lblAccHeader.Name = "lblAccHeader";
            this.lblAccHeader.Size = new System.Drawing.Size(0, 0);
            this.lblAccHeader.TabIndex = 19;
            this.lblAccHeader.Visible = false;
            // 
            // AccountChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 597);
            this.Controls.Add(this.gbAddAccount);
            this.Controls.Add(this.lblconfirm);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.btnAsset);
            this.Controls.Add(this.btnLiability);
            this.Controls.Add(this.btnIncome);
            this.Controls.Add(this.btnExpense);
            this.Controls.Add(this.gvAccountChart);
            this.Name = "AccountChart";
            this.Text = "AccountChart";
            this.Load += new System.EventHandler(this.AccountChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAccountChart)).EndInit();
            this.gbAddAccount.ResumeLayout(false);
            this.gbAddAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvAccountChart;
        private MetroFramework.Controls.MetroTile btnExpense;
        private MetroFramework.Controls.MetroTile btnLiability;
        private MetroFramework.Controls.MetroTile btnAsset;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroLabel lblconfirm;
        private MetroFramework.Controls.MetroTile btnIncome;
        private System.Windows.Forms.GroupBox gbAddAccount;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile btnAddAccName;
        private System.Windows.Forms.RichTextBox txtAccounName;
        private MetroFramework.Controls.MetroComboBox cmDetailType;
        private MetroFramework.Controls.MetroLabel lblAccHeader;
    }
}