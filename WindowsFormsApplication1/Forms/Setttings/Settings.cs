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
        DataTable dt = new DAO().getRoles(Login.RoleId);

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {



            

        }

        

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (bool.Parse(dt.Rows[0]["ViewParties"].ToString()) == true)
            {
                this.Hide();
                frmCustomer OBJ = new frmCustomer();
                OBJ.Show();
                OBJ.WindowState = FormWindowState.Maximized;
            }
            else
            {
                MessageBox.Show("you don't have permission to enter here, Contact admin For further Details");
                return;
            }
           
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Main OBJ = new Main();
            OBJ.Show();
            this.Hide();

            OBJ.WindowState = FormWindowState.Maximized;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (bool.Parse(dt.Rows[0]["ViewAccountChart"].ToString()) == true)
            {
                AccountChart obj = new AccountChart();
                obj.Show();
                this.Hide();

                obj.WindowState = FormWindowState.Maximized;
            }
            else
            {
                MessageBox.Show("you don't have permission to enter here, Contact admin For further Details");
                return;
            }

            

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

            if (bool.Parse(dt.Rows[0]["ViewBrokers"].ToString()) == true)
            {
                frmBroker obj = new frmBroker();
                obj.Show();
                this.Hide();

                obj.WindowState = FormWindowState.Maximized;
            }
            else
            {
                MessageBox.Show("you don't have permission to enter here, Contact admin For further Details");
                return;
            }
           

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            if(Login.username == "Admin")
            {

                this.Hide();
                UserManagement obj = new UserManagement();
                obj.Show();
                obj.WindowState = FormWindowState.Maximized;

            }
            else
            {
                MessageBox.Show("you don't have permission to enter here, Contact admin For further Details");
                return;
            }


        }
    }
}
