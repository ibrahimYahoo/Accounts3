using System;
using System.Collections.Generic;
using System.Data;
using WindowsFormsApplication1.Code;
using WindowsFormsApplication1.Forms.Cashbook;

namespace WindowsFormsApplication1.Forms.Order
{
    public partial class invoiceprint : MetroFramework.Forms.MetroForm
    {
        public invoiceprint()
        {
            InitializeComponent();
        }

        private void invoiceprint_Load(object sender, EventArgs e)
        {

            List<WindowsFormsApplication1.POJO.Order> lstInvoice = new List<POJO.Order>();
            DataTable ds;
            if (AddOrder.OrderId == "")
            {
                ds = new DAO().getInvoiceReportData(AllOrders.selectedOrderId);

            }
            else
            {
                ds = new DAO().getInvoiceReportData(AddOrder.OrderId);

            }

            foreach (DataRow row in ds.Rows)
            {





                lstInvoice.Add(new POJO.Order

                {

                    //OrderId = row["OrderId"].ToString(),

                    // CustomerName = row["CustomerName"].ToString(),

                    //ODate =  DateTime.Parse( row["Date"].ToString()),

                    // ItemName = row["Item-Name"].ToString(),


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



                
                crystalReportInvoice1.SetDataSource(lstInvoice);


                string CustomerName = row[0].ToString();
                string InvoiceNo = row[1].ToString();
                DateTime Date = DateTime.Parse(row[2].ToString());

                string BrokerAmount = row["BrokeryAmount"].ToString();

                string BrokerName = row["BrokerName"].ToString();

                string Bardena = row["Bardena"].ToString();
                string Tulai = row["Tulai"].ToString();
                string Carrage = row["Carrage"].ToString();
                int Total = Convert.ToInt32(row["TotalCost"]) - Convert.ToInt32(Bardena) - Convert.ToInt32(Tulai) - Convert.ToInt32(Carrage);


                crystalReportInvoice1.SetParameterValue("CustomerName", CustomerName);
                crystalReportInvoice1.SetParameterValue("InvoiceNo", InvoiceNo);
                crystalReportInvoice1.SetParameterValue("Date", Date);
                crystalReportInvoice1.SetParameterValue("BrokerName", BrokerName);
                crystalReportInvoice1.SetParameterValue("BrokeryAmount", BrokerAmount);
                crystalReportInvoice1.SetParameterValue("Bardena", Bardena);
                crystalReportInvoice1.SetParameterValue("Tulai", Tulai);
                crystalReportInvoice1.SetParameterValue("Carrage", Carrage);
                crystalReportInvoice1.SetParameterValue("Total", Convert.ToInt32(row["TotalCost"]));
                crystalReportInvoice1.SetParameterValue("Cost", Total);





            }


            crystalReportViewer1.ReportSource = crystalReportInvoice1;








        }
    }
}
