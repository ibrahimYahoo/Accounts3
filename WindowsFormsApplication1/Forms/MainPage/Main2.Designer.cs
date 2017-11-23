namespace WindowsFormsApplication1.Forms.MainPage
{
    partial class Main2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main2));
            this.tc = new MetroFramework.Controls.MetroTabControl();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc.Location = new System.Drawing.Point(0, 46);
            this.tc.Margin = new System.Windows.Forms.Padding(0);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(1278, 572);
            this.tc.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tc.TabIndex = 2;
            this.tc.UseSelectable = true;
            // 
            // Main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1274, 621);
            this.Controls.Add(this.tc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main2";
            this.Text = "Main2";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Main2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tc;
    }
}