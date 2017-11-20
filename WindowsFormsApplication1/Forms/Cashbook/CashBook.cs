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
        public string PartyName = "";
        public static string InvoiceNo = "";
       // public static string InvoiceNo2 = "";

        public string ChequeNo = "";
        public string BankCode = "";
        public static int CBId;
        public string RefNo = "";
        public static decimal Amount = 0;
        public static int PartyIndex = -1;


        int AccountId;
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
            Main mainObj = new Main();
            mainObj.Show();
            this.Hide();
        }

        public void PerformRefresh()
        {
            gvCashBook.DataSource = new DAO().getCashBookEntries();
            DataGridViewColumn column = gvCashBook.Columns[3];
            column.Width = 200;

        }

        private void CashBook_Load(object sender, EventArgs e)
        {

            gvCashBook.DataSource = new DAO().getCashBookEntries();
            DataGridViewColumn column = gvCashBook.Columns[3];
            column.Width = 250;

            cmPartyName.DataSource = new DAO().GetPartiesFrmAccount();
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
            DataGridViewColumn column = gvCashBook.Columns[3];
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
           sql = "SELECT CBId,Date,ReferenceNo,Category,Description,AmountType,Income,Expense from CashBook WHERE CAST(date As Date) BETWEEN @1 AND @2";


           // sql = "SELECT x.CBId,x.Date,x.ReferenceNo,x.Category,x.Description,x.AmountType,x.Income,x.Expense,SUM(y.bal) netbalance FROM (SELECT *, Income - Expense bal FROM Cashbook ) x JOIN ( SELECT *, Income - Expense bal FROM Cashbook ) y ON y.CBId <= x.CBId  WHERE CAST(x.Date As Date)  BETWEEN @2 AND @3  ";

            //sql = "SELECT x.CBId,x.Date,x.Category,x.Description,x.AmountType,x.Income,x.Expense,SUM(y.bal) Balance FROM (SELECT *, Income - Expense bal FROM CashBook ) x JOIN ( SELECT *, Income - Expense bal FROM CashBook ) y ON y.CBId <= x.CBId WHERE x.date BETWEEN @1 AND @2";
               // string sqlp2 = " GROUP BY x.CBId,x.Date,x.ReferenceNo,x.Category,x.Description,x.AmountType,x.Income,x.Expense;";


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
                DataRowView dv = (DataRowView)cmPartyName.SelectedItem;
                int AccountId = (int)dv.Row["Party-ID"];
                //int PId;
                //int.TryParse(cmPartyName.SelectedValue.ToString(), out AccountId);

                party = " AND AccountId = " + AccountId;
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


          //  string cm = sql + sqlp2;


            DataTable dtCashBook = new DataTable();
            //string date = DateTime.Today.ToShortDateString();
            dad = new SqlDataAdapter(sql, conn);
            dad.SelectCommand.Parameters.AddWithValue("@1", dtStartDate.Value.Date);
            dad.SelectCommand.Parameters.AddWithValue("@2", dtEndDate.Value.Date);

            dad.Fill(dtCashBook);

            dtCashBook.Columns.Add("Balance", typeof(System.Decimal));
            int bal = 0;
            foreach (DataRow row in dtCashBook.Rows)
            {
                if (int.Parse(row[6].ToString()) != 0)
                {
                    row["Balance"] = bal + int.Parse(row[6].ToString());
                    bal += int.Parse(row[6].ToString());

                }


                if (int.Parse(row[7].ToString()) != 0)
                {
                    row["Balance"] = bal - int.Parse(row[7].ToString());
                    bal -= int.Parse(row[7].ToString());

                }





                conn.Close();

                gvCashBook.DataSource = dtCashBook;
            }



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

            

            foreach (DataGridViewRow row in gvCashBook.SelectedRows)
            {
                int.TryParse(row.Cells[0].Value.ToString(), out CBId);
                DataTable dtCashBook = new DataTable();
                //string date = DateTime.Today.ToShortDateString();
                dad = new SqlDataAdapter("SELECT AccountId,ChequeNo,BankCode,InvoiceNo from CashBook WHERE CBId = " + CBId, conn);
                dad.Fill(dtCashBook);
                conn.Close();




                if (dtCashBook.Rows[0][0].ToString() != "")
                {

                    

                    int.TryParse(dtCashBook.Rows[0][0].ToString(), out AccountId);


                    PartyName = new DAO().GetAccountName(AccountId);
                    txtPartyName.Text = PartyName;

                }
                else
                {
                    PartyName = "";
                    txtPartyName.Text = "";
                }

                if (dtCashBook.Rows[0][1].ToString() != "")
                {

                    ChequeNo = dtCashBook.Rows[0][1].ToString();
                    txtChequeNODetail.Text = ChequeNo;

                }
                else
                {
                    ChequeNo = "";
                    txtChequeNODetail.Text = "";

                }


                if (dtCashBook.Rows[0][2].ToString() != "")
                {
                    BankCode = dtCashBook.Rows[0][2].ToString();
                    txtBankCodeDetail.Text = BankCode;

                }
                else
                {
                    BankCode = "";
                    txtBankCodeDetail.Text = "";
                }


                if (dtCashBook.Rows[0][3].ToString() != "")
                {
                    InvoiceNo = dtCashBook.Rows[0][3].ToString();

                    txtInvoiceNoDetail.Text = InvoiceNo;
                }
                else
                {
                    InvoiceNo = "";
                    txtInvoiceNoDetail.Text = "";
                }









                //...
            }
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            string Category = this.gvCashBook.CurrentRow.Cells[2].Value.ToString();
            if(Category == "sales")
            {
                EditReciept();
                return;
            }
            else if(Category != "Journal Entry")
            {
                EditPayment();
            }

        }

        private void EditReciept()
        {

            EditReciept   er = new EditReciept(this);
            er.RecieptDatePicker.MinDate = new DateTime(DateTime.Now.Year, 1, 1);
            er.RecieptDatePicker.MaxDate = DateTime.Now;
            er.RecieptDatePicker.Value = DateTime.Parse(this.gvCashBook.CurrentRow.Cells[1].Value.ToString());
            // LotNo = int.Parse(this.gvCashBook.CurrentRow.Cells[3].Value.ToString());
            // er.RecieptDatePicker.Value = DateTime.Parse()
           // er.OrderId = this.gvCashBook.CurrentRow.Cells[0].Value.ToString();
            er.txtRecieptNarration.Text = this.gvCashBook.CurrentRow.Cells[3].Value.ToString();

            er.cmPartyName.DataSource = new DAO().GetPartiesFrmAccount();
            er.cmPartyName.DisplayMember = "Name";
            er.cmPartyName.ValueMember = "Party-ID";
            PartyIndex = getIndexParty(er.cmPartyName, PartyName);
            er.cmPartyName.SelectedIndex = PartyIndex;


            er.CBId = CBId;
            er.cmInvoiceNo.DataSource = new DAO().GetOrderIdsForEdit(AccountId);
            er.cmInvoiceNo.DisplayMember = "OrderId";
            er.cmInvoiceNo.ValueMember = "OrderId";
            if(InvoiceNo != "")
            {
                int InvoiceNoIndex = getIndexOrderId(er.cmInvoiceNo, InvoiceNo);
                er.cmInvoiceNo.SelectedIndex = InvoiceNoIndex;

            }
            else
            {
                er.cmInvoiceNo.SelectedIndex = -1;
            }


            DataTable ds = new DAO().GetCashBookRefNo(CBId);

            RefNo = ds.Rows[0][0].ToString();

            er.VoucherNo = ds.Rows[0][2].ToString();

            er.CBNo = int.Parse(ds.Rows[0][1].ToString()); 


            er.txtRefNo.Text = RefNo;
            er.AccountId = AccountId;
            er.invoiceNo = InvoiceNo;
            er.RefNo = RefNo;

            

            string AmountType = this.gvCashBook.CurrentRow.Cells[4].Value.ToString();
            if(AmountType == "Cash")
            {
                er.cmRecieptPayment.SelectedIndex = 0;
            }
            else
            {
                er.cmRecieptPayment.SelectedIndex = 1;
                er.txtChequeNo.Text = ChequeNo;
                er.txtBankCode.Text = BankCode;


            }

            Amount = decimal.Parse(this.gvCashBook.CurrentRow.Cells[5].Value.ToString());

            er.txtRecieptAmount.Text = Amount.ToString();

            er.Show();
        }

        private void EditPayment()
        {
            EditPayment er = new EditPayment(this);
            er.PaymentsDatePicker.MinDate = new DateTime(DateTime.Now.Year, 1, 1);
            er.PaymentsDatePicker.MaxDate = DateTime.Now;
            er.PaymentsDatePicker.Value = DateTime.Parse(this.gvCashBook.CurrentRow.Cells[1].Value.ToString());
            er.txtPaymentsNarration.Text = this.gvCashBook.CurrentRow.Cells[3].Value.ToString();


            string PaymentType = this.gvCashBook.CurrentRow.Cells[2].Value.ToString();

            if (PaymentType == "Purchase")
            {
                er.cmPaymentPartyName.Visible = true;
                er.lblPaymento.Visible = true;
                er.cmPaymentType.SelectedIndex = 0;
                er.cmPaymentPartyName.DataSource = new DAO().GetPartiesFrmAccount();
                er.cmPaymentPartyName.DisplayMember = "Name";
                er.cmPaymentPartyName.ValueMember = "Party-ID";
                PartyIndex = getIndexParty(er.cmPaymentPartyName, PartyName);
                er.cmPaymentPartyName.SelectedIndex = PartyIndex;

                er.cmInvoiceNo.Visible = true;
                er.lblInvoiceNo.Visible = true;
                er.cmInvoiceNo.DataSource = new DAO().GePurchaseIds(AccountId);
                er.cmInvoiceNo.DisplayMember = "PurId";
                er.cmInvoiceNo.ValueMember = "PurId";
                if (InvoiceNo != "")
                {
                    int InvoiceNoIndex = getIndexOrderId(er.cmInvoiceNo, InvoiceNo);
                    er.cmInvoiceNo.SelectedIndex = InvoiceNoIndex;

                }
                else
                {
                    er.cmInvoiceNo.SelectedIndex = -1;
                }



            }
            else
            {
                er.cmPaymentType.SelectedIndex = 1;
                er.cmPaymentPartyName.Visible = true;
                er.lblPaymento.Text = "Expense Type";
                er.lblPaymento.Visible = true;
                er.cmPaymentPartyName.DataSource = new DAO().GeExpenseNames();
                er.cmPaymentPartyName.DisplayMember = "AccountName";
                er.cmPaymentPartyName.ValueMember = "AccountId";
                int ExpenseIndex = getIndexParty(er.cmPaymentPartyName, PaymentType);
                er.cmPaymentPartyName.SelectedIndex = ExpenseIndex;


            }





            er.CBId = CBId;
           

            DataTable ds = new DAO().GetCashBookRefNo(CBId);

            RefNo = ds.Rows[0][0].ToString();

            er.VoucherNo = ds.Rows[0][2].ToString();

            er.CBNo = int.Parse(ds.Rows[0][1].ToString());


            er.txtRefNo.Text = RefNo;
            er.AccountId = AccountId;
            er.invoiceNo = InvoiceNo;
            er.RefNo = RefNo;



            string AmountType = this.gvCashBook.CurrentRow.Cells[4].Value.ToString();
            if (AmountType == "Cash")
            {
                er.cmPaymentMethod.SelectedIndex = 0;
                er.txtChequeNo.Enabled = false;
                er.txtBankCode.Enabled = false;
            }
            else
            {
                er.cmPaymentMethod.SelectedIndex = 1;
                er.txtChequeNo.Text = ChequeNo;
                er.txtBankCode.Text = BankCode;
                er.txtChequeNo.Enabled = true;
                er.txtBankCode.Enabled = true;

            }

            Amount = decimal.Parse(this.gvCashBook.CurrentRow.Cells[6].Value.ToString());

            er.txtPaymentAmount.Text = Amount.ToString();

            er.Show();
        }

        public static int getIndexParty(ComboBox comboBox, string value)
        {
            int i = 0;
            for (i = 0; i <= comboBox.Items.Count - 1; i++)
            {
                DataRowView cb;
                cb = (DataRowView)comboBox.Items[i];
                if (cb.Row.ItemArray[1].ToString() == value)// Change the 0 index if your want to Select by Text as 1 Index
                {

                    return i;
                }
            }
            return -1;
        }

        public static int getIndexOrderId(ComboBox comboBox, string value)
        {
            int i = 0;
            for (i = 0; i <= comboBox.Items.Count - 1; i++)
            {
                DataRowView cb;
                cb = (DataRowView)comboBox.Items[i];
                if (cb.Row.ItemArray[0].ToString() == value)// Change the 0 index if your want to Select by Text as 1 Index
                {

                    return i;
                }
            }
            return -1;
        }
    }
}
//
