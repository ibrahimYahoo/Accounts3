using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Code;

namespace WindowsFormsApplication1.Forms.Setttings
{
    public partial class AccountChart : MetroFramework.Forms.MetroForm
    {
        string AccountType = "";

        public AccountChart()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AccountChart_Load(object sender, EventArgs e)
        {
            gvAccountChart.DataSource = new DAO().GetAccountChartEntries();

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings obj = new Settings();
            obj.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            try
            {

                Button clickedButton = sender as Button;

                if (clickedButton == null)
                {
                    return;

                } // just to be on the safe side

                //if (txtAccounName.Text == "")
                //{
                //    MessageBox.Show("please enter account name");
                //    return;

                //} // just to be on the safe side



                List<string> list = new List<string>();
                if (clickedButton.Name == "btnAsset")
                {
                    txtAccounName.Text = "";
                    txtAccounName.Visible = true;
                    btnAddAccName.Visible = true;
                    cmDetailType.Visible = true;
                    AccountType = "ASSET";
                    lblconfirm.Text = "";

                    lblAccHeader.Visible = true;
                    lblAccHeader.Text = "Add An Asset Account";



                    list = new List<string>(new string[] { "Bank","Cash Or Cash Equivalent", "Fixed Asset", "CurrentAsset","Other Asset" });


                    cmDetailType.DataSource = list;
                    cmDetailType.SelectedIndex = -1;






                }
                else if (clickedButton.Name == "btnIncome")
                {
                    txtAccounName.Text = "";

                    txtAccounName.Visible = true;
                    btnAddAccName.Visible = true;
                    cmDetailType.Visible = true;

                    AccountType = "INCOME";
                    lblAccHeader.Visible = true;
                    lblAccHeader.Text = "Add An Income Account";

                    lblconfirm.Text = "";
                    list = new List<string>(new string[] { " Sales  Product/Service", "Investment", "Commission","Other Income" });


                    cmDetailType.DataSource = list;
                    cmDetailType.SelectedIndex = -1;




                }
                else if (clickedButton.Name == "btnExpense")
                {
                    txtAccounName.Text = "";

                    txtAccounName.Visible = true;
                    btnAddAccName.Visible = true;
                    cmDetailType.Visible = true;

                    list = new List<string>(new string[] { " Cost of Goods", "Expense" });
                    cmDetailType.DataSource = list;
                    cmDetailType.SelectedIndex = -1;
                    lblAccHeader.Visible = true;
                    lblAccHeader.Text = "Add An Expense Account";


                    AccountType = "EXPENSE";

                    lblconfirm.Text = "";


                }
                else
                {
                    txtAccounName.Text = "";

                    txtAccounName.Visible = true;
                    btnAddAccName.Visible = true;
                    cmDetailType.Visible = true;

                    lblAccHeader.Visible = true;
                    lblAccHeader.Text = "Add A Liability Account";


                    AccountType = "LIABILITY";
                    lblconfirm.Text = "";
                    list = new List<string>(new string[] { " Credit Card", "Loan", "Payroll", "Taxes Payable","Other Liability" });
                    cmDetailType.DataSource = list;
                    cmDetailType.SelectedIndex = -1;



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }



        }

        private void btnAddAccName_Click(object sender, EventArgs e)
        {
            if (txtAccounName.Text == "" || cmDetailType.SelectedIndex == -1)
            {
                MessageBox.Show("please fill all boxes");
                return;

            } // just to be on the safe side



            try
            {

                new DAO().AddDboAccount(txtAccounName.Text, AccountType, cmDetailType.SelectedItem.ToString());
                gvAccountChart.DataSource = new DAO().GetAccountChartEntries();
                lblconfirm.Text =  AccountType + "Account Added!!";

                txtAccounName.Text = "";
                txtAccounName.Visible = false;
                btnAddAccName.Visible = false;
                cmDetailType.Visible = false;
                lblAccHeader.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } 
        }
    }
}
