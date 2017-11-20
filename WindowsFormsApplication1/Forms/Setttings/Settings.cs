using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Code;
using WindowsFormsApplication1.Forms.Setttings;

namespace WindowsFormsApplication1.Forms
{
    public partial class Settings : MetroFramework.Forms.MetroForm
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {



            

        }

        

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomer OBJ = new frmCustomer();
            OBJ.Show();
            OBJ.WindowState = FormWindowState.Maximized;
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main OBJ = new Main();
            OBJ.Show();
            OBJ.WindowState = FormWindowState.Maximized;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountChart obj = new AccountChart();
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBroker obj = new frmBroker();
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagement obj = new UserManagement();
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }
    }
}
