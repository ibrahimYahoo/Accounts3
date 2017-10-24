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

namespace WindowsFormsApplication1.Forms.Journals
{
    public partial class AddJournal : MetroFramework.Forms.MetroForm
    {
        string JournalId = "J" + new DAO().getLastJournalNo();

        public AddJournal()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void AddJournal_Load(object sender, EventArgs e)
        {
            //cmDebitAccount.DataSource = new DAO().GetAccountNames();
            //cmCreditAccount.DataSource = new DAO().GetAccountNames();

            GroupedComboBox groupedCombo = new GroupedComboBox();


            //groupedCombo.ValueMember = "Value";
            //groupedCombo.DisplayMember = "Display";
            //groupedCombo.GroupMember = "Group";




            //cmDebitAccount.DataSource = new DAO().GetAccountNames();
            //cmDebitAccount.DisplayMember = "AccountName";
            //cmDebitAccount.ValueMember = "AccountId";            //cmDebitAccount.GroupMember = "Group";
            //cmDebitAccount.DataSource = new BindingSource(groupedItems, String.Empty);


            cmDebitAccount.ValueMember = "AccountId";
            cmDebitAccount.DisplayMember = "AccountName";
            cmDebitAccount.GroupMember = "AccountType";
            cmDebitAccount.DataSource = new BindingSource(new DAO().GetfullAccountNames(), String.Empty);

            cmDebitAccount.SelectedIndex = -1;


            cmCreditAccount.ValueMember = "AccountId";
            cmCreditAccount.DisplayMember = "AccountName";
            cmCreditAccount.GroupMember = "AccountType";
            cmCreditAccount.DataSource = new BindingSource(new DAO().GetfullAccountNames(), String.Empty);

            //cmDebitAccount.SelectedIndex = -1;

            //cmCreditAccount.DataSource = new DAO().GetAccountNames();
            //cmCreditAccount.DisplayMember = "AccountName";
            //cmCreditAccount.ValueMember = "AccountId";
            //cmCreditAccount.SelectedIndex = -1;

            txtJournalId.Text = JournalId;




        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            //lblError.Visible = false;
            try
            {


                if (cmCreditAccount.SelectedIndex != -1 || cmDebitAccount.SelectedIndex != -1 || txtCredtiAmount.Text  != "" || txtDebitAmount.Text != "")
                {
                    if(txtDescription.Text == null)
                    {
                        txtDescription.Text = "";
                    }

                    if(txtDebitAmount.Text != txtCredtiAmount.Text)
                    {
                        lblError.Visible = true;
                        lblError.Text = "Debit and Credit Amount Needs to be same";
                        return;
                    }
                    else
                    {
                        lblError.Visible = false;
                    }


                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();

                    DataRowView dv = (DataRowView)cmDebitAccount.SelectedItem;
                    int DebitAccountId = (int)dv.Row["AccountId"];

                    DataRowView dv1 = (DataRowView)cmCreditAccount.SelectedItem;
                    int CreditAccountId = (int)dv1.Row["AccountId"];



                    SqlDataAdapter dad = new SqlDataAdapter("Insert into Journal(JournalId,Date,Description,DebitAccount,CreditAccount,DebitAmount,CreditAmount) values(@1,@2, @3,@4,@5,@6,@7)", conn);

                    dad.SelectCommand.Parameters.AddWithValue("@1", JournalId);
                    dad.SelectCommand.Parameters.AddWithValue("@2", dtDate.Value);
                    dad.SelectCommand.Parameters.AddWithValue("@3", txtDescription.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@4", DebitAccountId);
                    dad.SelectCommand.Parameters.AddWithValue("@5", CreditAccountId);
                    dad.SelectCommand.Parameters.AddWithValue("@6", int.Parse(txtDebitAmount.Text));
                    dad.SelectCommand.Parameters.AddWithValue("@7", int.Parse(txtCredtiAmount.Text));
                    dad.Fill(dt);
                    // lblmsg.Text = "Order Added Successfully!!";
                    //int PId = int.Parse(cbCustName.SelectedValue.ToString());
                    //int PartyBalance = new DAO().GetPartyBalance(PId);

                    //new DAO().UpdatePartyBalance(PId, int.Parse(lblSubtotal.Text) + PartyBalance);

                    //lblTotal.Text = new DAO().getTotal(int.Parse(txtOrderNo.Text)).ToString();
                    //int itemid = int.Parse(cbItems.SelectedValue.ToString());
                    //int qty = new DAO().getQty(itemid) - Convert.ToInt16(nmQty.Value);

                    //new DAO().RemoveQty(qty, itemid);
                    //Clear_Limited();

                    //lblTotalQty.Text = new DAO().getQty(itemid).ToString();

                    //string AccountName = this.cbCustName.GetItemText(this.cbCustName.SelectedItem);

                    //int AccountId = new DAO().GetAccountId(AccountName);
                    DataTable dt2 = new DataTable();
                    DataTable dt3 = new DataTable();



                    new DAO().AddGlTransactions(dtDate.Value, txtDescription.Text, DebitAccountId, "Debit", JournalId, 0,int.Parse(txtDebitAmount.Text), 00);
                    new DAO().AddGlTransactions(dtDate.Value, txtDescription.Text, CreditAccountId, "Credit", JournalId, int.Parse(txtCredtiAmount.Text),0, 00);
                    //new DAO().AddGlTransactions(DateTime.Today.Date, "Invoice " + "ORD" + txtOrderNo.Text + "-" + AccountName, AccountId, "Debit", "ORD" + txtOrderNo.Text, int.Parse(lblTotal.Text), 00);

                    string DebitDetailType = new DAO().GetAccountDetailType(DebitAccountId);
                    string CreditDetailType = new DAO().GetAccountDetailType(CreditAccountId);
                    decimal CashBookBalance = new DAO().GetCashBookBalance();


                    if (DebitDetailType != "")
                    {
                       SqlDataAdapter  dad1 = new SqlDataAdapter("Insert INTO CashBook(Date,ReferenceNo,Category,Description,AmountType,Income,Balance,InvoiceNo,PId) values (@3,@4,@5,@6,@7,@8,@9,@10,@11)", conn);
                        

                        dad1.SelectCommand.Parameters.AddWithValue("@3", dtDate.Value);
                        dad1.SelectCommand.Parameters.AddWithValue("@4", "");
                        dad1.SelectCommand.Parameters.AddWithValue("@5", "Journal Entry");
                        dad1.SelectCommand.Parameters.AddWithValue("@6", txtDescription.Text);
                        dad1.SelectCommand.Parameters.AddWithValue("@7", "");
                        dad1.SelectCommand.Parameters.AddWithValue("@8", Decimal.Parse(txtDebitAmount.Text));
                        dad1.SelectCommand.Parameters.AddWithValue("@9", CashBookBalance + Decimal.Parse(txtDebitAmount.Text));
                        dad1.SelectCommand.Parameters.AddWithValue("@10", "");
                        dad1.SelectCommand.Parameters.AddWithValue("@11", "");

                        dad1.Fill(dt2);
                    }
                    if(CreditDetailType != "")
                    {


                        SqlDataAdapter dad3 = new SqlDataAdapter("Insert INTO CashBook(Date,ReferenceNo,Category,Description,AmountType,Expense,Balance,InvoiceNo,PId) values (@3,@4,@5,@6,@7,@8,@9,@10,@11)", conn);
                      

                        dad3.SelectCommand.Parameters.AddWithValue("@3", dtDate.Value);
                        dad3.SelectCommand.Parameters.AddWithValue("@4", "");
                        dad3.SelectCommand.Parameters.AddWithValue("@5", "Journal Entry");
                        dad3.SelectCommand.Parameters.AddWithValue("@6", txtDescription.Text);
                        dad3.SelectCommand.Parameters.AddWithValue("@7", "");
                        dad3.SelectCommand.Parameters.AddWithValue("@8", Decimal.Parse(txtCredtiAmount.Text));
                        dad3.SelectCommand.Parameters.AddWithValue("@9", CashBookBalance - Decimal.Parse(txtCredtiAmount.Text));
                        dad3.SelectCommand.Parameters.AddWithValue("@10", "");
                        dad3.SelectCommand.Parameters.AddWithValue("@11", "");

                        dad3.Fill(dt3);

                    }




                    conn.Close();

                    //btnCheckOut.Show();

                    //RequestOrderPayment obj = new RequestOrderPayment();
                    //obj.Show();

                }
                else
                {
                    MessageBox.Show("Please fill the textboxes! ERROR!");
                }
            }
            catch (Exception ex)
            {
               // lblmsg.Text = ex.Message + "Stopped!";
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("journal added successfully");
        }

        private void txtDebitAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtCredtiAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            txtJournalId.Text = "J" + new DAO().getLastJournalNo();
            txtDescription.Text = "";
            txtDebitAmount.Text = "";
            txtCredtiAmount.Text = "";
        }
    }
}
