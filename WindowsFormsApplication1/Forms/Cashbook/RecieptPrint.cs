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

namespace WindowsFormsApplication1.Forms.Cashbook
{
    public partial class RecieptPrint : MetroFramework.Forms.MetroForm
    {

        public RecieptPrint()
        {
            InitializeComponent();
        }

        private void RecieptPrint_Load(object sender, EventArgs e)
        {
            List<WindowsFormsApplication1.POJO.Order> lstInvoice = new List<POJO.Order>();
            DataTable ds;
            if (AddReciept.OrderId != "")
            {
                ds = new DAO().getRecieptReportData(AddReciept.OrderId);


            }
            else
            {
                ds = new DAO().getRecieptReportData(EditReciept.OrderId);

            }

            foreach (DataRow row in ds.Rows)
            {





                lstInvoice.Add(new POJO.Order

                {

                    // OrderId = row["OrderId"].ToString(),

                    // CustomerName = row["CustomerName"].ToString(),

                    // ODate = DateTime.Parse(row["Date"].ToString()),

                    //// ItemName = row["Item-Name"].ToString(),

                    // Qty = int.Parse(row["Quantity"].ToString()),

                    // //Cost = int.Parse(row["Cost"].ToString()),


                    // TotalCost = Convert.ToInt32(row["TotalCost"])

                    LotNo = int.Parse(row["LotNo"].ToString()),

                    Grade = row["Grade"].ToString(),

                    Garden = row["Garden"].ToString(),

                    Qty = int.Parse(row["Quantity"].ToString()),



                    WtperBag = int.Parse(row["IWtPerBag"].ToString()),




                    TotalWeight = int.Parse(row["TotalWeight"].ToString()),


                    Shortage = int.Parse(row["Shortage"].ToString()),

                    //  Cost = int.Parse(row["Cost"].ToString()),


                    TotalCost = Convert.ToInt32(row["TotalCost"]),

                    NetWeight = int.Parse(row["TotalWeight"].ToString()) - int.Parse(row["Shortage"].ToString()),

                    RatePerKg = int.Parse(row["RatePerKg"].ToString())



                });






            }

            foreach (DataRow row in ds.Rows)
            {
                crystalReportReciepts21.SetDataSource(lstInvoice);


                string CustomerName = row[0].ToString();
                string InvoiceNo = row[1].ToString();
                DateTime Date = DateTime.Parse(row[2].ToString());

                //string BrokerAmount = row["BrokeryAmount"].ToString();

                //string BrokerName = row["BrokerName"].ToString();

                string Bardena = row["Bardena"].ToString();
                string Tulai = row["Tulai"].ToString();
                string Carrage = row["Carrage"].ToString();
                decimal Total = Convert.ToDecimal(row["TotalCost"]) + Convert.ToInt32(Bardena) + Convert.ToInt32(Tulai) + Convert.ToInt32(Carrage);

                decimal AmountPaid = decimal.Parse(row["AmountPaid"].ToString());

                // decimal Balance = Convert.ToDecimal(row["TotalCost"]) + Convert.ToInt32(Bardena) + Convert.ToInt32(Tulai) + Convert.ToInt32(Carrage) - decimal.Parse(row["AmountPaid"].ToString());

                decimal Balance = Total - AmountPaid;

                crystalReportReciepts21.SetParameterValue("CustomerName", CustomerName);
                crystalReportReciepts21.SetParameterValue("InvoiceNo", InvoiceNo);
                crystalReportReciepts21.SetParameterValue("Date", Date);
               //  crystalReportReciepts21.SetParameterValue("BrokerName", BrokerName);
               // crystalReportReciepts21.SetParameterValue("BrokeryAmount", BrokerAmount);
                crystalReportReciepts21.SetParameterValue("Bardena", Bardena);
                crystalReportReciepts21.SetParameterValue("Tulai", Tulai);
                crystalReportReciepts21.SetParameterValue("Carrage", Carrage);
                crystalReportReciepts21.SetParameterValue("Total", Total);
                crystalReportReciepts21.SetParameterValue("AmountPaid", AmountPaid);
                crystalReportReciepts21.SetParameterValue("Balance", Balance);



            }


            crystalReportViewer1.ReportSource = crystalReportReciepts21;


        }
    }
}
