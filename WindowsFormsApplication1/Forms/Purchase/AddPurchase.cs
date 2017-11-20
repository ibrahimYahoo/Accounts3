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
using WindowsFormsApplication1.Forms.Purchase;

namespace WindowsFormsApplication1.Forms.Purchase
{
    public partial class AddPurchase : MetroFramework.Forms.MetroForm
    {
        Purchase.Purchases owner;
        public static decimal TotalWeight = 0;
        public static decimal TotalQuantity = 0;

        public static decimal NetWeight = 0;

        public static int IId = 0;
        DataTable dt = new DataTable();

        public static int LastPurchaseNo = 0;

        public static string GardenName = "";

        public static string PurchaseId = "";

        public static string Grade = "";
        public static decimal Shortage = 0;
        public static decimal RatePerKg = 0;
        public static decimal Cost = 0;
        public static decimal TotalCost = 0;
        public static decimal bardena = 0;
        public static decimal Tulai = 0;
        public static decimal Carrage = 0;


        public AddPurchase(Purchase.Purchases frm1)
        {
            owner = frm1;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPurchase_FormClosing);
            InitializeComponent();
        }

        public AddPurchase()
        {

            InitializeComponent();
        }

        private void AddPurchase_Load(object sender, EventArgs e)
        {

            LastPurchaseNo = new DAO().getLastPurchaseNo() + 1;


            PurchaseId = "PUR" + LastPurchaseNo;


            txtGardenName.AutoCompleteMode = AutoCompleteMode.Append;
            txtGardenName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtGardenName.AutoCompleteCustomSource = new DAO().GetGardens();

            cmbsuppname.DataSource = new DAO().GetPartiesFrmAccount();
            cmbsuppname.DisplayMember = "Name";
            cmbsuppname.ValueMember = "Party-ID";
            cmbsuppname.SelectedIndex = -1;


            //  cmGardenName.DataSource = new DAO().GetGardens();
            //  cmGardenName.DisplayMember = "IGarden";
            ////  cmGardenName.ValueMember = "IId";
            //  cmGardenName.SelectedIndex = -1;

            cmBrokerName.DataSource = new DAO().GetBrokers();
            cmBrokerName.DisplayMember = "BrokerName";
            cmBrokerName.ValueMember = "BId";
            cmBrokerName.SelectedIndex = -1;


            //TxtitemPrice.Text = 0.ToString();
            //txtItemQuantity.Text = 0.ToString();
            txtBrokeryAmount.Text = "0";
            txtRatePerKg.Text = "0";
            txtShortage.Text = "0";
            txtWeightPerBag.Text = "0";

            //txtoldpurprice.Text = "0";
        }



        private void btnadditem_Click(object sender, EventArgs e)
        {
            btnadditem.Enabled = false;
            try
            {
                if (txtLotNo.Text != "" && txtGardenName.Text != "" && txtGrade.Text != "" && txtTotalBagsQuantity.Text != "" && txtRatePerKg.Text != "0" && txtWeightPerBag.Text != "0")
                {


                    int LotNo = int.Parse(txtLotNo.Text);
                    DataRowView dv = (DataRowView)cmbsuppname.SelectedItem;
                    string AccountName = (string)dv.Row["Name"];
                    int AccountId = (int)dv.Row["Party-ID"];
                    string GardenName = txtGardenName.Text;
                    int BId = 2;
                    //int TotalQuantity = int.Parse(txtTotalBagsQuantity.Text);
                    // decimal TotalCost = Cost + int.Parse(txtBardena.Text) + int.Parse(txtTulai.Text) + int.Parse(txtCarrage.Text);
                    //int AccountId = new DAO().GetAccountId(AccountName);

                    new DAO().insertItem(LotNo, txtGrade.Text, GardenName, decimal.Parse(txtTotalBagsQuantity.Text), int.Parse(txtWeightPerBag.Text), int.Parse(txtRatePerKg.Text), Cost, NetWeight);


                    if (cmBrokerName.SelectedIndex != -1)
                    {

                        DataRowView dv3 = (DataRowView)cmBrokerName.SelectedItem;

                        BId = (int)dv3.Row["BId"];
                        //BrokerName = (string)dv3.Row["BrokerName"];
                        //int BroAccountId = new DAO().GetAccountId(BrokerName);
                        //BrokeryAmount = int.Parse(txtBrokeryAmount.Text);
                        //new DAO().AddGlTransactions(DateTime.Today.Date, "BrokeryAmount", BroAccountId, "Debit", OrderId, 0, BrokeryAmount, 00);

                    }
                    int IId = new DAO().getItemIdFromName(LotNo);





                    // int PId = int.Parse(cmbsuppname.SelectedValue.ToString());

                    //DataRowView dv2 = (DataRowView)cmGardenName.SelectedItem;                                  



                    //  decimal TotalWieght = (int.Parse(txtWeightPerBag.Text) * (int.Parse(txtTotalBagsQuantity.Text)));
                    //decimal Cost = RatePerKg * NetWeight;

                    //   decimal TotalCost = (int.Parse(txtRatePerKg.Text) * (int.Parse(txtWeightPerBag.Text) * TotalQuantity));
                    //decimal TotalWieght = (int.Parse(txtWeightPerBag.Text) * (int.Parse(txtNetWeight.Text)));






                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();
                    SqlDataAdapter dad = new SqlDataAdapter("Insert INTO Purchase(PurId,PurNo,IId,AccountId,PurDate,IRatePerKg,ItemQty,BrokeryAmount,BId,Bardena,Tulai,Carrage,Total,AmountPaid,Status,Cost,Shortage,TotalWeight,NetWeight) values (@PurId,@PurNo,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,0,'Notpaid',@Cost,@Shortage,@TotalWeight,@NetWeight)", conn);

                    dad.SelectCommand.Parameters.AddWithValue("@PurId", PurchaseId);
                    dad.SelectCommand.Parameters.AddWithValue("@PurNo", LastPurchaseNo);

                    dad.SelectCommand.Parameters.AddWithValue("@3", IId);
                    dad.SelectCommand.Parameters.AddWithValue("@4", AccountId);
                    dad.SelectCommand.Parameters.AddWithValue("@5", cmbpaydate.Value);
                    dad.SelectCommand.Parameters.AddWithValue("@6", RatePerKg);
                    dad.SelectCommand.Parameters.AddWithValue("@7", TotalQuantity);
                    dad.SelectCommand.Parameters.AddWithValue("@8", int.Parse(txtBrokeryAmount.Text));
                    dad.SelectCommand.Parameters.AddWithValue("@9", BId);
                    dad.SelectCommand.Parameters.AddWithValue("@10", txtBardena.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@11", txtTulai.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@12", txtCarrage.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@13", TotalCost);
                    dad.SelectCommand.Parameters.AddWithValue("@Cost", Cost);
                    dad.SelectCommand.Parameters.AddWithValue("@Shortage", Shortage);
                    dad.SelectCommand.Parameters.AddWithValue("@TotalWeight", TotalWeight);
                    dad.SelectCommand.Parameters.AddWithValue("@NetWeight", NetWeight);


                    //int balance = int.Parse(txttotal.Text) - int.Parse(txtAmountPaid.Text);

                    dad.Fill(dt);
                    conn.Close();



                    //string AccountName = this.cmbsuppname.GetItemText(this.cmbsuppname.SelectedItem);



                    //  decimal RemainingBalance = new DAO().GetPartyBalance(PId);

                    new DAO().AddGlTransactions(DateTime.Today.Date, "Purchased " + GardenName + " " + TotalQuantity, 5, "Debit", PurchaseId, 0, TotalCost, 00);
                    new DAO().AddGlTransactions(DateTime.Today.Date, "Purchased " + GardenName + " " + TotalQuantity, 8, "Credit", PurchaseId, TotalCost, 0, 00);
                    new DAO().AddGlTransactions(DateTime.Today.Date, "Purchased " + GardenName + " " + TotalQuantity, AccountId, "Credit", PurchaseId, TotalCost, 0, 00);


                    // new DAO().AddPurchaseTransaction(PId, 0, int.Parse(txtAmountPaid.Text), int.Parse(cmbItemname.SelectedValue.ToString()), int.Parse(txtItemQuantity.Text), "NA", DateTime.Today.Date, 1, RemainingBalance - balance);
                    //new DAO().UpdateQtyAdd(IId, TotalQuantity);
                    //new DAO().UpdateOwnerBalance(PId, RemainingBalance - TotalCost);


                    //MessageBox.Show("Purchase Inserted successfully");

                    //cmbsuppname.DataSource = new DAO().GetParties();
                    //cmbsuppname.DisplayMember = "Name";
                    //cmbsuppname.ValueMember = "Party-ID";
                    //cmbsuppname.SelectedIndex = -1;

                    //cmbItemname.DataSource = new DAO().GetItemsDesc();
                    //cmbItemname.DisplayMember = "Display";
                    //cmbItemname.ValueMember = "IId";
                    //cmbItemname.SelectedIndex = -1;

                    //txtLotNo.Text = 0.ToString();
                    //txtTotalBagsQuantity.Text = 0.ToString();
                    //TxtitemPrice.Text = 0.ToString();
                    //    gvPurchase.DataSource = new DAO().GetPurchases();
                    //    gvPurchase.Show();
                    //   lblqty.Visible = false;

                    RequestPurPay obj = new RequestPurPay();
                    obj.Show();
                    btnadditem.Enabled = true;

                }
                else
                {
                    btnadditem.Enabled = true;

                    MessageBox.Show("Please fill all the textboxes");
                }
            }
            catch (Exception ex)
            {
                btnadditem.Enabled = true;

                MessageBox.Show(ex.Message);
            }
        }

        //private void txtItemQuantity_Leave(object sender, EventArgs e)
        //{

        //    if (TxtitemPrice.Text == "")
        //    {
        //        TxtitemPrice.Text = 0.ToString();
        //    }
        //    try
        //    {

        //        txttotal.Text = (Convert.ToInt32(txtoldpurprice.Text) * Convert.ToInt32(txtItemQuantity.Text)).ToString();

        //    }

        //    catch (Exception)
        //    {
        //        MessageBox.Show("Please enter values correctly!");

        //    }
        //}



        private void btnclr_Click(object sender, EventArgs e)
        {
            txtLotNo.Text = "";
            txtRatePerKg.Text = "";
            txtShortage.Text = "";
            txtTotalBagsQuantity.Text = "";
            cmbpaydate.Text = "";
            cmbsuppname.SelectedIndex = -1;
            //cmGardenName.SelectedIndex = -1;
            txtGardenName.Text = "";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            //Main frm = new Main();
            //frm.Show();
        }

        //private void cmbItemname_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int x = 0;
        //        if (cmbItemname.SelectedIndex != -1)
        //        {
        //            bool parseOK = Int32.TryParse(cmbItemname.SelectedValue.ToString(), out x);
        //        }
        //        if (x != 0)
        //        {
        //            DataTable item = new DAO().ShowItemsByID(Convert.ToInt32(cmbItemname.SelectedValue));                  
        //            txtoldpurprice.Text = int.Parse(item.Rows[0][3].ToString()).ToString();
        //            //lblqty.Text = "Quantity left : " + Convert.ToString(item.Rows[0][6]);
        //            //lblqty.Show();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void cmbsuppname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtItemQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Wrong Input!", "Error");
            }
        }

        private void TxtitemPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Wrong Input!", "Error");
            }
        }

        private void txtoldpurprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Wrong Input!", "Error");
            }
        }

        //private void txtoldpurprice_Leave(object sender, EventArgs e)
        //{
        //    if (TxtitemPrice.Text == "")
        //    {
        //        TxtitemPrice.Text = 0.ToString();
        //    }
        //    try
        //    {

        //        txttotal.Text = (Convert.ToInt32(txtoldpurprice.Text) * Convert.ToInt32(txtItemQuantity.Text)).ToString();

        //    }

        //    catch (Exception)
        //    {
        //        MessageBox.Show("Please enter values correctly!");

        //    }
        //}

        private void AddPurchase_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.PerformRefresh();
        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void txtShortage_Leave(object sender, EventArgs e)
        {

            if (txtShortage.Text == "" || txtShortage.Text == "0")
            {
                NetWeight = TotalWeight;
                txtNetWeight.Text = NetWeight.ToString();
                txtNetWeight.Enabled = false;

                return;
            }


            Shortage = decimal.Parse(txtShortage.Text);


            if (Shortage.ToString() == "")
            {
                //txtNetWeight.Text = "";
                txtNetWeight.Text = txtTotalWeight.Text;

                return;
            }

            if (Shortage >= TotalWeight)
            {
                txtShortage.Text = "";

                MessageBox.Show("shortage cannot be more than or equal to selling weight");

                return;


            }
            else
            {
                NetWeight = TotalWeight - Shortage;
                txtNetWeight.Text = NetWeight.ToString();
                txtNetWeight.Enabled = false;
            }

        }


        private void txtLotNo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }




        private void txtLotNo_TextChanged(object sender, EventArgs e)
        {
            if (txtLotNo.Text == "")
            {
                txtGardenName.Text = "";
                txtGrade.Text = "";
                txtGardenName.Enabled = true;
                txtGrade.Enabled = true;
                return;

            }


            dt = new DAO().SearchLotNo(int.Parse(txtLotNo.Text));

            if (dt != null)
            {

                AsUpdateQty obj = new AsUpdateQty();
                obj.Show();



            }
            else
            {
                txtGardenName.Text = "";
                txtGrade.Text = "";
                txtGardenName.Enabled = true;
                txtGrade.Enabled = true;
            }
        }

        private void AddPurchase_Activated(object sender, EventArgs e)
        {
            if (AsUpdateQty.btnselected == 0)
            {
                try
                {
                    IId = int.Parse(dt.Rows[0]["IId"].ToString());

                }
                catch (Exception ex)
                {
                    return;
                }



                DataTable dt2 = new DAO().GetItemsforOrder(IId);


                GardenName = dt2.Rows[0]["IGarden"].ToString();
                txtGardenName.Text = GardenName;
                txtGardenName.Enabled = false;

                Grade = dt2.Rows[0]["IGrade"].ToString();
                txtGrade.Text = Grade;
                txtGrade.Enabled = false;


            }
            else if (AsUpdateQty.btnselected == 1)
            {
                txtLotNo.Text = "";
            }


        }

        private void txtRatePerKg_TextChanged(object sender, EventArgs e)
        {
            if (txtRatePerKg.Text == "" || txtRatePerKg.Text == " ")
            {
                return;
            }

            RatePerKg = decimal.Parse(txtRatePerKg.Text);
            Cost = RatePerKg * NetWeight;
            txtCost.Text = Cost.ToString();

        }

        private void txtBardena_TextChanged(object sender, EventArgs e)
        {
            if (txtBardena.Text == "" || txtBardena.Text == " ")
            {
                TotalCost = Cost + Tulai + Carrage;
                txtTotalCost.Text = TotalCost.ToString();

                return;
            }
            bardena = decimal.Parse(txtBardena.Text);
            TotalCost = Cost + bardena + Tulai + Carrage;
            txtTotalCost.Text = TotalCost.ToString();
        }

        private void txtTulai_TextChanged(object sender, EventArgs e)
        {
            if (txtTulai.Text == "" || txtTulai.Text == " ")
            {
                TotalCost = Cost + bardena + Carrage;
                txtTotalCost.Text = TotalCost.ToString();
                return;
            }
            Tulai = decimal.Parse(txtTulai.Text);
            TotalCost = Cost + bardena + Tulai + Carrage;
            txtTotalCost.Text = TotalCost.ToString();

        }

        private void txtCarrage_TextChanged(object sender, EventArgs e)
        {
            if (txtCarrage.Text == "" || txtCarrage.Text == " ")
            {
                TotalCost = Cost + bardena + Tulai;
                txtTotalCost.Text = TotalCost.ToString();

                return;
            }
            Carrage = decimal.Parse(txtCarrage.Text);
            TotalCost = Cost + bardena + Tulai + Carrage;
            txtTotalCost.Text = TotalCost.ToString();

        }


        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            if (txtCost.Text == "" || txtCost.Text == "0")
            {
                Cost = 0;
                TotalCost = Cost + bardena + Tulai + Carrage;
                txtTotalCost.Text = TotalCost.ToString();

                return;
            }

            Cost = decimal.Parse(txtCost.Text);
            TotalCost = Cost + bardena + Tulai + Carrage;
            txtTotalCost.Text = TotalCost.ToString();

        }

        private void txtWeightPerBag_TextChanged(object sender, EventArgs e)
        {

            if (txtWeightPerBag.Text == "" || txtWeightPerBag.Text == "0")
            {

                return;
            }

            TotalWeight = int.Parse(txtTotalBagsQuantity.Text) * int.Parse(txtWeightPerBag.Text);
            txtTotalWeight.Text = TotalWeight.ToString();

            if (txtShortage.Text != " " || txtShortage.Text != "")
            {
                NetWeight = TotalWeight - Shortage;
                txtNetWeight.Text = NetWeight.ToString();

            }
            else
            {
                txtNetWeight.Text = TotalWeight.ToString();
            }

            // txtNetWeight.Text = TotalWeight.ToString();

        }

        private void txtNetWeight_TextChanged(object sender, EventArgs e)
        {
            if (txtNetWeight.Text == "" || txtNetWeight.Text == "0")
            {

                return;
            }
            if (txtRatePerKg.Text != "" || txtRatePerKg.Text != "0")
            {
                NetWeight = decimal.Parse(txtNetWeight.Text);
                Cost = RatePerKg * NetWeight;
                txtCost.Text = Cost.ToString(); ;
            }



        }

        private void txtTotalBagsQuantity_TextChanged(object sender, EventArgs e)
        {

            if (txtTotalBagsQuantity.Text == "" || txtTotalBagsQuantity.Text == "0")
            {
                NetWeight = 0;
                txtNetWeight.Text = NetWeight.ToString();
                return;
            }
            else
            {
                TotalQuantity = decimal.Parse(txtTotalBagsQuantity.Text);

                if (txtTotalWeight.Text != "" || txtShortage.Text != " " )
                {
                    if (txtShortage.Text != " " || txtShortage.Text != "")
                    {
                        TotalWeight = TotalQuantity * decimal.Parse(txtWeightPerBag.Text);
                        txtTotalWeight.Text = TotalWeight.ToString();


                        NetWeight = TotalWeight - Shortage;
                        txtNetWeight.Text = NetWeight.ToString();

                    }
                    else
                    {
                        txtNetWeight.Text = TotalWeight.ToString();
                    }

                }


            }
        }

        private void txtTotalBagsQuantity_KeyPress(object sender, KeyPressEventArgs e)
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

            // only allow one decimal point

        }

        private void txtWeightPerBag_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (e.KeyChar == '.' && !txtTulai.Text.Contains('.'))
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
            else if (e.KeyChar == '.' && !txtCarrage.Text.Contains('.'))
            {
                //Allows only one Dot Char
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
