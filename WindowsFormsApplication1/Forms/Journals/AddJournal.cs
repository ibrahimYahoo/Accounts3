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

            cmDebitAccount.DataSource = new DAO().GetAccountNames();
            cmDebitAccount.DisplayMember = "AccountName";
            cmDebitAccount.ValueMember = "AccountId";
            cmDebitAccount.SelectedIndex = -1;

            cmCreditAccount.DataSource = new DAO().GetAccountNames();
            cmCreditAccount.DisplayMember = "AccountName";
            cmCreditAccount.ValueMember = "AccountId";
            cmCreditAccount.SelectedIndex = -1;

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
                    


                   SqlDataAdapter dad = new SqlDataAdapter("Insert into Journal(JournalId,Date,Description,DebitAccount,CreditAccount,DebitAmount,CreditAmount) values(@1,@2, @3,@4,@5,@6,@7)", conn);

                    dad.SelectCommand.Parameters.AddWithValue("@1", JournalId);
                    dad.SelectCommand.Parameters.AddWithValue("@2", dtDate.Value);
                    dad.SelectCommand.Parameters.AddWithValue("@3", txtDescription.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@4", int.Parse(cmDebitAccount.SelectedValue.ToString()));
                    dad.SelectCommand.Parameters.AddWithValue("@5", int.Parse(cmCreditAccount.SelectedValue.ToString()));
                    dad.SelectCommand.Parameters.AddWithValue("@6", int.Parse(txtDebitAmount.Text));
                    dad.SelectCommand.Parameters.AddWithValue("@7", int.Parse(txtCredtiAmount.Text));
                    dad.Fill(dt);
                    conn.Close();
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

                    new DAO().AddGlTransactions(dtDate.Value, txtDescription.Text, int.Parse(cmDebitAccount.SelectedValue.ToString()), "Debit", JournalId, int.Parse(txtDebitAmount.Text), 00);
                    new DAO().AddGlTransactions(dtDate.Value, txtDescription.Text, int.Parse(cmCreditAccount.SelectedValue.ToString()), "Credit", JournalId, int.Parse(txtCredtiAmount.Text), 00);
                    //new DAO().AddGlTransactions(DateTime.Today.Date, "Invoice " + "ORD" + txtOrderNo.Text + "-" + AccountName, AccountId, "Debit", "ORD" + txtOrderNo.Text, int.Parse(lblTotal.Text), 00);


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
