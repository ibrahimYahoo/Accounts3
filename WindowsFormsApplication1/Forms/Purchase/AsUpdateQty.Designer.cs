namespace WindowsFormsApplication1.Forms.Purchase
{
    partial class AsUpdateQty
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
            this.btnYes = new MetroFramework.Controls.MetroTile();
            this.btnNo = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(331, 95);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "A lot No already exists with this Number , Do you want \r\nto add Quantity to this " +
    "existing LotNo? \r\nClick Yes to update Quantity \r\nClick No to Change LotNo\r\n";
            // 
            // btnYes
            // 
            this.btnYes.ActiveControl = null;
            this.btnYes.Location = new System.Drawing.Point(89, 191);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 37);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "YES";
            this.btnYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnYes.UseSelectable = true;
            this.btnYes.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // btnNo
            // 
            this.btnNo.ActiveControl = null;
            this.btnNo.Location = new System.Drawing.Point(196, 191);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 37);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "NO";
            this.btnNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNo.UseSelectable = true;
            this.btnNo.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // AsUpdateQty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 251);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AsUpdateQty";
            this.Text = "Update Quantity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile btnYes;
        private MetroFramework.Controls.MetroTile btnNo;
    }
}