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

            txtGardenName.AutoCompleteMode = AutoCompleteMode.Append;
            txtGardenName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtGardenName.AutoCompleteCustomSource = new DAO().GetGardens();

            cmbsuppname.DataSource = new DAO().GetParties();
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

            try
            {
                if (txtLotNo.Text != "" && txtGardenName.Text != "" && txtGrade.Text != "" && txtTotalBagsQuantity.Text != "" && txtRatePerKg.Text != "0" && txtWeightPerBag.Text != "0")
                {

                    string PurchaseId  = "PUR" + new DAO().getLastPurchaseNo() ;


                    DataRowView dv = (DataRowView)cmbsuppname.SelectedItem;
                    string AccountName = (string)dv.Row["Name"];
                    int PId = (int)dv.Row["Party-ID"];


                    // int PId = int.Parse(cmbsuppname.SelectedValue.ToString());

                    //DataRowView dv2 = (DataRowView)cmGardenName.SelectedItem;                                  
                    string GardenName = txtGardenName.Text;
                    int BId = 2;
                    if (cmBrokerName.SelectedIndex != -1) {

                        DataRowView dv3 = (DataRowView)cmBrokerName.SelectedItem;

                        BId = (int)dv3.Row["BId"];

                    }


                    int TotalQuantity = int.Parse(txtTotalBagsQuantity.Text);

                    decimal TotalCost = (int.Parse(txtRatePerKg.Text) * (int.Parse(txtWeightPerBag.Text) * TotalQuantity));
                    decimal TotalWieght = (int.Parse(txtWeightPerBag.Text) * (int.Parse(txtTotalBagsQuantity.Text)));


                    new DAO().insertItem(int.Parse(txtLotNo.Text),txtGrade.Text,GardenName,int.Parse(txtTotalBagsQuantity.Text),int.Parse(txtWeightPerBag.Text),int.Parse(txtRatePerKg.Text),TotalCost, TotalWieght);


                    int IId = new DAO().getItemIdFromName(GardenName);


                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();
                    SqlDataAdapter dad = new SqlDataAdapter("Insert INTO Purchase(PurId,IId,PId,PurDate,IRatePerKg,ItemQty,BrokeryAmount,BId,Bardena,Tulai,Carrage,Total,AmountPaid,Status) values (@PurId,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,0,0)", conn);

                    dad.SelectCommand.Parameters.AddWithValue("@PurId", PurchaseId);

                    dad.SelectCommand.Parameters.AddWithValue("@3", IId);
                    dad.SelectCommand.Parameters.AddWithValue("@4", PId);
                    dad.SelectCommand.Parameters.AddWithValue("@5", cmbpaydate.Value);
                    dad.SelectCommand.Parameters.AddWithValue("@6", int.Parse(txtRatePerKg.Text));
                    dad.SelectCommand.Parameters.AddWithValue("@7", TotalQuantity);
                    dad.SelectCommand.Parameters.AddWithValue("@8", int.Parse(txtBrokeryAmount.Text));
                    dad.SelectCommand.Parameters.AddWithValue("@9", BId);
                    dad.SelectCommand.Parameters.AddWithValue("@10", txtBardena.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@11", txtTulai.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@12", txtCarrage.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@13", TotalCost);


                    //int balance = int.Parse(txttotal.Text) - int.Parse(txtAmountPaid.Text);

                    dad.Fill(dt);
                    conn.Close();

                    

                    //string AccountName = this.cmbsuppname.GetItemText(this.cmbsuppname.SelectedItem);

                    int AccountId = new DAO().GetAccountId(AccountName);


                    decimal RemainingBalance = new DAO().GetPartyBalance(PId);

                    new DAO().AddGlTransactions(DateTime.Today.Date, "Purchased " + GardenName + " " + TotalQuantity, 5, "Debit", PurchaseId, 0, TotalCost, 00);
                    new DAO().AddGlTransactions(DateTime.Today.Date, "Purchased " + GardenName + " " + TotalQuantity, 8, "Credit", PurchaseId, TotalCost, 0,00);
                    new DAO().AddGlTransactions(DateTime.Today.Date, "Purchased " + GardenName + " " + TotalQuantity, AccountId, "Credit", PurchaseId, TotalCost, 0, 00);


                    // new DAO().AddPurchaseTransaction(PId, 0, int.Parse(txtAmountPaid.Text), int.Parse(cmbItemname.SelectedValue.ToString()), int.Parse(txtItemQuantity.Text), "NA", DateTime.Today.Date, 1, RemainingBalance - balance);
                    new DAO().UpdateQtyAdd(IId, TotalQuantity);
                    new DAO().UpdateOwnerBalance(PId, RemainingBalance - TotalCost);


                    //MessageBox.Show("Purchase Inserted successfully");
                    
                    //cmbsuppname.DataSource = new DAO().GetParties();
                    //cmbsuppname.DisplayMember = "Name";
                    //cmbsuppname.ValueMember = "Party-ID";
                    //cmbsuppname.SelectedIndex = -1;

                    //cmbItemname.DataSource = new DAO().GetItemsDesc();
                    //cmbItemname.DisplayMember = "Display";
                    //cmbItemname.ValueMember = "IId";
                    //cmbItemname.SelectedIndex = -1;

                    txtLotNo.Text = 0.ToString();
                    txtTotalBagsQuantity.Text = 0.ToString();
                    //TxtitemPrice.Text = 0.ToString();
                    //    gvPurchase.DataSource = new DAO().GetPurchases();
                    //    gvPurchase.Show();
                    //   lblqty.Visible = false;

                    RequestPurPay obj = new RequestPurPay();
                    obj.Show();

                }
                else
                {
                    MessageBox.Show("Please fill all the textboxes");
                }
            }
            catch (Exception ex)
            {
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
    }
}
