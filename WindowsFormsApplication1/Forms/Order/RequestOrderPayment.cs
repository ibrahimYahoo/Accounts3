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

namespace WindowsFormsApplication1.Forms.Order
{
    public partial class RequestOrderPayment : MetroFramework.Forms.MetroForm

    {
        public RequestOrderPayment()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            CashBook obj2 = new CashBook();
            this.Close();
            AddReciept obj = new AddReciept(obj2);
            obj.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
