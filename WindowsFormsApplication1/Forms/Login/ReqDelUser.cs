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
    public partial class ReqDelUser : MetroFramework.Forms.MetroForm
    {
        public static bool del = false;

        UserManagement owner;
        public ReqDelUser(UserManagement frm1 )
        {
            owner = frm1;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPurchase_FormClosing);

            InitializeComponent();
        }

        private void AddPurchase_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.PerformRefresh();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(btn.Text == "YES")
            {
                new DAO().RemoveUserAndRoles(UserManagement.RoleId);
                del = true;
            }
            this.Close();


        }
    }
}
