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
    public partial class AddReciept : MetroFramework.Forms.MetroForm
    {
        int PId;
        string invoiceNo;
        CashBook owner;


        public AddReciept(CashBook frm1)
        {
            owner = frm1;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddReciept_FormClosing);

            InitializeComponent();


            cmPartyName.DataSource = new DAO().GetParties();
            cmPartyName.DisplayMember = "Name";
            cmPartyName.ValueMember = "Party-ID";
            cmPartyName.SelectedIndex = -1;
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
            if(cmRecieptPayment.SelectedIndex == -1 || cmPartyName.SelectedIndex == -1 || String.IsNullOrEmpty(txtRecieptAmount.Text))
            {
                MessageBox.Show("please fill all textboxes first");

            }
            else
            {
                try
                {

                    DataTable dt = new DataTable();

                    SqlConnection conn = DBConn.GetInstance();
                    SqlDataAdapter dad = new SqlDataAdapter("",conn);
                    

                     try
                    {
                        invoiceNo = this.cmInvoiceNo.GetItemText(this.cmInvoiceNo.SelectedItem);


                    }
                    catch (Exception ex)
                    {
                        invoiceNo = "";

                    }

                    //if(invoiceNo != "")
                    //{

                    //}

                    string AccountName = this.cmPartyName.GetItemText(this.cmPartyName.SelectedItem);

                    int AccountId = new DAO().GetAccountId(AccountName);

                    int CashBookBalance = new DAO().GetCashBookBalance();

                    int.TryParse(cmPartyName.SelectedValue.ToString(), out PId);


                    //new DAO().UpdatePartyBalance(PId, int.Parse(lblSubtotal.Text) + PartyBalance);


                    //string partyName = new DAO().getPartyName()
                    if (cmRecieptPayment.SelectedItem.Equals("Cash"))
                    {
                        //   "Payment for Invoice " + invoiceNo + "-" + AccountName

                        dad = new SqlDataAdapter("Insert INTO CashBook(Date,ReferenceNo,Category,Description,AmountType,Income,Balance,InvoiceNo,PId) values (@3,@4,@5,@6,@7,@8,@9,@10,@11)", conn);
                        new DAO().AddGlTransactions(RecieptDatePicker.Value, txtRecieptNarration.Text, 1, "Debit",invoiceNo, int.Parse(txtRecieptAmount.Text), 00);
                        new DAO().AddGlTransactions(RecieptDatePicker.Value, txtRecieptNarration.Text, 7, "Credit", invoiceNo, int.Parse(txtRecieptAmount.Text), 00);
                        new DAO().AddGlTransactions(RecieptDatePicker.Value, txtRecieptNarration.Text, AccountId, "Credit", invoiceNo, int.Parse(txtRecieptAmount.Text), 00);

                        dad.SelectCommand.Parameters.AddWithValue("@3", RecieptDatePicker.Value);
                        dad.SelectCommand.Parameters.AddWithValue("@4", txtRefNo.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@5", "sales");
                        dad.SelectCommand.Parameters.AddWithValue("@6", txtRecieptNarration.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@7", this.cmRecieptPayment.GetItemText(this.cmRecieptPayment.SelectedItem));
                        dad.SelectCommand.Parameters.AddWithValue("@8", txtRecieptAmount.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@9", CashBookBalance + int.Parse(txtRecieptAmount.Text));
                        dad.SelectCommand.Parameters.AddWithValue("@10", invoiceNo);
                        dad.SelectCommand.Parameters.AddWithValue("@11", PId);
                    }
                    else if(cmRecieptPayment.SelectedItem.Equals("Cheque"))
                    {

                        dad = new SqlDataAdapter("Insert INTO CashBook(Date,ReferenceNo,Category,Description,AmountType,Income,Balance,InvoiceNo,ChequeNo,BankCode,PId) values (@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13)", conn);
                        new DAO().AddGlTransactions(RecieptDatePicker.Value, txtRecieptNarration.Text, 2, "Debit", invoiceNo, int.Parse(txtRecieptAmount.Text), 00);
                        new DAO().AddGlTransactions(RecieptDatePicker.Value, txtRecieptNarration.Text, 7, "Credit", invoiceNo, int.Parse(txtRecieptAmount.Text), 00);
                        new DAO().AddGlTransactions(RecieptDatePicker.Value, txtRecieptNarration.Text, AccountId, "Credit", invoiceNo, int.Parse(txtRecieptAmount.Text), 00);

                        dad.SelectCommand.Parameters.AddWithValue("@3", RecieptDatePicker.Value);
                        dad.SelectCommand.Parameters.AddWithValue("@4", txtRefNo.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@5", "sales");
                        dad.SelectCommand.Parameters.AddWithValue("@6", txtRecieptNarration.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@7", this.cmRecieptPayment.GetItemText(this.cmRecieptPayment.SelectedItem));
                        dad.SelectCommand.Parameters.AddWithValue("@8", txtRecieptAmount.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@9", CashBookBalance + int.Parse(txtRecieptAmount.Text));
                        dad.SelectCommand.Parameters.AddWithValue("@10", invoiceNo);
                        dad.SelectCommand.Parameters.AddWithValue("@11", txtChequeNo.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@12", txtBankCode.Text);
                        dad.SelectCommand.Parameters.AddWithValue("@13", PId);

                    }

                    // int PId = int.Parse(cmPartyName.SelectedValue.ToString());


                    int PartyBalance = new DAO().GetPartyBalance(PId);

                    new DAO().UpdateOwnerBalance(PId, PartyBalance - int.Parse(txtRecieptAmount.Text));

                    dad.Fill(dt);
                    conn.Close();


                    MessageBox.Show("Reciept addded");

                    new DAO().checkOrderSatus(invoiceNo, int.Parse(txtRecieptAmount.Text), PId);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }









        }

        private void AddReciept_Load(object sender, EventArgs e)
        {
           

            //cmInvoiceNo.DataSource = new DAO().GetOrderIds();
            //cmInvoiceNo.DisplayMember = "OrderId";
            //cmInvoiceNo.ValueMember = "OrderId";
            //cmInvoiceNo.SelectedIndex = -1;
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

            int.TryParse(cmPartyName.SelectedValue.ToString(), out PId);
            //lblRemPartyRecBal.Text = "Revievable party Balance Rs." + new DAO().GetPartyBalance(PId).ToString();
            //lblRemPartyRecBal.Visible = true;
            //lblRemPartyRecBal.ForeColor = Color.Green;



            cmInvoiceNo.DataSource = new DAO().GetOrderIds(PId);
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
    }
}
