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
        SingleTonUserRoles userRolesObj = SingleTonUserRoles.GetInstance;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

            frmCustomer frmObj = new frmCustomer();
            this.TopLevel = true;
            TabPage tabpage = new TabPage();
            tabpage.Text = " Customers ";
            // frmObj.TopLevel = true;

            //  tabpage.BorderStyle = BorderStyle;
            tc.TabPages.Add(tabpage);
          
            frmObj.TopLevel = false;
            frmObj.MdiParent = this;
            // frmObj.WindowState = FormWindowState.Maximized;
            tabpage.AutoScroll = true;
            frmObj.BringToFront();

            frmObj.Parent = tabpage;
            frmObj.Show();




            frmBroker BrObj = new frmBroker();
            this.TopLevel = true;
            TabPage tabpage3 = new TabPage();
            tabpage3.Text = " Broker ";
            // frmObj.TopLevel = true;

            //  tabpage.BorderStyle = BorderStyle;
            tc.TabPages.Add(tabpage3);

            BrObj.TopLevel = false;
            BrObj.MdiParent = this;
           // BrObj.WindowState = FormWindowState.Maximized;
            BrObj.BringToFront();

            BrObj.Parent = tabpage3;
            BrObj.Show();

            UserManagement UMObj = new UserManagement();
            this.TopLevel = true;
            TabPage tabpage4 = new TabPage();
            tabpage4.Text = " User Managment ";
            // frmObj.TopLevel = true;

            //  tabpage.BorderStyle = BorderStyle;
            tc.TabPages.Add(tabpage4);

            UMObj.TopLevel = false;
            UMObj.MdiParent = this;
           // UMObj.WindowState = FormWindowState.Maximized;
            UMObj.BringToFront();

            UMObj.Parent = tabpage4;
            UMObj.Show();


            AccountChart AcObj = new AccountChart();
            this.TopLevel = true;
            TabPage tabpage2 = new TabPage();
            tabpage2.Text = " Account Chart ";
            // frmObj.TopLevel = true;

            //  tabpage.BorderStyle = BorderStyle;
            tc.TabPages.Add(tabpage2);

            AcObj.TopLevel = false;
            AcObj.MdiParent = this;
          //  AcObj.WindowState = FormWindowState.Maximized;
            AcObj.BringToFront();

            AcObj.Parent = tabpage2;
            AcObj.Show();




        }



        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (userRolesObj.getCheckstate("ViewParties") == true)
            {
                frmCustomer frmObj = new frmCustomer();
                this.TopLevel = true;
                TabPage tabpage = new TabPage();
                tabpage.Text = " Customers ";
                // frmObj.TopLevel = true;

              //  tabpage.BorderStyle = BorderStyle;
                tc.TabPages.Add(tabpage);

                frmObj.TopLevel = false;
                frmObj.MdiParent = this;
                frmObj.WindowState = FormWindowState.Maximized;
                frmObj.BringToFront();

                frmObj.Parent = tabpage;
                frmObj.Show();

                //this.Hide();
                //frmCustomer OBJ = new frmCustomer();
                //OBJ.Show();
                //OBJ.WindowState = FormWindowState.Maximized;
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

            if(userRolesObj.getCheckstate("ViewAccountChart") == true)
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

            if(userRolesObj.getCheckstate("ViewBrokers") == true)
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
