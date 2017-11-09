namespace WindowsFormsApplication1.Forms
{
    partial class Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.gvStock = new MetroFramework.Controls.MetroGrid();
            this.lblmsg = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnback = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gvStock
            // 
            this.gvStock.AllowUserToAddRows = false;
            this.gvStock.AllowUserToOrderColumns = true;
            this.gvStock.AllowUserToResizeRows = false;
            this.gvStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvStock.BackgroundColor = System.Drawing.Color.White;
            this.gvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvStock.EnableHeadersVisualStyles = false;
            this.gvStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvStock.Location = new System.Drawing.Point(23, 104);
            this.gvStock.MultiSelect = false;
            this.gvStock.Name = "gvStock";
            this.gvStock.ReadOnly = true;
            this.gvStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 1, 5, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.gvStock.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvStock.RowTemplate.Height = 35;
            this.gvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvStock.Size = new System.Drawing.Size(1214, 498);
            this.gvStock.TabIndex = 109;
            this.gvStock.UseCustomBackColor = true;
            this.gvStock.UseCustomForeColor = true;
            this.gvStock.UseStyleColors = true;
            this.gvStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStock_CellContentClick);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblmsg.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblmsg.ForeColor = System.Drawing.Color.White;
            this.lblmsg.Location = new System.Drawing.Point(406, 35);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 0);
            this.lblmsg.TabIndex = 107;
            this.lblmsg.UseCustomBackColor = true;
            this.lblmsg.UseCustomForeColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.umbra_logo_small;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(1171, 677);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(66, 66);
            this.panel1.TabIndex = 193;
            // 
            // btnback
            // 
            this.btnback.ActiveControl = null;
            this.btnback.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnback.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnback.Location = new System.Drawing.Point(768, 645);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(116, 92);
            this.btnback.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnback.TabIndex = 68;
            this.btnback.Text = "Back";
            this.btnback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnback.TileImage = global::WindowsFormsApplication1.Properties.Resources.Back_32px;
            this.btnback.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnback.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnback.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnback.UseCustomBackColor = true;
            this.btnback.UseSelectable = true;
            this.btnback.UseTileImage = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroTile5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroTile5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroTile5.Location = new System.Drawing.Point(646, 645);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(116, 92);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile5.TabIndex = 10;
            this.metroTile5.Text = "Export Data";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile5.TileImage = global::WindowsFormsApplication1.Properties.Resources.icons8_Fine_Print_32;
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile5.UseCustomBackColor = true;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseTileImage = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroTile3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroTile3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroTile3.Location = new System.Drawing.Point(527, 645);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(116, 92);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile3.TabIndex = 8;
            this.metroTile3.Text = "Delete";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.TileImage = global::WindowsFormsApplication1.Properties.Resources.Delete_32px;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile3.UseCustomBackColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroTile2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroTile2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroTile2.Location = new System.Drawing.Point(405, 645);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(116, 92);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile2.TabIndex = 7;
            this.metroTile2.Text = "Edit";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImage = global::WindowsFormsApplication1.Properties.Resources.Edit_File_32px;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 766);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gvStock);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stock";
            this.Text = "Stock";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private pmsDataSet1TableAdapters.ItemsTableAdapter itemsTableAdapter;
        private MetroFramework.Controls.MetroTile btnback;
        private MetroFramework.Controls.MetroLabel lblmsg;
        public MetroFramework.Controls.MetroGrid gvStock;
        private System.Windows.Forms.Panel panel1;
    }
}