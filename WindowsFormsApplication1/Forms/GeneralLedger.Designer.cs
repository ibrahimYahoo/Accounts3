namespace WindowsFormsApplication1.Forms
{
    partial class GeneralLedger
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmGLAccountName = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.datStartDate = new MetroFramework.Controls.MetroDateTime();
            this.datEndDate = new MetroFramework.Controls.MetroDateTime();
            this.BtnSearch = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.gvGlTransaction = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvGlTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Account Name";
            // 
            // cmGLAccountName
            // 
            this.cmGLAccountName.FormattingEnabled = true;
            this.cmGLAccountName.Location = new System.Drawing.Point(142, 93);
            this.cmGLAccountName.Name = "cmGLAccountName";
            this.cmGLAccountName.Size = new System.Drawing.Size(165, 21);
            this.cmGLAccountName.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(360, 93);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "DateFrom";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(360, 140);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "DateTo";
            // 
            // datStartDate
            // 
            this.datStartDate.Location = new System.Drawing.Point(449, 93);
            this.datStartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.datStartDate.Name = "datStartDate";
            this.datStartDate.Size = new System.Drawing.Size(200, 29);
            this.datStartDate.TabIndex = 4;
            // 
            // datEndDate
            // 
            this.datEndDate.Location = new System.Drawing.Point(449, 140);
            this.datEndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.datEndDate.Name = "datEndDate";
            this.datEndDate.Size = new System.Drawing.Size(200, 29);
            this.datEndDate.TabIndex = 5;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(705, 93);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(104, 31);
            this.BtnSearch.TabIndex = 6;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseSelectable = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1088, 33);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(101, 50);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "BACK";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // gvGlTransaction
            // 
            this.gvGlTransaction.AllowUserToAddRows = false;
            this.gvGlTransaction.AllowUserToDeleteRows = false;
            this.gvGlTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvGlTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvGlTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGlTransaction.Location = new System.Drawing.Point(39, 194);
            this.gvGlTransaction.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.gvGlTransaction.Name = "gvGlTransaction";
            this.gvGlTransaction.ReadOnly = true;
            this.gvGlTransaction.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvGlTransaction.RowTemplate.Height = 27;
            this.gvGlTransaction.Size = new System.Drawing.Size(770, 410);
            this.gvGlTransaction.TabIndex = 9;
            // 
            // GeneralLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 591);
            this.Controls.Add(this.gvGlTransaction);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.datEndDate);
            this.Controls.Add(this.datStartDate);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmGLAccountName);
            this.Controls.Add(this.metroLabel1);
            this.Name = "GeneralLedger";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 2);
            this.Text = "GeneralLedger";
            this.Load += new System.EventHandler(this.GeneralLedger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvGlTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox cmGLAccountName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime datStartDate;
        private MetroFramework.Controls.MetroDateTime datEndDate;
        private MetroFramework.Controls.MetroButton BtnSearch;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridView gvGlTransaction;
    }
}