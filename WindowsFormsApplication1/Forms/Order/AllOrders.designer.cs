namespace WindowsFormsApplication1.Forms
{
    partial class AllOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllOrders));
            this.btndelete = new MetroFramework.Controls.MetroTile();
            this.btnedit = new MetroFramework.Controls.MetroTile();
            this.btnadditem = new MetroFramework.Controls.MetroTile();
            this.btnback = new MetroFramework.Controls.MetroTile();
            this.lblmsg = new MetroFramework.Controls.MetroLabel();
            this.gvPurchase = new MetroFramework.Controls.MetroGrid();
            this.btnPrintDeliveryOrder = new MetroFramework.Controls.MetroTile();
            this.btnPrintInvoice = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.ActiveControl = null;
            this.btndelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btndelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btndelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btndelete.Location = new System.Drawing.Point(640, 645);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(98, 97);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndelete.TileImage = global::WindowsFormsApplication1.Properties.Resources.Delete_32px;
            this.btndelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndelete.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btndelete.UseCustomBackColor = true;
            this.btndelete.UseSelectable = true;
            this.btndelete.UseTileImage = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.ActiveControl = null;
            this.btnedit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnedit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnedit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnedit.Location = new System.Drawing.Point(536, 645);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(98, 97);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "Edit";
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnedit.TileImage = global::WindowsFormsApplication1.Properties.Resources.Edit_File_32px;
            this.btnedit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnedit.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnedit.UseCustomBackColor = true;
            this.btnedit.UseSelectable = true;
            this.btnedit.UseTileImage = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadditem
            // 
            this.btnadditem.ActiveControl = null;
            this.btnadditem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnadditem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnadditem.Location = new System.Drawing.Point(432, 645);
            this.btnadditem.Name = "btnadditem";
            this.btnadditem.Size = new System.Drawing.Size(98, 97);
            this.btnadditem.TabIndex = 0;
            this.btnadditem.Text = "Add Item";
            this.btnadditem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadditem.TileImage = global::WindowsFormsApplication1.Properties.Resources.Add_32px;
            this.btnadditem.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnadditem.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnadditem.UseCustomBackColor = true;
            this.btnadditem.UseSelectable = true;
            this.btnadditem.UseTileImage = true;
            this.btnadditem.Click += new System.EventHandler(this.btnadditem_Click);
            // 
            // btnback
            // 
            this.btnback.ActiveControl = null;
            this.btnback.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnback.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnback.Location = new System.Drawing.Point(744, 645);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(98, 97);
            this.btnback.TabIndex = 3;
            this.btnback.Text = "Back";
            this.btnback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnback.TileImage = global::WindowsFormsApplication1.Properties.Resources.Back_32px;
            this.btnback.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnback.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnback.UseCustomBackColor = true;
            this.btnback.UseSelectable = true;
            this.btnback.UseTileImage = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblmsg.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblmsg.ForeColor = System.Drawing.Color.White;
            this.lblmsg.Location = new System.Drawing.Point(484, 35);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 0);
            this.lblmsg.TabIndex = 107;
            this.lblmsg.UseCustomBackColor = true;
            this.lblmsg.UseCustomForeColor = true;
            // 
            // gvPurchase
            // 
            this.gvPurchase.AllowUserToAddRows = false;
            this.gvPurchase.AllowUserToOrderColumns = true;
            this.gvPurchase.AllowUserToResizeRows = false;
            this.gvPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gvPurchase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvPurchase.BackgroundColor = System.Drawing.Color.White;
            this.gvPurchase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvPurchase.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvPurchase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gvPurchase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPurchase.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvPurchase.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvPurchase.EnableHeadersVisualStyles = false;
            this.gvPurchase.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvPurchase.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvPurchase.Location = new System.Drawing.Point(23, 68);
            this.gvPurchase.MultiSelect = false;
            this.gvPurchase.Name = "gvPurchase";
            this.gvPurchase.ReadOnly = true;
            this.gvPurchase.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 1, 5, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPurchase.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvPurchase.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.gvPurchase.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvPurchase.RowTemplate.Height = 35;
            this.gvPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPurchase.Size = new System.Drawing.Size(1240, 521);
            this.gvPurchase.TabIndex = 108;
            this.gvPurchase.UseCustomBackColor = true;
            this.gvPurchase.UseCustomForeColor = true;
            this.gvPurchase.UseStyleColors = true;
            this.gvPurchase.SelectionChanged += new System.EventHandler(this.gvPurchase_SelectionChanged);
            // 
            // btnPrintDeliveryOrder
            // 
            this.btnPrintDeliveryOrder.ActiveControl = null;
            this.btnPrintDeliveryOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrintDeliveryOrder.Location = new System.Drawing.Point(848, 645);
            this.btnPrintDeliveryOrder.Name = "btnPrintDeliveryOrder";
            this.btnPrintDeliveryOrder.Size = new System.Drawing.Size(105, 97);
            this.btnPrintDeliveryOrder.TabIndex = 189;
            this.btnPrintDeliveryOrder.Text = "DELIVERY\r\nORDER\r\n";
            this.btnPrintDeliveryOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrintDeliveryOrder.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPrintDeliveryOrder.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintDeliveryOrder.UseSelectable = true;
            this.btnPrintDeliveryOrder.Click += new System.EventHandler(this.btnPrintDeliveryOrder_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.ActiveControl = null;
            this.btnPrintInvoice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrintInvoice.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnPrintInvoice.Location = new System.Drawing.Point(959, 645);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(109, 97);
            this.btnPrintInvoice.TabIndex = 190;
            this.btnPrintInvoice.Text = "PRINT\r\nINVOICE\r\n";
            this.btnPrintInvoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrintInvoice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPrintInvoice.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintInvoice.UseSelectable = true;
            this.btnPrintInvoice.UseTileImage = true;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // AllOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 768);
            this.Controls.Add(this.btnPrintInvoice);
            this.Controls.Add(this.btnPrintDeliveryOrder);
            this.Controls.Add(this.gvPurchase);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadditem);
            this.Controls.Add(this.btnback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllOrders";
            this.Text = "Orders";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Purchases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile btnback;
        private MetroFramework.Controls.MetroTile btnadditem;
        private MetroFramework.Controls.MetroTile btndelete;
        private MetroFramework.Controls.MetroTile btnedit;
        private MetroFramework.Controls.MetroLabel lblmsg;
        public MetroFramework.Controls.MetroGrid gvPurchase;
        private MetroFramework.Controls.MetroTile btnPrintDeliveryOrder;
        private MetroFramework.Controls.MetroTile btnPrintInvoice;
    }
}