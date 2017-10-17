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
using WindowsFormsApplication1.Dataseets;
using WindowsFormsApplication1.Reports;

namespace WindowsFormsApplication1.Forms.Order
{
    public partial class AddOrder : MetroFramework.Forms.MetroForm
    {

        public AddOrder(int orderNo)
        {
            dtODate.MinDate =  DateTime.Today.Date;
            InitializeComponent();
            txtOrderNo.Text = orderNo.ToString();           
            DataTable dt = new DAO().GetOrderDetails(orderNo);
            //if (dt.Rows.Count != 0)
            //{
            //    btnCheckOut.Show();
            //}
            //else
            //{
            //    btnCheckOut.Hide();
            //}
            try
            {
                int cusid = int.Parse(dt.Rows[0][2].ToString());
                cbCustName.DataSource = new DAO().GetParties(int.Parse(dt.Rows[0][2].ToString()));
                cbCustName.DisplayMember = "Name";
                cbCustName.ValueMember = "Party-ID";
            }
            catch (Exception)
            {
                cbCustName.DataSource = new DAO().GetParties(1);
                cbCustName.DisplayMember = "Name";
                cbCustName.ValueMember = "Party-ID";

            }

            lblTotal.Text = new DAO().getTotal(orderNo).ToString();
            getItems();
        }
        public AddOrder()
        {
            InitializeComponent();
            getMaxOrderNumber();
            getCustomers();
            getItems();
            dtODate.MinDate = DateTime.Today.Date;
            //btnCheckOut.Hide();
        }

        void getItems()
        {
            cbItems.DataSource = new DAO().GetItems();
            cbItems.DisplayMember = "IName";
            cbItems.ValueMember = "IId";
            cbItems.SelectedIndex = -1;
            try
            {
                lblCost.Text = new DAO().getCost(int.Parse(cbItems.SelectedValue.ToString())).ToString();
                lblSubtotal.Text = new DAO().getCost(int.Parse(cbItems.SelectedValue.ToString())).ToString();
                lblTotalQty.Text = new DAO().getQty(int.Parse(cbItems.SelectedValue.ToString())).ToString();

            }
            catch (Exception e)
            {

            }
            string[] postSource = new DAO().GetItems()
            .AsEnumerable()
            .Select<System.Data.DataRow, String>(x => x.Field<String>("IName"))
            .ToArray();
            var source = new AutoCompleteStringCollection();
            source.AddRange(postSource);
            cbItems.AutoCompleteCustomSource = source;
            cbItems.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbItems.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }




        void getMaxOrderNumber()
        {
            int orderno = new DAO().getMaxOrderOderNo() + 1;
            txtOrderNo.Text = orderno.ToString();
        }
        void getCustomers()
        {
            cbCustName.DataSource = new DAO().GetParties();
            cbCustName.DisplayMember = "Name";
            cbCustName.ValueMember = "Party-ID";
            string[] postSource = new DAO().GetParties()
                    .AsEnumerable()
                    .Select<System.Data.DataRow, String>(x => x.Field<String>("Name"))
                    .ToArray();
            var source = new AutoCompleteStringCollection();
            source.AddRange(postSource);
            cbCustName.AutoCompleteCustomSource = source;
            cbCustName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbCustName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void nmQty_ValueChanged(object sender, EventArgs e)
        {
            int cost = int.Parse(lblCost.Text);
            int qty = Convert.ToInt16(nmQty.Value);
            lblSubtotal.Text = (cost * qty).ToString();
        }

        private void mtCreate_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (lblCost.Text != "" && dtODate.Text != "" && cbItems.SelectedIndex != -1)
                {


                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();

                    SqlDataAdapter dad = new SqlDataAdapter("Insert into Orders(OrderId,OrderNo,ODate,PId,IId,Qty,Cost,TotalCost,AmountPaid,Status) values(@orderId,@orderno, @orderdate,@PId,@itemid,@qty,@cost,@totalcost,0,'NotPaid')", conn);

                    dad.SelectCommand.Parameters.AddWithValue("@orderId", "ORD" + txtOrderNo.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@orderno", txtOrderNo.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@orderdate", dtODate.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@PId", cbCustName.SelectedValue);
                    dad.SelectCommand.Parameters.AddWithValue("@itemid", cbItems.SelectedValue);
                    dad.SelectCommand.Parameters.AddWithValue("@qty", nmQty.Value);
                    dad.SelectCommand.Parameters.AddWithValue("@cost", lblCost.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@totalcost", lblSubtotal.Text);
                    dad.Fill(dt);
                    conn.Close();
                    lblmsg.Text = "Order Added Successfully!!";
                    int PId = int.Parse(cbCustName.SelectedValue.ToString());
                    int PartyBalance = new DAO().GetPartyBalance(PId);

                    new DAO().UpdatePartyBalance(PId, int.Parse(lblSubtotal.Text) + PartyBalance);

                    lblTotal.Text = new DAO().getTotal(int.Parse(txtOrderNo.Text)).ToString();
                    int itemid = int.Parse(cbItems.SelectedValue.ToString());
                    int qty = new DAO().getQty(itemid) - Convert.ToInt16( nmQty.Value);

                    new DAO().RemoveQty(qty, itemid);
                    Clear_Limited();

                    lblTotalQty.Text = new DAO().getQty(itemid).ToString();

                    string AccountName = this.cbCustName.GetItemText(this.cbCustName.SelectedItem);
                    string itemName = this.cbItems.GetItemText(this.cbItems.SelectedItem);

                    int AccountId = new DAO().GetAccountId(AccountName);

                       new DAO().AddGlTransactions(DateTime.Today.Date, "sold " + itemName + " " + nmQty.Value.ToString() , 7, "Debit", "ORD" + txtOrderNo.Text, int.Parse(lblTotal.Text), 00);
                       new DAO().AddGlTransactions(DateTime.Today.Date, "sold " + itemName + " " + nmQty.Value.ToString(), 4, "Credit", "ORD" + txtOrderNo.Text, int.Parse(lblTotal.Text), 00);
                       new DAO().AddGlTransactions(DateTime.Today.Date, "sold " + itemName + " " + nmQty.Value.ToString(), AccountId , "Debit", "ORD" + txtOrderNo.Text, int.Parse(lblTotal.Text), 00);


                    //btnCheckOut.Show();

                    RequestOrderPayment obj = new RequestOrderPayment();
                    obj.Show();

                }
                else
                {
                    lblmsg.Text = "Please fill the textboxes! ERROR!";
                }
            }
            catch (Exception ex)
            {
                lblmsg.Text = ex.Message + "Stopped!";
                //MessageBox.Show(ex.Message);
            }
        }

        private void mtNew_Click(object sender, EventArgs e)
        {
            Clear_All();
        }

        void Clear_Limited()
        {
            nmQty.Value = 1;
        }
        void Clear_All()
        {
            int orderno = int.Parse(txtOrderNo.Text);
            txtOrderNo.Text = (orderno + 1).ToString();
            cbCustName.SelectedIndex = 0;
            cbItems.SelectedIndex = 0;
            nmQty.Value = 1;
            lblTotal.Text = "0";
        }



        private void AddOrder_Load(object sender, EventArgs e)
        {
            dtODate.MinDate = DateTime.Today.Date;
        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblCost.Text = new DAO().getCost(int.Parse(cbItems.SelectedValue.ToString())).ToString();
                lblSubtotal.Text = new DAO().getCost(int.Parse(cbItems.SelectedValue.ToString())).ToString();
                lblTotalQty.Text = new DAO().getQty(int.Parse(cbItems.SelectedValue.ToString())).ToString();
                if (lblTotalQty.Text.Equals("0"))
                {
                    mtCreate.Hide();
                }
                else
                {
                    mtCreate.Show();
                }
                nmQty.Value = 1;
            }
            catch (Exception ex)
            {

            }
        }

        private void mtCart_Click(object sender, EventArgs e)
        {
            frmCart frmc = new frmCart(int.Parse(txtOrderNo.Text));
            frmc.Show();
            Dispose();
        }

        private void mtRefresh_Click(object sender, EventArgs e)
        {
            lblTotal.Text = new DAO().getTotal(int.Parse(txtOrderNo.Text)).ToString();
            lblTotalQty.Text = new DAO().getQty(int.Parse(cbItems.SelectedValue.ToString())).ToString();
        }

        private void mtBack_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Main frm = new Main();
            frm.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int PId = int.Parse(cbCustName.SelectedValue.ToString());
            //    int amount = int.Parse(lblTotal.Text);
            //    int balance = amount - int.Parse(txtPay.Text);



            //    int pay = int.Parse(txtPay.Text);

            //    if (pay > amount)
            //    {
            //        lblCashBack.ForeColor = Color.Green;
            //        lblCashBack.Text = "Cash Back: " + (pay - amount).ToString();
            //        balance = 0;
            //    }

            //    int RemainingBalance  = new DAO().GetPartyBalance(PId);
            //    new DAO().AddGlTransactions(DateTime.Today.Date, "Sales", 4, "Dr", "ORD" + txtOrderNo.Text, int.Parse(lblTotal.Text), 00);
            //    new DAO().AddGlTransactions(DateTime.Today.Date, "Recievables", 6, "Cr", "ORD" + txtOrderNo.Text, int.Parse(lblTotal.Text), 00);

            //    //new DAO().AddOrderTransaction(PId, pay, 0, int.Parse(cbItems.SelectedValue.ToString()), int.Parse(nmQty.Value.ToString()), "NA", DateTime.Today.Date, 0, RemainingBalance + balance);
            //    new DAO().UpdatePartyBalance(PId, RemainingBalance + balance);
                

            //    //new DAO().AddCustomerPayment(dtODate.Text, cid, balance, amount);
            //    lblBalance.ForeColor = Color.Green;
            //    lblBalance.Text = "Checkout Successfull wtih remaining balance : " + balance;
            //    txtPay.Text = "";
            //    btnCheckOut.Hide();
            //    //CheckOutSlip cs = new CheckOutSlip(int.Parse(txtOrderNo.Text));
            //    //cs.Show();

            //}
            //catch (Exception ex)
            //{
            //   // MessageBox.Show(ex.Message);
            //}

        }

        private void txtPay_TextChanged(object sender, EventArgs e)
        {

        }

        //private void txtPay_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == 32)
        //    {
        //        e.Handled = false;
        //    }
        //    else
        //    {
        //        e.Handled = true;
        //        System.Media.SystemSounds.Beep.Play();
        //        lblmsg.Text = "Wrong Input!  Error";
        //    }
        //}

        private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dtODate_ValueChanged(object sender, EventArgs e)
        {

        }

        //private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (txtDiscount.Text.Equals(""))
        //    {
        //        lblTotal.Text = new DAO().getTotal(int.Parse(txtOrderNo.Text)).ToString();
        //    }
        //    else
        //    {
        //        if (e.KeyChar == 13)
        //        {
        //            try
        //            {
        //                if (txtDiscount.Text.Equals(""))
        //                {
        //                    lblTotal.Text = new DAO().getTotal(int.Parse(txtOrderNo.Text)).ToString();
        //                }
        //                else
        //                {
        //                    int total = int.Parse(lblTotal.Text);
        //                    int discount = int.Parse(txtDiscount.Text);
        //                    lblTotal.Text = (total - discount).ToString();
        //                }

        //            }
        //            catch (Exception ex)
        //            {

        //            }
        //        }

        //    }
        //}


    }
}
