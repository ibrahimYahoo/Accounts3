using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Forms.MainPage
{
    public partial class Main2 : Form
    {
        public Main2()
        {
            InitializeComponent();
        }

        private void Main2_Load(object sender, EventArgs e)
        {
            Main frmObj = new Main();
            this.TopLevel = true;
            TabPage tabpage = new TabPage();
            tabpage.Text = "Main";
           // frmObj.TopLevel = true;

            tabpage.BorderStyle = BorderStyle.None;
            tc.TabPages.Add(tabpage);

            frmObj.TopLevel = false;
            frmObj.MdiParent = this;
            frmObj.WindowState = FormWindowState.Maximized;
            frmObj.BringToFront();

            frmObj.Parent = tabpage;
            frmObj.Show();

        }
    }
}
