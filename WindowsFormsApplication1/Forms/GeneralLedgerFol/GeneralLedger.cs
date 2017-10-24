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
using WindowsFormsApplication1.Forms.GeneralLedger;

namespace WindowsFormsApplication1.Forms.GeneralLedgerFol
{
    public partial class GeneralLedger : MetroFramework.Forms.MetroForm
    {

        public static int AccountId = 0;
        public static DateTime strtDate = new DateTime(DateTime.Now.Year, 1, 1);
        public static DateTime endDate = DateTime.Now;


        public GeneralLedger()
        {
            InitializeComponent();
        }

        private void GeneralLedger_Load(object sender, EventArgs e)
        {
            //cmGLAccountName.DataSource = new DAO().GetAccountNames();
            //cmGLAccountName.DisplayMember = "AccountName";
            //cmGLAccountName.ValueMember = "AccountId";
            //cmGLAccountName.SelectedIndex = -1;


            cmGLAccountName.ValueMember = "AccountId";
            cmGLAccountName.DisplayMember = "AccountName";
            cmGLAccountName.GroupMember = "AccountType";
            cmGLAccountName.DataSource = new BindingSource(new DAO().GetfullAccountNames(), String.Empty);



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
            AccountId = int.Parse(cmGLAccountName.SelectedValue.ToString());
            strtDate = datStartDate.Value;
            endDate = datEndDate.Value;

            DataTable dtAccountTransactions = new DataTable();
            SqlDataAdapter dad;
            SqlConnection conn = DBConn.GetInstance();

 //           SELECT x.slno
 //    , x.debit
 //    , x.credit
 //    , SUM(y.bal) balance
 // FROM
 //    (
 //      SELECT *, debit - credit bal FROM temp
 //    ) x
 // JOIN
 //    (
 //      SELECT *, debit - credit bal FROM temp
 //    ) y
 //   ON y.slno <= x.slno
 //GROUP
 //   BY x.slno;





            dad = new SqlDataAdapter("SELECT x.GLTransId,x.Date,x.Narrative,x.transType,x.Debit,x.Credit,SUM(y.bal) balance FROM (SELECT *, Debit - Credit bal FROM Gltransactions ) x JOIN ( SELECT *, Debit - Credit bal FROM Gltransactions ) y ON y.GLTransId <= x.GLTransId where x.AccountId = @1 AND y.AccountId = @1 AND x.Date BETWEEN @2 AND @3  GROUP BY x.GLTransId,x.Date,x.Narrative,x.transType,x.Debit,x.Credit;", conn);
            //Gltransactions where AccountId = @1 AND [Date] BETWEEN @2 AND @3 GROUP BY Date,GLTransId,Narrative,transType,Debit,Credit 
            dad.SelectCommand.Parameters.AddWithValue("@1", int.Parse(cmGLAccountName.SelectedValue.ToString()));
            dad.SelectCommand.Parameters.AddWithValue("@2", datStartDate.Value);
            dad.SelectCommand.Parameters.AddWithValue("@3", datEndDate.Value);
            decimal Debit = 0;
            decimal Credit = 0;
            dad.Fill(dtAccountTransactions);

            //foreach (DataRow row in dtAccountTransactions.Rows)
            //{
            //    if(row["TransType"].ToString() == "Debit")
            //    {
            //        Debit = Debit + Decimal.Parse(row["Amount"].ToString());

            //    }
            //    else
            //    {
            //        Credit = Credit + Decimal.Parse(row["Amount"].ToString());

            //    }

            //}


            //decimal NetMovement = Debit - Credit;

            //DataRow newRow = dtAccountTransactions.NewRow();
            //newRow["Narrative"] = "Total " + this.cmGLAccountName.GetItemText(this.cmGLAccountName.SelectedItem);

            //newRow["TransType"] = "Total Credit " + Credit + " And total Debit = " + Debit;

            DataRow secondRow = dtAccountTransactions.NewRow();

            secondRow["Narrative"] = "Balance b/d";


            try
            {
                int bal = 0;
                if (int.Parse(dtAccountTransactions.Rows[0][4].ToString()) == 0)
                {
                    bal  -= int.Parse(dtAccountTransactions.Rows[0][5].ToString()) - int.Parse(dtAccountTransactions.Rows[0][5].ToString());

                }
                if (int.Parse(dtAccountTransactions.Rows[0][5].ToString()) == 0)
                {
                    bal  += int.Parse(dtAccountTransactions.Rows[0][6].ToString()) - int.Parse(dtAccountTransactions.Rows[0][4].ToString());

                }

                secondRow["Balance"] = bal;

            }
            catch (Exception ex)
            {

            }

            //dtAccountTransactions.Rows.Add(newRow);


            dtAccountTransactions.Rows.InsertAt(secondRow, 0);

            conn.Close();

            gvGlTransaction.DataSource = dtAccountTransactions;

          //  gvGlTransaction.Rows.Insert(0, secondRow);

            DataGridViewColumn column = gvGlTransaction.Columns[2];
            column.Width = 310;


        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            BtnSearch_Click(sender,e);
            GlPrint obj = new GlPrint();
            obj.Show();
            
        }

        private void datEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
