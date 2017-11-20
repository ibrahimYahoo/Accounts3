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
using WindowsFormsApplication1.Forms.Order;
using System.Diagnostics;


namespace WindowsFormsApplication1.Forms.Cashbook

{
    public partial class EditReciept : MetroFramework.Forms.MetroForm
    {
        public int AccountId;
        public string invoiceNo;
        CashBook owner;
        public string RefNo = "";
        public int CBNo = 0;
        public string VoucherNo = "";
        public string AccountName = "";
        public int CBId = 0;

        bool print = true;

        public static string OrderId = "";
        //public static int CBIdd = 0;

        string caller;
        public EditReciept(CashBook frm1)
        {
            owner = frm1;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddReciept_FormClosing);


            //caller = new StackTrace().GetFrame(1).GetMethod().DeclaringType.Name;

            InitializeComponent();


            
        }




        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (cmRecieptPayment.SelectedIndex == -1 || cmPartyName.SelectedIndex == -1 || String.IsNullOrEmpty(txtRecieptAmount.Text))
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
                        OrderId = invoiceNo;

                    }
                    catch (Exception ex)
                    {
                        invoiceNo = "";

                    }

                    //if(invoiceNo != "")
                    //{

                    //}

                    //  string AccountName = this.cmPartyName.GetItemText(this.cmPartyName.SelectedItem);

                    // int AccountId = new DAO().GetAccountId(AccountName);

                    // decimal CashBookBalance = new DAO().GetCashBookBalance();

                    //int.TryParse(cmPartyName.SelectedValue.ToString(), out PId);




                    //new DAO().UpdatePartyBalance(PId, int.Parse(lblSubtotal.Text) + PartyBalance);

                    RefNo = txtRefNo.Text;
                    //string partyName = new DAO().getPartyName()
                    if (cmRecieptPayment.SelectedItem.Equals("Cash"))
                    {
                        //   "Payment for Invoice " + invoiceNo + "-" + AccountName

  //dad = new SqlDataAdapter("Insert INTO CashBook(Date,ReferenceNo,Category,Description,AmountType,Income,Balance,InvoiceNo,AccountId,CBNo,VoucherNo,TransactionType) values (@3,@4,@5,@6,@7,@8,@9,@10,@11,@CBNo,@VoucherNo,@TransactionType)", conn);
                       dad = new SqlDataAdapter("Update CashBook SET Date=@3, ReferenceNo=@4, Category=@5,Description=@6, AmountType=@7,Income = @8, Balance = @9, InvoiceNo = @10, AccountId = @11,CBNo = @CBNo, VoucherNo = @VoucherNo, TransactionType = @TransactionType where CBId = @CBId", conn);



                        new DAO().UpdateGlTransaction(RecieptDatePicker.Value, txtRecieptNarration.Text, 1, "Debit", RefNo, 0, Decimal.Parse(txtRecieptAmount.Text), 00);
                        new DAO().UpdateGlTransaction(RecieptDatePicker.Value, txtRecieptNarration.Text, 7, "Credit", RefNo, Decimal.Parse(txtRecieptAmount.Text), 0, 00);
                        new DAO().UpdateGlTransaction(RecieptDatePicker.Value, txtRecieptNarration.Text, AccountId, "Credit", RefNo, Decimal.Parse(txtRecieptAmount.Text), 0, 00);

                        dad.SelectCommand.Parameters.AddWithValue("@3", RecieptDatePicker.Value);
                        dad.SelectCommand.Parameters.AddWithValue("@4", txtRefNo.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@5", "sales");
                        dad.SelectCommand.Parameters.AddWithValue("@6", txtRecieptNarration.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@7", this.cmRecieptPayment.GetItemText(this.cmRecieptPayment.SelectedItem));
                        dad.SelectCommand.Parameters.AddWithValue("@8", Decimal.Parse(txtRecieptAmount.Text));
                        dad.SelectCommand.Parameters.AddWithValue("@9", 0);
                        dad.SelectCommand.Parameters.AddWithValue("@10", invoiceNo);
                        dad.SelectCommand.Parameters.AddWithValue("@11", AccountId);
                        dad.SelectCommand.Parameters.AddWithValue("@CBNo", CBNo);
                        dad.SelectCommand.Parameters.AddWithValue("@VoucherNo", VoucherNo);
                        dad.SelectCommand.Parameters.AddWithValue("@TransactionType", "Credit");
                        dad.SelectCommand.Parameters.AddWithValue("@CBId", CBId);


                    }
                    else if (cmRecieptPayment.SelectedItem.Equals("Cheque"))
                    {



                       // dad = new SqlDataAdapter("Insert INTO CashBook(Date,ReferenceNo,Category,Description,AmountType,Income,Balance,InvoiceNo,ChequeNo,BankCode,AccountId,CBNo,VoucherNo,TransactionType) values (@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@CBNo,@VoucherNo,@TransactionType)", conn);
                        dad = new SqlDataAdapter("Update CashBook SET Date=@3, ReferenceNo=@4, Category=@5,Description=@6, AmountType=@7,Income = @8, Balance = @9, InvoiceNo = @10,ChequeNo = @11,BankCode = @12, AccountId = @13,CBNo = @CBNo, VoucherNo = @VoucherNo, TransactionType = @TransactionType where CBId = @CBId", conn);

                        new DAO().UpdateGlTransaction(RecieptDatePicker.Value, txtRecieptNarration.Text, 2, "Debit", RefNo, 0, Decimal.Parse(txtRecieptAmount.Text), 00);
                        new DAO().UpdateGlTransaction(RecieptDatePicker.Value, txtRecieptNarration.Text, 7, "Credit", RefNo, Decimal.Parse(txtRecieptAmount.Text), 0, 00);
                        new DAO().UpdateGlTransaction(RecieptDatePicker.Value, txtRecieptNarration.Text, AccountId, "Credit", RefNo, Decimal.Parse(txtRecieptAmount.Text), 0, 00);

                        dad.SelectCommand.Parameters.AddWithValue("@3", RecieptDatePicker.Value);
                        dad.SelectCommand.Parameters.AddWithValue("@4", txtRefNo.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@5", "sales");
                        dad.SelectCommand.Parameters.AddWithValue("@6", txtRecieptNarration.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@7", this.cmRecieptPayment.GetItemText(this.cmRecieptPayment.SelectedItem));
                        dad.SelectCommand.Parameters.AddWithValue("@8", Decimal.Parse(txtRecieptAmount.Text));
                        dad.SelectCommand.Parameters.AddWithValue("@9", 0);
                        dad.SelectCommand.Parameters.AddWithValue("@10", invoiceNo);
                        dad.SelectCommand.Parameters.AddWithValue("@11", Decimal.Parse(txtChequeNo.Text));
                        dad.SelectCommand.Parameters.AddWithValue("@12", Decimal.Parse(txtBankCode.Text));
                        dad.SelectCommand.Parameters.AddWithValue("@13", AccountId);
                        dad.SelectCommand.Parameters.AddWithValue("@CBNo", CBNo);
                        dad.SelectCommand.Parameters.AddWithValue("@VoucherNo", VoucherNo);
                        dad.SelectCommand.Parameters.AddWithValue("@TransactionType", "Credit");
                        dad.SelectCommand.Parameters.AddWithValue("@CBId", CBId);


                    }

                    // int PId = int.Parse(cmPartyName.SelectedValue.ToString());


                    //decimal PartyBalance = new DAO().GetPartyBalance(PId);

                    //new DAO().UpdateOwnerBalance(PId, PartyBalance - Decimal.Parse(txtRecieptAmount.Text));

                    dad.Fill(dt);
                    conn.Close();


                   

                    MessageBox.Show("Reciept Updated");

                    if (print == true)
                    {
                        if (invoiceNo != "")
                        {
                            if (CashBook.InvoiceNo == invoiceNo)
                            {
                                new DAO().checkEditOrderSatus(invoiceNo, Decimal.Parse(txtRecieptAmount.Text), AccountId, CashBook.Amount);


                            }
                            else
                            {
                                new DAO().checkOrderSatus(invoiceNo, Decimal.Parse(txtRecieptAmount.Text), AccountId);

                            }

                            //new DAO().checkOrderSatus(invoiceNo, Decimal.Parse(txtRecieptAmount.Text), AccountId);
                            this.Close();
                            RecieptPrint obj = new RecieptPrint();
                            obj.Show();
                            this.Close();

                        }
                        else
                        {
                            //new DAO().checkOrderSatus(invoiceNo, Decimal.Parse(txtRecieptAmount.Text), PId);
                            this.Close();
                            RecieptPrintWithoutInvoice obj = new RecieptPrintWithoutInvoice();
                            obj.Show();
                            this.Close();


                        }


                    }
                    else
                    {

                        if (invoiceNo != "")
                        {
                            if (CashBook.InvoiceNo == invoiceNo)
                            {
                                new DAO().checkEditOrderSatus(invoiceNo, Decimal.Parse(txtRecieptAmount.Text), AccountId, CashBook.Amount);


                            }
                            else
                            {
                                new DAO().checkOrderSatus(invoiceNo, Decimal.Parse(txtRecieptAmount.Text), AccountId);

                            }
                        }
                        this.Close();

                    }









                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }









        }

        private void AddReciept_Load(object sender, EventArgs e)
        {
            CBId = CashBook.CBId;
            cmPartyName.SelectedIndex = CashBook.PartyIndex;
            print = true;
            //txtRefNo.Text = "";

            //txtChequeNo.Text = "0";
            //txtBankCode.Text = "0";

            //CBNo = new DAO().getLastCBNoByDebit() + 1;
            //VoucherNo = "RV" + CBNo;

            //cmInvoiceNo.DataSource = new DAO().GetOrderIds();
            //cmInvoiceNo.DisplayMember = "OrderId";
            //cmInvoiceNo.ValueMember = "OrderId";
            //cmInvoiceNo.SelectedIndex = -1;

            //if (caller == "RequestOrderPayment")
            //{
            //    //cmPartyName.SelectedIndex = AddOrder.index;
            //    //cmInvoiceNo.SelectedText = AddOrder.OrderId;
            //    txtRecieptAmount.Text = AddOrder.amountTrnferRec.ToString();

            //}

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            lblRemPartyRecBal.Text = "";
            lblRemInvBal.Text = "";
            txtRecieptNarration.Text = "";
            txtRecieptAmount.Text = "";


        }

        private void cmPartyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            if (!cb.Focused)
            {
                return;
            }


            DataRowView dv = (DataRowView)cmPartyName.SelectedItem;
            AccountName = (string)dv.Row["Name"];
            AccountId = (int)dv.Row["Party-ID"];


            //int.TryParse(cmPartyName.SelectedValue.ToString(), out PId);
            //lblRemPartyRecBal.Text = "Revievable party Balance Rs." + new DAO().GetPartyBalance(PId).ToString();
            //lblRemPartyRecBal.Visible = true;
            //lblRemPartyRecBal.ForeColor = Color.Green;



            cmInvoiceNo.DataSource = new DAO().GetOrderIds(AccountId);
            cmInvoiceNo.DisplayMember = "OrderId";
            cmInvoiceNo.ValueMember = "OrderId";
            cmInvoiceNo.SelectedIndex = -1;





        }

        private void RecieptDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmInvoiceNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox cb = (ComboBox)sender;
            //if (!cb.Focused)
            //{
            //    return;
            //}
            //invoiceNo = this.cmInvoiceNo.GetItemText(this.cmInvoiceNo.SelectedItem);

            //lblRemInvBal.Text = "Remaining Rec Invoice Balance Rs." + new DAO().GetInvoiceBalance(invoiceNo).ToString();
            //lblRemInvBal.Visible = true;
            //lblRemInvBal.ForeColor = System.Drawing.Color.Green;



        }

        private void txtRecieptAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            //    &&
            //(e.KeyChar != '.'))

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void cmRecieptPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmRecieptPayment.SelectedIndex == 0)
            {
                txtChequeNo.Enabled = false;
                txtBankCode.Enabled = false;


            }
            else if (cmRecieptPayment.SelectedIndex == 1)
            {
                txtChequeNo.Enabled = true;
                txtBankCode.Enabled = true;


            }
        }

        private void AddReciept_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                owner.PerformRefresh();

            }
            catch (Exception ex)
            {


            }


        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            print = false;
            metroButton1_Click(sender, e);
        }
    }
}
