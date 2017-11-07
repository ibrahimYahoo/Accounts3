﻿using MetroFramework;
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
        


        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            //bool IsOpen = false;
            //FormCollection fc = Application.OpenForms;

            //foreach (Form f in fc)
            //{

            //    if (f.Name == "Stock")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}

            //if (IsOpen == true)
            //{
                
            //}

            //this.Hide();
            //Home f1obj = new Home();
            //this.Hide();
            Forms.Stock ac = new Forms.Stock();
            ac.WindowState = FormWindowState.Maximized;

            ac.Show();
            this.Hide();

            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            //bool IsOpen = false;
            //FormCollection fc = Application.OpenForms;

            //foreach (Form f in fc)
            //{

            //    if (f.Name == "AddOrder")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}

            //if (IsOpen == true)
            //{
            //    AddOrder addorder = new AddOrder();
            //    addorder.Show();
            //    addorder.WindowState = FormWindowState.Maximized;
            //}

            //this.Hide();
            //Home f1obj = new Home();
            AllOrders addorder = new AllOrders();
            addorder.WindowState = FormWindowState.Maximized;
            addorder.Show();
            this.Hide();
            //this.Hide();

            

        }

        private void metroTile8_Click(object sender, EventArgs e)
        {

            Forms.Purchase.Purchases ac = new Purchases();
            ac.WindowState = FormWindowState.Maximized;

            ac.Show();
            this.Hide();

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

            CashBook ac = new CashBook();
            ac.WindowState = FormWindowState.Maximized;

            ac.Show();
            this.Hide();

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
            JournalVoucher JvObj = new JournalVoucher();
            JvObj.WindowState = FormWindowState.Maximized;

            JvObj.Show();
            this.Hide();


        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            GeneralLedger glObj = new GeneralLedger();
            glObj.WindowState = FormWindowState.Maximized;

            glObj.Show();
            this.Hide();



        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            Settings glObj = new Settings();
            glObj.WindowState = FormWindowState.Maximized;

            glObj.Show();
            this.Hide();

        }
    }
}
