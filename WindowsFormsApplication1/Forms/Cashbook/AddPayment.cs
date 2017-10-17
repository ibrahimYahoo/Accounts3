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

namespace WindowsFormsApplication1.Forms.Cashbook
{
    public partial class AddPayment : MetroFramework.Forms.MetroForm
    {

        CashBook owner;


        public AddPayment(CashBook frm1)
        {
            owner = frm1;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPayment_FormClosing);

            InitializeComponent();


            
        }



        public AddPayment()
        {
            InitializeComponent();
        }

        private void PaymentsDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (cmPaymentMethod.SelectedIndex == -1 || cmPaymentPartyName.SelectedIndex == -1 || String.IsNullOrEmpty(txtPaymentAmount.Text))
            {
                MessageBox.Show("please fill all textboxes first");

            }
            else
            {
                try
                {

                    DataTable dt = new DataTable();

                    SqlConnection conn = DBConn.GetInstance();
                    SqlDataAdapter dad = new SqlDataAdapter("", conn);
                    string invoiceNo;

                    try
                    {
                        invoiceNo = this.cmInvoiceNo.GetItemText(this.cmInvoiceNo.SelectedItem);


                    }
                    catch (Exception ex)
                    {
                        invoiceNo = "";

                    }

                    string Category = "";
                    string PaymentType = this.cmPaymentType.GetItemText(this.cmPaymentType.SelectedItem);

                    if (PaymentType.Equals("Purchase"))
                    {

                       Category  = PaymentType;

                    }
                    else if (PaymentType.Equals("Expenses"))
                    {
                        string ExpenseType = this.cmPaymentPartyName.GetItemText(this.cmPaymentPartyName.SelectedItem);
                        Category = ExpenseType;
                    }



                    string AccountName = this.cmPaymentPartyName.GetItemText(this.cmPaymentPartyName.SelectedItem);


                    int AccountId = new DAO().GetAccountId(AccountName);


                    int CashBookBalance = new DAO().GetCashBookBalance();
                    int x;

                    Int32.TryParse(cmPaymentPartyName.SelectedValue.ToString(), out x);

                    if (cmPaymentMethod.SelectedItem.Equals("Cash"))
                    {

                        dad = new SqlDataAdapter("Insert INTO CashBook(Date,ReferenceNo,Category,Description,AmountType,Expense,Balance,InvoiceNo,PId) values (@3,@4,@5,@6,@7,@8,@9,@10,@11)", conn);
                        new DAO().AddGlTransactions(PaymentsDatePicker.Value, txtPaymentsNarration.Text, 1, "Debit", invoiceNo, int.Parse(txtPaymentAmount.Text), 00);
                        new DAO().AddGlTransactions(PaymentsDatePicker.Value, txtPaymentsNarration.Text, 8, "Credit", invoiceNo, int.Parse(txtPaymentAmount.Text), 00);
                        new DAO().AddGlTransactions(PaymentsDatePicker.Value, txtPaymentsNarration.Text, AccountId, "Debit", invoiceNo, int.Parse(txtPaymentAmount.Text), 00);


                        dad.SelectCommand.Parameters.AddWithValue("@3", PaymentsDatePicker.Value);
                        dad.SelectCommand.Parameters.AddWithValue("@4", txtRefNo.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@5", Category);
                        dad.SelectCommand.Parameters.AddWithValue("@6", txtPaymentsNarration.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@7", this.cmPaymentMethod.GetItemText(this.cmPaymentMethod.SelectedItem));
                        dad.SelectCommand.Parameters.AddWithValue("@8", txtPaymentAmount.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@9", CashBookBalance - int.Parse(txtPaymentAmount.Text));
                        dad.SelectCommand.Parameters.AddWithValue("@10", invoiceNo);
                        dad.SelectCommand.Parameters.AddWithValue("@11", x);
                    }
                    else if (cmPaymentMethod.SelectedItem.Equals("Cheque"))
                    {

                        dad = new SqlDataAdapter("Insert INTO CashBook(Date,ReferenceNo,Category,Description,AmountType,Expense,Balance,InvoiceNo,ChequeNo,BankCode,PId) values (@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13)", conn);
                        new DAO().AddGlTransactions(PaymentsDatePicker.Value, txtPaymentsNarration.Text, 2, "Debit", invoiceNo, int.Parse(txtPaymentAmount.Text), 00);
                        new DAO().AddGlTransactions(PaymentsDatePicker.Value, txtPaymentsNarration.Text, 8, "Credit", invoiceNo, int.Parse(txtPaymentAmount.Text), 00);
                        new DAO().AddGlTransactions(PaymentsDatePicker.Value, txtPaymentsNarration.Text, AccountId, "Debit", invoiceNo, int.Parse(txtPaymentAmount.Text), 00);

                        dad.SelectCommand.Parameters.AddWithValue("@3", PaymentsDatePicker.Value);
                        dad.SelectCommand.Parameters.AddWithValue("@4", txtRefNo.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@5", Category);
                        dad.SelectCommand.Parameters.AddWithValue("@6", txtPaymentsNarration.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@7", this.cmPaymentMethod.GetItemText(this.cmPaymentMethod.SelectedItem));
                        dad.SelectCommand.Parameters.AddWithValue("@8", txtPaymentAmount.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@9", CashBookBalance - int.Parse(txtPaymentAmount.Text));
                        dad.SelectCommand.Parameters.AddWithValue("@10", invoiceNo);
                        dad.SelectCommand.Parameters.AddWithValue("@11", txtChequeNo.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@12", txtBankCode.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@13", x);

                    }

                    dad.Fill(dt);
                    conn.Close();
                    MessageBox.Show("Payement addded");

                    if (invoiceNo.Equals("")) {
                        
                         

                    }
                    else
                    {

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void AddPayment_Load(object sender, EventArgs e)
        {
            //cmPaymentPartyName.DataSource = new DAO().GetParties();
            //cmPaymentPartyName.DisplayMember = "Name";
            //cmPaymentPartyName.ValueMember = "Party-ID";
            //cmPaymentPartyName.SelectedIndex = -1;
            txtChequeNo.Enabled = false;
            txtBankCode.Enabled = false;




        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void cmInvoiceNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmPaymentType.SelectedIndex == 0)
            {
                lblPaymento.Visible = true;
                cmPaymentPartyName.Visible = true;
                lblInvoiceNo.Visible = true;
                cmInvoiceNo.Visible = true;
                lblPaymento.Text = "Payment to";




                cmPaymentPartyName.DataSource = new DAO().GetParties();
                cmPaymentPartyName.DisplayMember = "Name";
                cmPaymentPartyName.ValueMember = "Party-ID";
                cmPaymentPartyName.SelectedIndex = -1;





            }
            else if(cmPaymentType.SelectedIndex == 1) {

                lblPaymento.Text = "Expense Type";

                cmPaymentPartyName.DataSource = new DAO().GeExpenseNames();
                cmPaymentPartyName.DisplayMember = "AccountName";
                cmPaymentPartyName.ValueMember = "AccountId";
                cmPaymentPartyName.SelectedIndex = -1;

                lblPaymento.Visible = true;
                cmPaymentPartyName.Visible = true;

                lblInvoiceNo.Visible = false;
                cmInvoiceNo.Visible = false;


            }

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void cmPaymentPartyName_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox cb = (ComboBox)sender;
            if (!cb.Focused)
            {
                return;
            }
            int x;

            Int32.TryParse(cmPaymentPartyName.SelectedValue.ToString(), out x);
            cmInvoiceNo.DataSource = new DAO().GePurchaseIds(x);
            cmInvoiceNo.DisplayMember = "PurId";
            cmInvoiceNo.ValueMember = "PurId";
            cmInvoiceNo.SelectedIndex = -1;

        }

        

        private void cmPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (!cb.Focused)
            {
                return;
            }
            if (cmPaymentMethod.SelectedIndex == 0)
            {
                txtChequeNo.Enabled = false;
                txtBankCode.Enabled = false;


            }
            else if (cmPaymentMethod.SelectedIndex == 1)
            {
                txtChequeNo.Enabled = true;
                txtBankCode.Enabled = true;


            }


        }

       
        private void AddPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.PerformRefresh();


        }
    }
}
