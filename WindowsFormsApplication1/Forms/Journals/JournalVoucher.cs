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
using WindowsFormsApplication1.Forms.Journals;

namespace WindowsFormsApplication1.Forms
{
    public partial class JournalVoucher : MetroFramework.Forms.MetroForm
    {
        DataTable dt = new DAO().getRoles(Login.RoleId);

        public JournalVoucher()
        {
            InitializeComponent();
        }

        private void JournalVoucher_Load(object sender, EventArgs e)
        {
            gvJournals.DataSource = new DAO().GetJournals();


        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (bool.Parse(dt.Rows[0]["AddJournalEntry"].ToString()) == true)
            {
                AddJournal obj = new AddJournal();
                obj.Show();
            }
            else
            {
                MessageBox.Show("you don't have permission to enter here, Contact admin For further Details");
                return;
            }

            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            gvJournals.DataSource = new DAO().GetJournals();

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Close();
            Main obj = new Main();
            obj.Show();
        }
    }
}
