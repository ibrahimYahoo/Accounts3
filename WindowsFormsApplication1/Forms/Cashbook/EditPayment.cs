using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Code;

namespace WindowsFormsApplication1.Forms.Cashbook
{
    public partial class EditPayment : MetroFramework.Forms.MetroForm
    {

        CashBook owner;
        public string RefNo = "";
        public int CBNo = 0;
        public string VoucherNo  = "";
        public string AccountName = "";
        public int AccountId = 0;
        public int CBId = 0;

        public bool print = true;

        public string invoiceNo;





        public EditPayment(CashBook frm1)
        {
            owner = frm1;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPayment_FormClosing);

            InitializeComponent();


            
        }

        



        public EditPayment()
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
                        DataRowView dv = (DataRowView)cmPaymentPartyName.SelectedItem;
                        AccountName = (string)dv.Row["Name"];
                        AccountId = (int)dv.Row["Party-ID"];


                    }
                    else if (PaymentType.Equals("Expenses"))
                    {
                        string ExpenseType = this.cmPaymentPartyName.GetItemText(this.cmPaymentPartyName.SelectedItem);
                        Category = ExpenseType;
                        DataRowView dv = (DataRowView)cmPaymentPartyName.SelectedItem;
                         AccountName = (string)dv.Row["AccountName"];
                         AccountId = (int)dv.Row["AccountId"];

                    }




                    //string AccountName = this.cmPaymentPartyName.GetItemText(this.cmPaymentPartyName.SelectedItem);


                    //AccountId = new DAO().GetAccountId(AccountName);


                 //   decimal CashBookBalance = new DAO().GetCashBookBalance();
                    int x;

                    //int VoucherNo = new DAO().getLastCBId();



                    //Int32.TryParse(cmPaymentPartyName.SelectedValue.ToString(), out x);

                    decimal PaymentAmount = Decimal.Parse(txtPaymentAmount.Text);

                    if (cmPaymentMethod.SelectedItem.Equals("Cash"))
                    {
                        RefNo = txtRefNo.Text;
                        //dad = new SqlDataAdapter("Insert INTO CashBook(Date,ReferenceNo,Category,Description,AmountType,Expense,Balance,InvoiceNo,AccountId,CBNo,VoucherNo,TransactionType) values (@3,@4,@5,@6,@7,@8,@9,@10,@11,@CBNo,@VoucherNo,@TransactionType)", conn);
                        dad = new SqlDataAdapter("Update CashBook SET Date=@3, ReferenceNo=@4, Category=@5,Description=@6, AmountType=@7,Expense = @8, Balance = @9, InvoiceNo = @10, AccountId = @11,CBNo = @CBNo, VoucherNo = @VoucherNo, TransactionType = @TransactionType where CBId = @CBId", conn);


                        new DAO().UpdateGlTransaction(PaymentsDatePicker.Value, txtPaymentsNarration.Text, 1, "Debit", RefNo, 0, PaymentAmount, 00);
                        new DAO().UpdateGlTransaction(PaymentsDatePicker.Value, txtPaymentsNarration.Text, 8, "Credit", RefNo, PaymentAmount, 0,00);
                        new DAO().UpdateGlTransaction(PaymentsDatePicker.Value, txtPaymentsNarration.Text, AccountId, "Debit", RefNo, 0, PaymentAmount, 00);


                        dad.SelectCommand.Parameters.AddWithValue("@3", PaymentsDatePicker.Value);
                        dad.SelectCommand.Parameters.AddWithValue("@4", RefNo);
                        dad.SelectCommand.Parameters.AddWithValue("@5", Category);
                        dad.SelectCommand.Parameters.AddWithValue("@6", txtPaymentsNarration.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@7", this.cmPaymentMethod.GetItemText(this.cmPaymentMethod.SelectedItem));
                        dad.SelectCommand.Parameters.AddWithValue("@8", PaymentAmount);
                        dad.SelectCommand.Parameters.AddWithValue("@9", 0);
                        dad.SelectCommand.Parameters.AddWithValue("@10", invoiceNo);
                        dad.SelectCommand.Parameters.AddWithValue("@11", AccountId);
                        dad.SelectCommand.Parameters.AddWithValue("@CBNo", CBNo);
                        dad.SelectCommand.Parameters.AddWithValue("@VoucherNo", VoucherNo);
                        dad.SelectCommand.Parameters.AddWithValue("@TransactionType", "Credit");
                        dad.SelectCommand.Parameters.AddWithValue("@CBId", CBId);

                    }
                    else if (cmPaymentMethod.SelectedItem.Equals("Cheque"))
                    {


 //dad = new SqlDataAdapter("Insert INTO CashBook(Date,ReferenceNo,Category,Description,AmountType,Expense,Balance,InvoiceNo,ChequeNo,BankCode,AccountId,CBNo,VoucherNo,TransactionType) values (@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@CBNo,@VoucherNo,@TransactionType)", conn);
 dad = new SqlDataAdapter("Update CashBook SET Date=@3, ReferenceNo=@4, Category=@5,Description=@6, AmountType=@7,Expense = @8, Balance = @9, InvoiceNo = @10,ChequeNo = @11,BankCode = @12, AccountId = @13,CBNo = @CBNo, VoucherNo = @VoucherNo, TransactionType = @TransactionType where CBId = @CBId", conn);

                        new DAO().UpdateGlTransaction(PaymentsDatePicker.Value, txtPaymentsNarration.Text, 2, "Debit", RefNo, 0, PaymentAmount, 00);
                        new DAO().UpdateGlTransaction(PaymentsDatePicker.Value, txtPaymentsNarration.Text, 8, "Credit", RefNo, PaymentAmount, 0, 00);
                        new DAO().UpdateGlTransaction(PaymentsDatePicker.Value, txtPaymentsNarration.Text, AccountId, "Debit", RefNo, 0, PaymentAmount, 00);

                        dad.SelectCommand.Parameters.AddWithValue("@3", PaymentsDatePicker.Value);
                        dad.SelectCommand.Parameters.AddWithValue("@4", txtRefNo.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@5", Category);
                        dad.SelectCommand.Parameters.AddWithValue("@6", txtPaymentsNarration.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@7", this.cmPaymentMethod.GetItemText(this.cmPaymentMethod.SelectedItem));
                        dad.SelectCommand.Parameters.AddWithValue("@8", PaymentAmount);
                        dad.SelectCommand.Parameters.AddWithValue("@9", 0);
                        dad.SelectCommand.Parameters.AddWithValue("@10", invoiceNo);
                        dad.SelectCommand.Parameters.AddWithValue("@11", Decimal.Parse(txtChequeNo.Text, CultureInfo.InvariantCulture) );
                        dad.SelectCommand.Parameters.AddWithValue("@12", Decimal.Parse(txtBankCode.Text, CultureInfo.InvariantCulture));
                        dad.SelectCommand.Parameters.AddWithValue("@13", AccountId);
                        dad.SelectCommand.Parameters.AddWithValue("@CBNo", CBNo);
                        dad.SelectCommand.Parameters.AddWithValue("@VoucherNo", VoucherNo);
                        dad.SelectCommand.Parameters.AddWithValue("@TransactionType", "Credit");
                        dad.SelectCommand.Parameters.AddWithValue("@CBId", CBId);

                    }

                    dad.Fill(dt);
                    conn.Close();
                    MessageBox.Show("Payment updated");


                    

                    if (invoiceNo.Equals("")) {
                        
                         

                    }
                    else
                    {
                        if (CashBook.InvoiceNo == invoiceNo)
                        {
                            new DAO().checkEditPurchaseSatus(invoiceNo, PaymentAmount, AccountId,CashBook.Amount);


                        }
                        else
                        {
                            new DAO().checkPurchaseSatus(invoiceNo, PaymentAmount, AccountId);

                        }




                    }
                    if (print == true)
                    {
                        PaymentVoucher obj = new PaymentVoucher();
                        obj.WindowState = FormWindowState.Maximized;
                        obj.Show();
                        this.Close();

                    }
                    else
                    {
                        this.Close();
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
            print = true;
            //cmPaymentPartyName.DataSource = new DAO().GetParties();
            //cmPaymentPartyName.DisplayMember = "Name";
            //cmPaymentPartyName.ValueMember = "Party-ID";
            //cmPaymentPartyName.SelectedIndex = -1;
            //txtChequeNo.Enabled = false;
            //txtBankCode.Enabled = false;
            //txtRefNo.Text = "";

            //txtChequeNo.Text = "0";
            //txtBankCode.Text = "0";


            //CBNo = new DAO().getLastCBNoByCredit()  + 1;
            //VoucherNo = "PV" + CBNo;




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

            ComboBox cb = (ComboBox)sender;
            if (!cb.Focused)
            {
                return;
            }

            if (cmPaymentType.SelectedIndex == 0)
            {
                lblPaymento.Visible = true;
                cmPaymentPartyName.Visible = true;
                lblInvoiceNo.Visible = true;
                cmInvoiceNo.Visible = true;
                lblPaymento.Text = "Payment to";

                cmPaymentPartyName.DataSource = new DAO().GetPartiesFrmAccount();
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
            cmPaymentPartyName.SelectedIndex = -1;
            txtRefNo.Text = "";
            txtPaymentAmount.Text = "";
            txtPaymentsNarration.Text = "";
            cmPaymentType.SelectedIndex = -1;
            txtChequeNo.Text = "0";
            txtBankCode.Text = "0";
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
            try
            {
                owner.PerformRefresh();

            }
            catch (Exception ex)
            {

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

        private void txtPaymentAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            print = false;
            metroButton1_Click(sender, e);

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void lblCheqeNo_Click(object sender, EventArgs e)
        {

        }
    }
}
