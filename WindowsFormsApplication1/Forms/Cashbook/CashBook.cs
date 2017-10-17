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
using WindowsFormsApplication1.Forms.Cashbook;

namespace WindowsFormsApplication1.Forms
{
    public partial class CashBook : MetroFramework.Forms.MetroForm
    {
        SqlDataAdapter dad;
        SqlConnection conn = DBConn.GetInstance();
        public CashBook()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AddReciept addRecObj = new AddReciept(this);
            addRecObj.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AddPayment addPayObj = new AddPayment(this);
            addPayObj.Show();

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            Main mainObj = new Main();
            mainObj.Show();
        }

        public void PerformRefresh()
        {
            gvCashBook.DataSource = new DAO().getCashBookEntries();
            DataGridViewColumn column = gvCashBook.Columns[4];
            column.Width = 250;

        }

        private void CashBook_Load(object sender, EventArgs e)
        {
            
            gvCashBook.DataSource = new DAO().getCashBookEntries();
            DataGridViewColumn column = gvCashBook.Columns[4];
            column.Width = 250;

            cmPartyName.DataSource = new DAO().GetParties();
            cmPartyName.DisplayMember = "Name";
            cmPartyName.ValueMember = "Party-ID";
            cmPartyName.SelectedIndex = -1;

            //  gvCashBookPayments.DataSource = new DAO().getCashBookPayments();
            //try
            //{
            //    gvCashBookPayments.Rows.Insert(0, new string[] {
            //      "Data1", "Data2", "Data3" // [, "DataN"] ..
            //    });
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            gvCashBook.DataSource = new DAO().getCashBookEntries();
            DataGridViewColumn column = gvCashBook.Columns[4];
            column.Width = 250;


        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            //gvCashBookPayments.DataSource = new DAO().getCashBookPayments();
            
        }

        private void gvCashBookPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

            string amount = "";
            string cheque = "";
            string bankCode = "";
            string InvoiceNo = "";
            string RefNo = "";
            string sql = "";
            string party = "";
            sql = "SELECT CBId,Date,ReferenceNo,Category,Description,AmountType,Income,Expense,Balance from CashBook WHERE date BETWEEN @1 AND @2";


            if (txtAmount.Text != "")
            {
                amount = " AND (Income = " + txtAmount.Text + " OR Expense = " + txtAmount.Text + ")";
                sql += amount;


            }
            if (txtChequeNo.Text != "")
            {
                cheque = " AND ChequeNO = " + txtChequeNo.Text;
                sql += cheque;

            }
            if (cmPartyName.SelectedIndex > -1)
            {
                int PId;
                int.TryParse(cmPartyName.SelectedValue.ToString(), out PId);

                party = " AND PId = " + PId;
                sql += party;

            }
            if (txtBankCode.Text != "")
            {
                bankCode = " AND BankCode = " + txtBankCode.Text;
                sql += bankCode;

            }
            if (txtInvoiceNo.Text != "")
            {
                InvoiceNo = " AND InvoiceNo = '" + txtInvoiceNo.Text + "'";
                sql += InvoiceNo;

            }
            if (txtRefNo.Text != "")
            {
                RefNo = " AND ReferenceNo = '" + txtRefNo.Text + "'";
                sql += RefNo;

            }



           

            DataTable dtCashBook = new DataTable();
            //string date = DateTime.Today.ToShortDateString();
            dad = new SqlDataAdapter(sql, conn);
            dad.SelectCommand.Parameters.AddWithValue("@1", dtStartDate.Value);
            dad.SelectCommand.Parameters.AddWithValue("@2", dtEndDate.Value);

            dad.Fill(dtCashBook);


            conn.Close();

            gvCashBook.DataSource = dtCashBook;




        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {
          





        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            gvCashBook.DataSource = new DAO().getCashBookEntries();

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void txtChequeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void txtBankCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void gvCashBook_SelectionChanged(object sender, EventArgs e)
        {

            DataGridView cb = (DataGridView)sender;
            if (!cb.Focused)
            {
                return;
            }

            foreach (DataGridViewRow row in gvCashBook.SelectedRows)
            {
                int CBId;
                int.TryParse(row.Cells[0].Value.ToString(),out CBId);
                DataTable dtCashBook = new DataTable();
                //string date = DateTime.Today.ToShortDateString();
                dad = new SqlDataAdapter("SELECT PId,ChequeNo,BankCode,InvoiceNo from CashBook WHERE CBId = " + CBId, conn);
                dad.Fill(dtCashBook);
                conn.Close();

                
                
                   
                  if(dtCashBook.Rows[0][0].ToString() != "") {

                    int PId;

                    int.TryParse(dtCashBook.Rows[0][0].ToString(), out PId);



                    txtPartyName.Text = new DAO().GetAccountName(PId);

                };

                if (dtCashBook.Rows[0][1].ToString() != "")
                {

                    txtChequeNODetail.Text = dtCashBook.Rows[0][1].ToString();

                };

                if (dtCashBook.Rows[0][2].ToString() != "")
                {

                    txtBankCodeDetail.Text = dtCashBook.Rows[0][2].ToString();

                };

                if (dtCashBook.Rows[0][3].ToString() != "")
                {

                    txtInvoiceNoDetail.Text = dtCashBook.Rows[0][3].ToString();

                };







                //...
            }
        }
    }
}
//