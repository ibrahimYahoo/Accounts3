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
            this.Close();
            
        }
    }
}
