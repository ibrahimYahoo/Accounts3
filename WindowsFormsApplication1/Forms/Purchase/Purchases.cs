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

namespace WindowsFormsApplication1.Forms.Purchase
{
    public partial class Purchases : MetroFramework.Forms.MetroForm
    {

        public static string selectedOrderId = "";
        public static decimal TotalQuantity = 0;
        public static decimal SellingWeight = 0;
        public static int LotNo = 0;
        public Purchases()
        {
            InitializeComponent();
        }

        private void Purchases_Load(object sender, EventArgs e)
        {
            gvPurchase.DataSource = new DAO().GetPurchases();
        }


        public void PerformRefresh()
        {
            gvPurchase.DataSource = new DAO().GetPurchases();
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
               lblmsg.Text ="Wrong Input!  Error";
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
                lblmsg.Text = "Wrong Input! Error";
            }
        }

        private void btnadditem_Click(object sender, EventArgs e)
        {
            Purchase.AddPurchase ac = new Purchase.AddPurchase(this);
            ac.WindowState = FormWindowState.Maximized;

            ac.Show();

        }

        private void txtItemQuantity_Leave(object sender, EventArgs e)
        {
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Close();

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            EditPurchase ec = new EditPurchase(this);

            LotNo = int.Parse(this.gvPurchase.CurrentRow.Cells[3].Value.ToString());

            ec.txtLotNo.Text = LotNo.ToString();
            ec.PurchaseId = this.gvPurchase.CurrentRow.Cells[0].Value.ToString();
            //ec.DeliveryOrderNo = this.gvPurchase.CurrentRow.Cells[16].Value.ToString();

            //ec.cmLotNo.DataSource = new DAO().GetLotNoS();
            //ec.cmLotNo.DisplayMember = "LotNo";
            //ec.cmLotNo.ValueMember = "IId";
            //int lotNoIndex = getIndexLotNo(ec.cmLotNo, LotNo.ToString());
            //ec.cmLotNo.SelectedIndex = lotNoIndex;


            decimal TotalWeight = decimal.Parse(gvPurchase.CurrentRow.Cells[6].Value.ToString());
            ec.TotalWeight = TotalWeight;


            string partyname = this.gvPurchase.CurrentRow.Cells[2].Value.ToString();
            ec.cmbsuppname.DataSource = new DAO().GetPartiesFrmAccount();
            ec.cmbsuppname.DisplayMember = "Name";
            ec.cmbsuppname.ValueMember = "Party-ID";
            int PartyIndex = getIndexParty(ec.cmbsuppname, partyname);
            ec.cmbsuppname.SelectedIndex = PartyIndex;

            string Brokername = this.gvPurchase.CurrentRow.Cells[13].Value.ToString();
            ec.cmBrokerName.DataSource = new DAO().GetBrokers();
            ec.cmBrokerName.DisplayMember = "BrokerName";
            ec.cmBrokerName.ValueMember = "BId";
            int brokerIndex = getIndexParty(ec.cmBrokerName, Brokername);
            ec.cmBrokerName.SelectedIndex = brokerIndex;


            ec.cmbpaydate.MinDate = new DateTime(DateTime.Now.Year, 1, 1);
            ec.cmbpaydate.MaxDate = DateTime.Now;
            ec.cmbpaydate.Value = DateTime.Parse(this.gvPurchase.CurrentRow.Cells[1].Value.ToString());

            DataTable dt2 = new DAO().GetItemsforLotNo(LotNo);

            ec.IId = int.Parse(dt2.Rows[0]["IId"].ToString());

            ec.txtGardenName.Text = dt2.Rows[0]["IGarden"].ToString();

            ec.txtGrade.Text = dt2.Rows[0]["IGrade"].ToString();
            int ItemWtPerBag = int.Parse(dt2.Rows[0]["IWtPerBag"].ToString());
            ec.txtWeightPerBag.Text = ItemWtPerBag.ToString();

            TotalQuantity = decimal.Parse(gvPurchase.CurrentRow.Cells[5].Value.ToString());
            ec.TotalQuantity = TotalQuantity;
            ec.txtTotalBagsQuantity.Text = TotalQuantity.ToString();


           

            //decimal TotalQuantityleft = decimal.Parse(dt2.Rows[0]["IQty"].ToString());
            //ec.txtQtyLeft.Text = TotalQuantityleft.ToString();


            //decimal TotalWeightLeft = decimal.Parse(dt2.Rows[0]["ITotalWeight"].ToString());
            //ec.txtWtLeft.Text = TotalWeightLeft.ToString();

            
            ec.txtTotalWeight.Text = TotalWeight.ToString();

            decimal Shortage = decimal.Parse(gvPurchase.CurrentRow.Cells[7].Value.ToString());
            ec.Shortage = Shortage;
            ec.txtShortage.Text = Shortage.ToString();

            ec.NetWeight = TotalWeight - Shortage;
            ec.txtNetWeight.Text = Convert.ToString(TotalWeight - Shortage);

            ec.txtRatePerKg.Text = gvPurchase.CurrentRow.Cells[4].Value.ToString();
            ec.RatePerKg = decimal.Parse(gvPurchase.CurrentRow.Cells[4].Value.ToString());

            ec.Cost = decimal.Parse(gvPurchase.CurrentRow.Cells[9].Value.ToString());
            ec.txtCost.Text = gvPurchase.CurrentRow.Cells[9].Value.ToString();
            // ec.txtSellingQty.Text = gvPurchase.CurrentRow.Cells[5].Value.ToString();

            ec.TotalCost = decimal.Parse(gvPurchase.CurrentRow.Cells[9].Value.ToString());
            ec.txtTotalCost.Text = gvPurchase.CurrentRow.Cells[10].Value.ToString();


            //ec.cmBrokerName.SelectedText = this.gvPurchase.CurrentRow.Cells[12].Value.ToString();

            ec.txtBrokeryAmount.Text = this.gvPurchase.CurrentRow.Cells[12].Value.ToString();

            ec.bardena = decimal.Parse(this.gvPurchase.CurrentRow.Cells[14].Value.ToString());
            ec.txtBardena.Text = this.gvPurchase.CurrentRow.Cells[14].Value.ToString();

            ec.Tulai = decimal.Parse(this.gvPurchase.CurrentRow.Cells[16].Value.ToString());
            ec.txtTulai.Text = this.gvPurchase.CurrentRow.Cells[16].Value.ToString();

            ec.Carrage = decimal.Parse(this.gvPurchase.CurrentRow.Cells[15].Value.ToString());
            ec.txtCarrage.Text = this.gvPurchase.CurrentRow.Cells[15].Value.ToString();
            ec.WindowState = FormWindowState.Maximized;

            ec.Show();

            
        }

        public static int getIndexParty(ComboBox comboBox, string value)
        {
            int i = 0;
            for (i = 0; i <= comboBox.Items.Count - 1; i++)
            {
                DataRowView cb;
                cb = (DataRowView)comboBox.Items[i];
                if (cb.Row.ItemArray[1].ToString() == value)// Change the 0 index if your want to Select by Text as 1 Index
                {

                    return i;
                }
            }
            return -1;
        }


        private void btndelete_Click(object sender, EventArgs e)
        {
            int cid = 0;
            try
            {
                cid = int.Parse(this.gvPurchase.CurrentRow.Cells[0].Value.ToString());
                if (cid != 0 && MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Do you really want to delete it because if you do it, then all the data related with it will also be deleted", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DataTable dt = new DataTable();
                        SqlConnection conn = DBConn.GetInstance();

                        SqlDataAdapter dad = new SqlDataAdapter("Delete from Purchase where PId=@PId", conn);
                        dad.SelectCommand.Parameters.AddWithValue("@CID", cid);
                        dad.Fill(dt);
                        conn.Close();

                        lblmsg.Text = "Record Deleted Successfully! ";
                        gvPurchase.DataSource = new DAO().GetPurchases();
                    }
                }
                else if (cid == 0)
                {
                    lblmsg.Text = "Please select record to Delete!";
                }
                else
                { }

            }
            catch (Exception)
            {


            }

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
