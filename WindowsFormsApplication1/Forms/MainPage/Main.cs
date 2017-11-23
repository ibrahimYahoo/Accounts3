using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Code;
using WindowsFormsApplication1.Forms;
using WindowsFormsApplication1.Forms.Accounts;
using WindowsFormsApplication1.Forms.GeneralLedgerFol;
using WindowsFormsApplication1.Forms.Order;
using WindowsFormsApplication1.Forms.Purchase;
using WindowsFormsApplication1.Forms.Search;

namespace WindowsFormsApplication1
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {

        SingleTonUserRoles userRolesObj = SingleTonUserRoles.GetInstance;
        




        public Main()
        {
     //       this.MdiParent = this;
            //this.WindowState = FormWindowState.Maximized;
            //this.BringToFront();
            //this.Show();
            this.TopLevel = true;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
           
            if(userRolesObj.getCheckstate("ViewStock") == true)
            {
                Forms.Stock ac = new Forms.Stock();
                ac.WindowState = FormWindowState.Maximized;

                ac.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("you don't have permission to enter here, Contact admin For further Details");
                return;
            }


        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            
            if (userRolesObj.getCheckstate("ViewOrders") == true)
            {
                AllOrders addorder = new AllOrders();
                addorder.WindowState = FormWindowState.Maximized;
                addorder.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("you don't have permission to enter here, Contact admin For further Details");
                return;
            }



            //this.Hide();

            

        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            if (userRolesObj.getCheckstate("ViewPurchases") == true)
            {
                
                Forms.Purchase.Purchases ac = new Purchases();
                ac.WindowState = FormWindowState.Maximized;

                ac.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("you don't have permission to enter here, Contact admin For further Details");
                return;
            }

            

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

            frmCustomer ac = new frmCustomer();
            ac.WindowState = FormWindowState.Maximized;

            ac.Show();
            this.Hide();

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

            frmSuppliers ac = new frmSuppliers();
            ac.WindowState = FormWindowState.Maximized;

            ac.Show();
            this.Hide();

        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            if(userRolesObj.getCheckstate("ViewCashBook") == true)
            {
                CashBook ac = new CashBook();
                ac.WindowState = FormWindowState.Maximized;

                ac.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("you don't have permission to enter here, Contact admin For further Details");
                return;
            }
           
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {


            frmAccounts fa = new frmAccounts();
            fa.WindowState = FormWindowState.Maximized;

            fa.Show();
            this.Hide();

        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmSearch search = new frmSearch();
            search.Show();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            Login.count++; 
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }

        
        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            transactions transObj = new transactions();
            transObj.Show();
          

        }

        private void metroTile3_Click_1(object sender, EventArgs e)
        {

            if(userRolesObj.getCheckstate("ViewJournals") == true)
            {
                JournalVoucher JvObj = new JournalVoucher();
                JvObj.WindowState = FormWindowState.Maximized;

                JvObj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("you don't have permission to enter here, Contact admin For further Details");
                return;
            }

            


        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            

            if(userRolesObj.getCheckstate("ViewGeneralLedger") == true)
            {
                GeneralLedger glObj = new GeneralLedger();
                glObj.WindowState = FormWindowState.Maximized;

                glObj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("you don't have permission to enter here, Contact admin For further Details");
                return;
            }


            



        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            if(userRolesObj.getCheckstate("Settings") == true)
            {
                Settings glObj = new Settings();
                glObj.WindowState = FormWindowState.Maximized;

                glObj.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("you don't have permission to enter here, Contact admin For further Details");
                return;
            }
            
        }
    }
}
