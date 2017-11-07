using System;
using System.Collections.Generic;
using System.Data;
//using System.Diagnostics;
using WindowsFormsApplication1.Code;
using WindowsFormsApplication1.Forms.Cashbook;

namespace WindowsFormsApplication1.Forms.Order
{
    public partial class DeliveryOrderPrint : MetroFramework.Forms.MetroForm
    {
        //string caller = "";
        public DeliveryOrderPrint()
        {

            InitializeComponent();
        }

        private void invoiceprint_Load(object sender, EventArgs e)
        {
            //caller = new StackTrace().GetFrame(1).GetMethod().DeclaringType.Name;



            List<WindowsFormsApplication1.POJO.Order> lstInvoice = new List<POJO.Order>();
            DataTable ds;
            if (AddOrder.OrderId == "")
            {
               ds  = new DAO().getDeliveryOrderData(AllOrders.selectedOrderId);

            }
            else
            {
                 ds = new DAO().getDeliveryOrderData(AddOrder.OrderId);

            }

            foreach (DataRow row in ds.Rows)
            {





                lstInvoice.Add(new POJO.Order

                {

                   

                    LotNo = int.Parse(row["LotNo"].ToString()),

                    Grade = row["Grade"].ToString(),

                    Garden = row["Garden"].ToString(),

                    Qty = int.Parse(row["Quantity"].ToString()),



                    WtperBag = int.Parse(row["IWtPerBag"].ToString()),




                    TotalWeight = int.Parse(row["TotalWeight"].ToString()),


                    Shortage = int.Parse(row["Shortage"].ToString()),

                   


                });

                




            }

            foreach (DataRow row in ds.Rows)
            {

                


                crystalReportDeliveryOrder1.SetDataSource(lstInvoice);


                string CustomerName = row[0].ToString();
                string InvoiceNo = row[1].ToString();
                DateTime Date = DateTime.Parse(row[2].ToString());
                string DoNo = row["DoNo"].ToString();


                string BrokerName = row["BrokerName"].ToString();

                int NetWeight = int.Parse(row["TotalWeight"].ToString()) - int.Parse(row["Shortage"].ToString());


                crystalReportDeliveryOrder1.SetParameterValue("CustomerName", CustomerName);
                crystalReportDeliveryOrder1.SetParameterValue("InvoiceNo", InvoiceNo);
                crystalReportDeliveryOrder1.SetParameterValue("Date", Date);
                crystalReportDeliveryOrder1.SetParameterValue("BrokerName", BrokerName);
                crystalReportDeliveryOrder1.SetParameterValue("NetWeight", NetWeight);
                crystalReportDeliveryOrder1.SetParameterValue("DoNo", DoNo);






            }


            crystalReportViewer1.ReportSource = crystalReportDeliveryOrder1;








        }
    }
}
