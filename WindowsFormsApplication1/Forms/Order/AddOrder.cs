using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
//using System.Runtime.InteropServices;
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

        //const int AW_SLIDE = 0X40000;
        //const int AW_HOR_POSITIVE = 0X1;
        //const int AW_HOR_NEGATIVE = 0X2;
        //const int AW_BLEND = 0X80000;

        //[DllImport("user32")]
        //static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        public static string OrderId = "";
        public static string DeliveryOrderNo = "";

        public static int LastOrderNo = 0;

        public static int index = 0;
        public static int amountTrnferRec = 0;
        public static int IId = 0;
        public static int ItemWtPerBag = 0;
        public static int RatePerKg = 0;
        public static  decimal SellingWt = 0;
        public static decimal SellingQty = 0;
        public static decimal Cost = 0;
        public static decimal TotalCost = 0;

        public static int BrokeryAmount = 0;
        public static decimal TotalQuantity = 0;
        public static decimal TotalWeight = 0;
        public static decimal NetWeight = 0;

        public static  string GardenName = "";
        public static string BrokerName = "";



        //public AddOrder(int orderNo)
        //{
        //    dtODate.MinDate =  DateTime.Today.Date;
        //    InitializeComponent();
        //    txtOrderNo.Text = orderNo.ToString();           
        //    DataTable dt = new DAO().GetOrderDetails(orderNo);
        //    //if (dt.Rows.Count != 0)
        //    //{
        //    //    btnCheckOut.Show();
        //    //}
        //    //else
        //    //{
        //    //    btnCheckOut.Hide();
        //    //}
        //    try
        //    {
        //        int cusid = int.Parse(dt.Rows[0][2].ToString());
        //        cbCustName.DataSource = new DAO().GetParties(int.Parse(dt.Rows[0][2].ToString()));
        //        cbCustName.DisplayMember = "Name";
        //        cbCustName.ValueMember = "Party-ID";
        //    }
        //    catch (Exception)
        //    {
        //        cbCustName.DataSource = new DAO().GetParties(1);
        //        cbCustName.DisplayMember = "Name";
        //        cbCustName.ValueMember = "Party-ID";

        //    }

        //    lblTotal.Text = new DAO().getTotal(orderNo).ToString();
        //    getItems();
        //}

        AllOrders owner;

        public AddOrder(AllOrders frm1)
        {


            owner = frm1;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddOrder_FormClosing);
            InitializeComponent();
        }

        //void getItems()
        //{
        //    cbItems.DataSource = new DAO().GetItems();
        //    cbItems.DisplayMember = "IName";
        //    cbItems.ValueMember = "IId";
        //    cbItems.SelectedIndex = -1;
        //    try
        //    {
        //        lblCost.Text = new DAO().getCost(int.Parse(cbItems.SelectedValue.ToString())).ToString();
        //        lblSubtotal.Text = new DAO().getCost(int.Parse(cbItems.SelectedValue.ToString())).ToString();
        //        lblTotalQty.Text = new DAO().getQty(int.Parse(cbItems.SelectedValue.ToString())).ToString();

        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    string[] postSource = new DAO().GetItems()
        //    .AsEnumerable()
        //    .Select<System.Data.DataRow, String>(x => x.Field<String>("IGarden"))
        //    .ToArray();
        //    var source = new AutoCompleteStringCollection();
        //    source.AddRange(postSource);
        //    cbItems.AutoCompleteCustomSource = source;
        //    cbItems.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    cbItems.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //}




        //void getMaxOrderNumber()
        //{
        //    int orderno = new DAO().getMaxOrderOderNo() + 1;
        //    txtOrderNo.Text = orderno.ToString();
        //}
        //void getCustomers()
        //{
        //    cbCustName.DataSource = new DAO().GetParties();
        //    cbCustName.DisplayMember = "Name";
        //    cbCustName.ValueMember = "Party-ID";
        //    string[] postSource = new DAO().GetParties()
        //            .AsEnumerable()
        //            .Select<System.Data.DataRow, String>(x => x.Field<String>("Name"))
        //            .ToArray();
        //    var source = new AutoCompleteStringCollection();
        //    source.AddRange(postSource);
        //    cbCustName.AutoCompleteCustomSource = source;
        //    cbCustName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    cbCustName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //}

        //private void nmQty_ValueChanged(object sender, EventArgs e)
        //{
            

        //    int cost = int.Parse(lblCost.Text);
        //    int qty = Convert.ToInt16(nmQty.Value);
        //    lblSubtotal.Text = (cost * qty).ToString();

            

        //}

        private void mtCreate_Click(object sender, EventArgs e)
        {
            txtShortage.Text = "0";

            try
            {
                //int itemid = int.Parse(cbItems.SelectedValue.ToString());

                //if (Convert.ToInt32(txtSellingQty.Text) > Convert.ToInt32(new DAO().getQty(itemid)))
                //{
                //    MessageBox.Show("cannot order item more than available in stock");
                //    return;
                    
                //}

                

                if (txtSellingWt.Text != "" && dtODate.Text != "" && cmLotNo.SelectedIndex != -1 &&  txtSellingQty.Text  != "" && cbCustName.SelectedIndex != -1  && txtRatePerKg.Text != "")
                {

                    TotalCost = Cost + int.Parse(txtBardena.Text) + int.Parse(txtTulai.Text) + int.Parse(txtCarrage.Text);
                    int BId = 2;

                    if (cmBrokerName.SelectedIndex != -1)
                    {

                        DataRowView dv3 = (DataRowView)cmBrokerName.SelectedItem;

                        BId = (int)dv3.Row["BId"];
                        BrokerName = (string)dv3.Row["BrokerName"];
                        int BroAccountId = new DAO().GetAccountId(BrokerName);
                        BrokeryAmount = int.Parse(txtBrokeryAmount.Text);
                        new DAO().AddGlTransactions(DateTime.Today.Date, "BrokeryAmount" , BroAccountId, "Debit", OrderId, 0, BrokeryAmount, 00);

                    }
                    DataRowView dv = (DataRowView)cbCustName.SelectedItem;
                    string AccountName = (string)dv.Row["Name"];
                    int AccountId = (int)dv.Row["Party-ID"];


                    //      amountTrnferRec = int.Parse(lblSubtotal.Text);
                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();

                    SqlDataAdapter dad = new SqlDataAdapter("Insert into Orders(OrderId,OrderNo,ODate,AccountId,IId,Qty,RatePerKg,Cost,AmountPaid,Status,BId,BrokeryAmount,Bardena,Tulai,Carrage,Shortage,SellingWeight,DoNo,TotalCost) values(@orderId,@orderno, @orderdate,@AccountId,@itemid,@qty,@RatePerKg,@Cost,0,'NotPaid',@BId,@BrokeryAmount,@Bardena,@Tulai,@Carage,@Shortage,@SellingWeight,@DeliveryOrderNo,@TotalCost)", conn);

                    dad.SelectCommand.Parameters.AddWithValue("@orderId", OrderId);
                    dad.SelectCommand.Parameters.AddWithValue("@orderno", LastOrderNo);
                    dad.SelectCommand.Parameters.AddWithValue("@orderdate", dtODate.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@AccountId", AccountId);
                    dad.SelectCommand.Parameters.AddWithValue("@itemid", cmLotNo.SelectedValue);
                    dad.SelectCommand.Parameters.AddWithValue("@qty", SellingQty);
                    dad.SelectCommand.Parameters.AddWithValue("@RatePerKg", RatePerKg);
                    dad.SelectCommand.Parameters.AddWithValue("@Cost", Cost);
                    dad.SelectCommand.Parameters.AddWithValue("@BId", BId);
                    dad.SelectCommand.Parameters.AddWithValue("@BrokeryAmount", BrokeryAmount);
                    dad.SelectCommand.Parameters.AddWithValue("@Bardena", int.Parse(txtBardena.Text));
                    dad.SelectCommand.Parameters.AddWithValue("@Tulai", int.Parse(txtTulai.Text));
                    dad.SelectCommand.Parameters.AddWithValue("@Carage", int.Parse(txtCarrage.Text));
                    dad.SelectCommand.Parameters.AddWithValue("@Shortage", int.Parse(txtShortage.Text));
                    dad.SelectCommand.Parameters.AddWithValue("@SellingWeight", SellingWt);
                    dad.SelectCommand.Parameters.AddWithValue("@DeliveryOrderNo", DeliveryOrderNo);
                    dad.SelectCommand.Parameters.AddWithValue("@TotalCost", TotalCost);



                    dad.Fill(dt);
                    conn.Close();
                    lblmsg.Text = "Order Added Successfully!!";
                    //int PId = int.Parse(cbCustName.SelectedValue.ToString());

                    //decimal PartyBalance = new DAO().GetPartyBalance(PId);

                    //new DAO().UpdatePartyBalance(PId, TotalCost + PartyBalance);

                    //lblTotal.Text = new DAO().getTotal(int.Parse(txtOrderNo.Text)).ToString();
                    //int itemid = int.Parse(cbItems.SelectedValue.ToString());

                    //int quan = Convert.ToInt32(Math.Round(nmQty.Value, 0));


                    decimal qty = new DAO().getQty(IId) - SellingQty;

                    new DAO().RemoveQty(qty, IId);



                    decimal weight = TotalWeight - SellingWt;

                    new DAO().RemoveWt(weight, IId);



                    //Clear_Limited();

                    // lblTotalQty.Text = new DAO().getQty(itemid).ToString();

                    //string AccountName = this.cbCustName.GetItemText(this.cbCustName.SelectedItem);
                    //string itemName = this.cbItems.GetItemText(this.cbItems.SelectedItem);

                    //int AccountId = new DAO().GetAccountId(AccountName);

                       new DAO().AddGlTransactions(DateTime.Today.Date, "sold " + GardenName + " " + TotalQuantity , 7, "Debit", OrderId,0, TotalCost, 00);
                       new DAO().AddGlTransactions(DateTime.Today.Date, "sold " + GardenName + " " + TotalQuantity, 4, "Credit", OrderId, TotalCost, 0, 00);
                       new DAO().AddGlTransactions(DateTime.Today.Date, "sold " + GardenName + " " + TotalQuantity, AccountId , "Debit", OrderId, 0, TotalCost, 00);

                    // index  =   cbCustName.SelectedIndex;





                    //btnCheckOut.Show();

                    RequestOrderPayment obj = new RequestOrderPayment();
                    obj.Show();
                    btnPrintInvoice.Visible = true;
                    btnPrintDeliveryOrder.Visible = true;




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
            LastOrderNo = new DAO().getLastOrderNo() + 1;
            OrderId = "Sl" + LastOrderNo;
            DeliveryOrderNo = "DO" + LastOrderNo;

            txtOrderNo.Text = OrderId.ToString();
            txtOrderNo.Enabled = false;


            txtNetWeight.Text = "";
            txtSellingQty.Text = "";
            txtSellingWt.Text = "";
            txtRatePerKg.Text = "0";
            txtShortage.Text = "";
            txtCarrage.Text = "0";
            cmLotNo.SelectedIndex = -1;
            cmBrokerName.SelectedIndex = -1;
            cbCustName.SelectedIndex = -1;
            txtGarden.Text = "";
            txtQtyLeft.Text = "";
            txtWtLeft.Text = "";
            txtWtPerBag.Text = "";
            txtTotal.Text = "0";
            txtGrade.Text = "";


            txtBrokeryAmount.Text = "0";
            txtBardena.Text = "0";



        }

        //void Clear_Limited()
        //{
        //    nmQty.Value = 1;
        //}
        //void Clear_All()
        //{
        //    int orderno = int.Parse(txtOrderNo.Text);
        //    txtOrderNo.Text = (orderno + 1).ToString();
        //    cbCustName.SelectedIndex = 0;
        //    cbItems.SelectedIndex = 0;
        //    nmQty.Value = 1;
        //    lblTotal.Text = "0";
        //    btnPrintInvoice.Visible = false;
        //}



        private void AddOrder_Load(object sender, EventArgs e)
        {
            cmLotNo.DataSource = new DAO().GetLotNoS();
            cmLotNo.DisplayMember = "LotNo";
            cmLotNo.ValueMember = "IId";
            cmLotNo.SelectedIndex = -1;


            LastOrderNo = new DAO().getLastOrderNo() + 1;
            OrderId = "Sl" + LastOrderNo;
            DeliveryOrderNo = "DO" + LastOrderNo;

            txtOrderNo.Text = OrderId.ToString();
            txtOrderNo.Enabled = false;

            cmBrokerName.DataSource = new DAO().GetBrokers();
            cmBrokerName.DisplayMember = "BrokerName";
            cmBrokerName.ValueMember = "BId";
            cmBrokerName.SelectedIndex = -1;


            cbCustName.DataSource = new DAO().GetPartiesFrmAccount();
            cbCustName.DisplayMember = "Name";
            cbCustName.ValueMember = "Party-ID";
            cbCustName.SelectedIndex = -1;


            //TxtitemPrice.Text = 0.ToString();
            //txtItemQuantity.Text = 0.ToString();
            txtBrokeryAmount.Text = "0";
            txtRatePerKg.Text = "0";
            //txtShortage.Text = "0";
            txtBardena.Text = "0";
            txtTulai.Text = "0";
            txtCarrage.Text = "0";

            //txtWeightPerBag.Text = "0";




            //dtODate.MinDate = DateTime.Today.Date;
        }

        //private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        lblCost.Text = new DAO().getCost(int.Parse(cbItems.SelectedValue.ToString())).ToString();
        //        lblSubtotal.Text = new DAO().getCost(int.Parse(cbItems.SelectedValue.ToString())).ToString();
        //        lblTotalQty.Text = new DAO().getQty(int.Parse(cbItems.SelectedValue.ToString())).ToString();
        //        if (lblTotalQty.Text.Equals("0"))
        //        {
        //            mtCreate.Hide();
        //        }
        //        else
        //        {
        //            mtCreate.Show();
        //        }
        //        nmQty.Value = 1;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        //private void mtCart_Click(object sender, EventArgs e)
        //{
        //    frmCart frmc = new frmCart(int.Parse(txtOrderNo.Text));
        //    frmc.Show();
        //    Dispose();
        //}

        //private void mtRefresh_Click(object sender, EventArgs e)
        //{
        //    lblTotal.Text = new DAO().getTotal(int.Parse(txtOrderNo.Text)).ToString();
        //    lblTotalQty.Text = new DAO().getQty(int.Parse(cbItems.SelectedValue.ToString())).ToString();
        //}

        //private void mtBack_Click(object sender, EventArgs e)
        //{

        //    this.Dispose();
        //    Main frm = new Main();
        //    frm.Show();
        //}

        //private void btnCheckOut_Click(object sender, EventArgs e)
        //{
        //    //try
        //    //{
        //    //    int PId = int.Parse(cbCustName.SelectedValue.ToString());
        //    //    int amount = int.Parse(lblTotal.Text);
        //    //    int balance = amount - int.Parse(txtPay.Text);



        //    //    int pay = int.Parse(txtPay.Text);

        //    //    if (pay > amount)
        //    //    {
        //    //        lblCashBack.ForeColor = Color.Green;
        //    //        lblCashBack.Text = "Cash Back: " + (pay - amount).ToString();
        //    //        balance = 0;
        //    //    }

        //    //    int RemainingBalance  = new DAO().GetPartyBalance(PId);
        //    //    new DAO().AddGlTransactions(DateTime.Today.Date, "Sales", 4, "Dr", "ORD" + txtOrderNo.Text, int.Parse(lblTotal.Text), 00);
        //    //    new DAO().AddGlTransactions(DateTime.Today.Date, "Recievables", 6, "Cr", "ORD" + txtOrderNo.Text, int.Parse(lblTotal.Text), 00);

        //    //    //new DAO().AddOrderTransaction(PId, pay, 0, int.Parse(cbItems.SelectedValue.ToString()), int.Parse(nmQty.Value.ToString()), "NA", DateTime.Today.Date, 0, RemainingBalance + balance);
        //    //    new DAO().UpdatePartyBalance(PId, RemainingBalance + balance);


        //    //    //new DAO().AddCustomerPayment(dtODate.Text, cid, balance, amount);
        //    //    lblBalance.ForeColor = Color.Green;
        //    //    lblBalance.Text = "Checkout Successfull wtih remaining balance : " + balance;
        //    //    txtPay.Text = "";
        //    //    btnCheckOut.Hide();
        //    //    //CheckOutSlip cs = new CheckOutSlip(int.Parse(txtOrderNo.Text));
        //    //    //cs.Show();

        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //   // MessageBox.Show(ex.Message);
        //    //}

        //}

        //private void txtPay_TextChanged(object sender, EventArgs e)
        //{

        //}

        ////private void txtPay_KeyPress(object sender, KeyPressEventArgs e)
        ////{
        ////    if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == 32)
        ////    {
        ////        e.Handled = false;
        ////    }
        ////    else
        ////    {
        ////        e.Handled = true;
        ////        System.Media.SystemSounds.Beep.Play();
        ////        lblmsg.Text = "Wrong Input!  Error";
        ////    }
        ////}

        //private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        //{

        //}

        //private void dtODate_ValueChanged(object sender, EventArgs e)
        //{

        //}

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
           
            invoiceprint obj2 = new invoiceprint();
            obj2.WindowState = FormWindowState.Maximized;

            obj2.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            //new DAO().GetItemsforOrder()


        }

        private void cmLotNo_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox cb = (ComboBox)sender;

            if (!cb.Focused)
            {
                return;
            }

            DataRowView dv = (DataRowView)cmLotNo.SelectedItem;
            IId = (int)dv.Row["IId"];


            DataTable dt2  = new DAO().GetItemsforOrder(IId);


            GardenName = dt2.Rows[0]["IGarden"].ToString();
            txtGarden.Text = GardenName;

            txtGrade.Text   = dt2.Rows[0]["IGrade"].ToString();

            TotalQuantity = decimal.Parse(dt2.Rows[0]["IQty"].ToString());
            txtQtyLeft.Text = TotalQuantity.ToString();

            ItemWtPerBag  = int.Parse( dt2.Rows[0]["IWtPerBag"].ToString());
            txtWtPerBag.Text = ItemWtPerBag.ToString();

            TotalWeight = int.Parse(dt2.Rows[0]["ITotalWeight"].ToString());
            txtWtLeft.Text = TotalWeight.ToString();
            
            txtQtyLeft.Enabled = false;
            txtWtLeft.Enabled = false;
            txtWtPerBag.Enabled = false;



        }

        private void txtSellingQty_Leave(object sender, EventArgs e)
        {
            if (txtSellingQty.Text == " ")
            {
                //txtNetWeight.Text = "";
                txtNetWeight.Text = txtSellingWt.Text;

                return;
            }
            //TextBox cb = (TextBox)sender;

            //if (!cb.Focused)
            //{
            //    return;
            //}

            SellingQty = Convert.ToInt32(txtSellingQty.Text);

            if (SellingQty > Convert.ToInt32(new DAO().getQty(IId)))
            {
                txtSellingQty.Text = "";

                MessageBox.Show("cannot order item more than available in stock");
                return;

            }
            else
            {

                SellingWt = ItemWtPerBag * SellingQty;
                txtSellingWt.Text = SellingWt.ToString();

                if(txtShortage.Text != "")
                {
                    NetWeight = SellingWt - Decimal.Parse(txtShortage.Text);
                    txtNetWeight.Text = NetWeight.ToString();
                    txtNetWeight.Enabled = false;

                }
                else
                {
                    NetWeight = SellingWt ;
                    txtNetWeight.Text = NetWeight.ToString();
                    txtNetWeight.Enabled = false;

                }

            }



        }

        private void txtShortage_Leave(object sender, EventArgs e)
        {
            if(txtShortage.Text == "")
            {
                //txtNetWeight.Text = "";
                txtNetWeight.Text = txtSellingWt.Text;

                return;
            }

            if(Decimal.Parse(txtShortage.Text) >= SellingWt)
            {
                txtShortage.Text = "";

                MessageBox.Show("shortage cannot be more than or equal to selling weight");

                return;


            }
            else
            {
                NetWeight = SellingWt - Decimal.Parse(txtShortage.Text);
                txtNetWeight.Text = NetWeight.ToString();
                txtNetWeight.Enabled = false;
            }

        }

        private void txtRatePerKg_MouseLeave(object sender, EventArgs e)
        {
            RatePerKg = int.Parse(txtRatePerKg.Text);
            if (RatePerKg > 0)
            {
                Cost = RatePerKg * NetWeight;
                txtTotal.Text = Cost.ToString(); 
            }
        }

        private void mtBack_Click(object sender, EventArgs e)
        {

            //bool IsOpen = false;
            //FormCollection fc = Application.OpenForms;

            //foreach (Form f in fc)
            //{

            //    if (f.Name == "Main")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}

            //if (IsOpen == true)
            //{

            //}

            //this.Hide();
            //Home f1obj = new Home();
            AllOrders obj = new AllOrders();
            obj.WindowState = FormWindowState.Maximized;

            obj.Show();
            this.Hide();

            //this.Close();
            

        }

        //protected override void OnLoad(EventArgs e)
        //{
        //    //Load the Form At Position of Main Form
        //    int WidthOfMain = Application.OpenForms["Main"].Width;
        //    int HeightofMain = Application.OpenForms["Main"].Height;
        //    int LocationMainX = Application.OpenForms["Main"].Location.X;
        //    int locationMainy = Application.OpenForms["Main"].Location.Y;

        //    //Set the Location
        //    this.Location = new Point(LocationMainX + WidthOfMain, locationMainy + 10);
        //    //this.BackgroundImage = Application.OpenForms["Home"].BackgroundImage;

        //    //Animate form
        //    AnimateWindow(this.Handle, 500, AW_SLIDE | AW_HOR_POSITIVE);
        //}

        private void txtSellingWt_Leave(object sender, EventArgs e)
        {

            if (txtSellingWt.Text == "")
            {
                //txtNetWeight.Text = "";
                txtNetWeight.Text = txtSellingWt.Text;

                return;
            }

            SellingWt = Convert.ToDecimal(txtSellingWt.Text);

            if (SellingWt > TotalWeight )
            {
                txtSellingWt.Text = "";

                MessageBox.Show("cannot order item more than available in stock");
                return;

            }
            else
            {

                SellingQty = SellingWt / ItemWtPerBag;
                txtSellingQty.Text = SellingQty.ToString();

                if (txtShortage.Text != "")
                {
                    txtNetWeight.Text = Convert.ToString(SellingWt - Decimal.Parse(txtShortage.Text));
                    txtNetWeight.Enabled = false;

                }
                else
                {
                    txtNetWeight.Text = SellingWt.ToString();
                }

            }

        }

        private void AddOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.PerformRefresh();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            DeliveryOrderPrint obj3 = new DeliveryOrderPrint();
            obj3.WindowState = FormWindowState.Maximized;

            obj3.Show();


        }

        private void txtSellingQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // Allow Digits and BackSpace char
            }
            else if (e.KeyChar == '.' && !((MetroFramework.Controls.MetroTextBox)sender).Text.Contains('.'))
            {
                //Allows only one Dot Char
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSellingWt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // Allow Digits and BackSpace char
            }
            else if (e.KeyChar == '.' && !((MetroFramework.Controls.MetroTextBox)sender).Text.Contains('.'))
            {
                //Allows only one Dot Char
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtShortage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // Allow Digits and BackSpace char
            }
            else if (e.KeyChar == '.' && !((MetroFramework.Controls.MetroTextBox)sender).Text.Contains('.'))
            {
                //Allows only one Dot Char
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtRatePerKg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // Allow Digits and BackSpace char
            }
            else if (e.KeyChar == '.' && !((MetroFramework.Controls.MetroTextBox)sender).Text.Contains('.'))
            {
                //Allows only one Dot Char
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtBrokeryAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // Allow Digits and BackSpace char
            }
            else if (e.KeyChar == '.' && !((MetroFramework.Controls.MetroTextBox)sender).Text.Contains('.'))
            {
                //Allows only one Dot Char
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtBardena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // Allow Digits and BackSpace char
            }
            else if (e.KeyChar == '.' && !((MetroFramework.Controls.MetroTextBox)sender).Text.Contains('.'))
            {
                //Allows only one Dot Char
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTulai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // Allow Digits and BackSpace char
            }
            else if (e.KeyChar == '.' && !((MetroFramework.Controls.MetroTextBox)sender).Text.Contains('.'))
            {
                //Allows only one Dot Char
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCarrage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // Allow Digits and BackSpace char
            }
            else if (e.KeyChar == '.' && !((MetroFramework.Controls.MetroTextBox)sender).Text.Contains('.'))
            {
                //Allows only one Dot Char
            }
            else
            {
                e.Handled = true;
            }
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
