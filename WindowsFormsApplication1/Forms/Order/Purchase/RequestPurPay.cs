using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Forms.Cashbook;

namespace WindowsFormsApplication1.Forms.Purchase
{
    public partial class RequestPurPay : MetroFramework.Forms.MetroForm
    {
        public RequestPurPay()
        {
            InitializeComponent();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
            AddPayment obj = new AddPayment();
            obj.Show();
        }
    }
}
