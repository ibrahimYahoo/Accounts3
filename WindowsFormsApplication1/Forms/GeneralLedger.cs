using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Code;

namespace WindowsFormsApplication1.Forms
{
    public partial class GeneralLedger : MetroFramework.Forms.MetroForm
    {
        public GeneralLedger()
        {
            InitializeComponent();
        }

        private void GeneralLedger_Load(object sender, EventArgs e)
        {
            cmGLAccountName.DataSource = new DAO().GetAccountNames();
            cmGLAccountName.DisplayMember = "AccountName";
            cmGLAccountName.ValueMember = "AccountId";
            cmGLAccountName.SelectedIndex = -1;

            datStartDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            datEndDate.Value = DateTime.Now;


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainObj = new Main();
            mainObj.Show();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DataTable dtAccountTransactions = new DataTable();
            SqlDataAdapter dad;
            SqlConnection conn = DBConn.GetInstance();
            dad = new SqlDataAdapter("SELECT Date,Narrative,transType,Amount from Gltransactions where AccountId = @1 AND Date BETWEEN @2 AND @3", conn);
            dad.SelectCommand.Parameters.AddWithValue("@1", int.Parse(cmGLAccountName.SelectedValue.ToString()));
            dad.SelectCommand.Parameters.AddWithValue("@2", datStartDate.Value);
            dad.SelectCommand.Parameters.AddWithValue("@3", datEndDate.Value);
            Int32 Debit = 0;
            Int32 Credit = 0;
            dad.Fill(dtAccountTransactions);

            foreach (DataRow row in dtAccountTransactions.Rows)
            {
                if(row["TransType"].ToString() == "Debit")
                {
                    Debit = Debit + Int32.Parse(row["Amount"].ToString());

                }
                else
                {
                    Credit = Credit + Int32.Parse(row["Amount"].ToString());

                }
                                
            }


            int NetMovement = Debit - Credit;

            //DataRow newRow = dtAccountTransactions.NewRow();
            //newRow["Narrative"] = "Total " + this.cmGLAccountName.GetItemText(this.cmGLAccountName.SelectedItem);

            //newRow["TransType"] = "Total Credit " + Credit + " And total Debit = " + Debit;

            DataRow secondRow = dtAccountTransactions.NewRow();
            secondRow["TransType"] = "Net Movement";
            secondRow["Amount"] = NetMovement;

            //dtAccountTransactions.Rows.Add(newRow);
            dtAccountTransactions.Rows.Add(secondRow);

            conn.Close();

            gvGlTransaction.DataSource = dtAccountTransactions;

            DataGridViewColumn column = gvGlTransaction.Columns[1];
            column.Width = 310;


        }
    }
}
