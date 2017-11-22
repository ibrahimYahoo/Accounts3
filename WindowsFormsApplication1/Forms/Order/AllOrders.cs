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

namespace WindowsFormsApplication1.Forms
{
    public partial class AllOrders : MetroFramework.Forms.MetroForm
    {
        public static string selectedOrderId = "";
        public static decimal sellingQty = 0;
        public static decimal SellingWeight = 0;
        public static int LotNo = 0;
        public static string Brokername = "";
        public static decimal BrokeryAmount = 0;

        SingleTonUserRoles userRolesObj = SingleTonUserRoles.GetInstance;

        public AllOrders()
        {
            InitializeComponent();
        }

        private void Purchases_Load(object sender, EventArgs e)
        {
            gvPurchase.DataSource = new DAO().getOrderaData();
        }


        public void PerformRefresh()
        {
            gvPurchase.DataSource = new DAO().getOrderaData();
        }
        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void cmbItemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void txtoldpurprice_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void TxtitemPrice_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void gvPurchase_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void txtItemQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
           
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
            if (userRolesObj.getCheckstate("AddEditOrders") == true)
            {
                Order.AddOrder ac = new Order.AddOrder(this);
                ac.WindowState = FormWindowState.Maximized;

                ac.Show();

            }
            else
            {
                MessageBox.Show("you don't have permission to enter here, Contact admin For further Details");
                return;
            }


            
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
            if (gvPurchase.SelectedRows.Count != 1)
            {
                MessageBox.Show("please select one row first");

                return;
            }

            if (userRolesObj.getCheckstate("AddEditOrders") == true)
            {
                Forms.Order.EditOrder ec = new EditOrder(this);

                LotNo = int.Parse(this.gvPurchase.CurrentRow.Cells[3].Value.ToString());
                ec.LotNo = LotNo;
                ec.OrderId = this.gvPurchase.CurrentRow.Cells[0].Value.ToString();
                ec.DeliveryOrderNo = this.gvPurchase.CurrentRow.Cells[16].Value.ToString();

                ec.cmLotNo.DataSource = new DAO().GetLotNoS();
                ec.cmLotNo.DisplayMember = "LotNo";
                ec.cmLotNo.ValueMember = "IId";
                int lotNoIndex = getIndexLotNo(ec.cmLotNo, LotNo.ToString());
                ec.cmLotNo.SelectedIndex = lotNoIndex;


                decimal SellingWeight = decimal.Parse(gvPurchase.CurrentRow.Cells[7].Value.ToString());
                ec.SellingWt = SellingWeight;
                decimal Shortage = decimal.Parse(gvPurchase.CurrentRow.Cells[6].Value.ToString());


                string partyname = this.gvPurchase.CurrentRow.Cells[2].Value.ToString();
                ec.cbCustName.DataSource = new DAO().GetPartiesFrmAccount();
                ec.cbCustName.DisplayMember = "Name";
                ec.cbCustName.ValueMember = "Party-ID";
                int PartyIndex = getIndexParty(ec.cbCustName, partyname);
                ec.cbCustName.SelectedIndex = PartyIndex;

                Brokername = this.gvPurchase.CurrentRow.Cells[12].Value.ToString();
                ec.cmBrokerName.DataSource = new DAO().GetBrokers();
                ec.cmBrokerName.DisplayMember = "BrokerName";
                ec.cmBrokerName.ValueMember = "BId";
                int brokerIndex = getIndexbroker(ec.cmBrokerName, Brokername);
                ec.cmBrokerName.SelectedIndex = brokerIndex;


                ec.dtODate.MinDate = new DateTime(DateTime.Now.Year, 1, 1);
                ec.dtODate.MaxDate = DateTime.Now;
                ec.dtODate.Value = DateTime.Parse(this.gvPurchase.CurrentRow.Cells[1].Value.ToString());

                DataTable dt2 = new DAO().GetItemsforLotNo(LotNo);

                ec.IId = int.Parse(dt2.Rows[0]["IId"].ToString());

                ec.txtGarden.Text = dt2.Rows[0]["IGarden"].ToString();

                ec.txtGrade.Text = dt2.Rows[0]["IGrade"].ToString();

                sellingQty = decimal.Parse(gvPurchase.CurrentRow.Cells[5].Value.ToString());


                decimal TotalQuantityleft = decimal.Parse(dt2.Rows[0]["IQty"].ToString());
                ec.txtQtyLeft.Text = TotalQuantityleft.ToString();

                int ItemWtPerBag = int.Parse(dt2.Rows[0]["IWtPerBag"].ToString());
                ec.txtWtPerBag.Text = ItemWtPerBag.ToString();

                decimal TotalWeightLeft = decimal.Parse(dt2.Rows[0]["ITotalWeight"].ToString());
                ec.txtWtLeft.Text = TotalWeightLeft.ToString();

                ec.SellingQty = decimal.Parse(gvPurchase.CurrentRow.Cells[5].Value.ToString());
                ec.txtSellingQty.Text = gvPurchase.CurrentRow.Cells[5].Value.ToString();

                ec.txtSellingWt.Text = SellingWeight.ToString();

                ec.txtShortage.Text = Shortage.ToString();

                ec.NetWeight = SellingWeight - Shortage;
                ec.txtNetWeight.Text = Convert.ToString(SellingWeight - Shortage);

                ec.txtRatePerKg.Text = gvPurchase.CurrentRow.Cells[4].Value.ToString();
                ec.RatePerKg = int.Parse(gvPurchase.CurrentRow.Cells[4].Value.ToString());
                ec.txtTotal.Text = gvPurchase.CurrentRow.Cells[8].Value.ToString();
                // ec.txtSellingQty.Text = gvPurchase.CurrentRow.Cells[5].Value.ToString();

                ec.txtQtyLeft.Enabled = false;
                ec.txtWtLeft.Enabled = false;
                ec.txtWtPerBag.Enabled = false;


                ec.cmBrokerName.SelectedText = this.gvPurchase.CurrentRow.Cells[12].Value.ToString();

                BrokeryAmount = decimal.Parse(this.gvPurchase.CurrentRow.Cells[11].Value.ToString());
                ec.txtBrokeryAmount.Text = this.gvPurchase.CurrentRow.Cells[11].Value.ToString();
                ec.txtBardena.Text = this.gvPurchase.CurrentRow.Cells[13].Value.ToString();
                ec.txtTulai.Text = this.gvPurchase.CurrentRow.Cells[15].Value.ToString();
                ec.txtCarrage.Text = this.gvPurchase.CurrentRow.Cells[14].Value.ToString();
                ec.WindowState = FormWindowState.Maximized;

                ec.Show();
            }
            else
            {
                MessageBox.Show("you don't have permission to enter here, Contact admin For further Details");
                return;
            }
            
        }

        public static int getIndexLotNo(ComboBox comboBox, string value)
        {
            int i = 0;
            for (i = 0; i <= comboBox.Items.Count - 1; i++)
            {
                DataRowView cb;
                cb = (DataRowView)comboBox.Items[i];
                if (cb.Row.ItemArray[1].ToString() == value)// Change the 0 index if your want to Select by Text as 1 Index
                {
                    
                    return i ;
                }
            }
            return -1;
        }

        public static int getIndexbroker(ComboBox comboBox, string value)
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
                        gvPurchase.DataSource = new DAO().getOrderaData();
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

        private void gvPurchase_SelectionChanged(object sender, EventArgs e)
        {
            //DataGridView cb = (DataGridView)sender;
            //if (!cb.Focused)
            //{
            //    return;
            //}

            // selectedOrderId =   gvPurchase.SelectedRows[0].ToString();


            foreach (DataGridViewRow row in gvPurchase.SelectedRows)
            {

                selectedOrderId =  row.Cells[0].Value.ToString();

            }
        }

        private void btnPrintDeliveryOrder_Click(object sender, EventArgs e)
        {

            if (gvPurchase.SelectedRows.Count == 1)
            {
                DeliveryOrderPrint obj3 = new DeliveryOrderPrint();
                obj3.WindowState = FormWindowState.Maximized;

                obj3.Show();
            }
            else
            {
                MessageBox.Show("please select one row first");
            }
            

        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            if(gvPurchase.SelectedRows.Count == 1)
            {
                invoiceprint obj2 = new invoiceprint();
                obj2.WindowState = FormWindowState.Maximized;

                obj2.Show();
            }
            else
            {
                MessageBox.Show("please select one row first");
            }

            
        }
    }
}
