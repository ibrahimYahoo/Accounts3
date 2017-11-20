using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Forms.Purchase
{
    public partial class AsUpdateQty : MetroFramework.Forms.MetroForm
    {
        public static int btnselected = 2;
        public AsUpdateQty()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;


            if (clickedButton == null)
            {
                return;

            }

            if (clickedButton.Name == "btnYes")
            {
                btnselected = 0;
                this.Close();
            }
            else
            {
                btnselected = 1;
                this.Close();

            }

        }

        
    }
}
