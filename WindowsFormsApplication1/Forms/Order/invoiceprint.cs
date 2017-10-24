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
            DataTable ds = new DAO().getInvoiceReportData(AddOrder.OrderId);

            foreach (DataRow row in ds.Rows)
            {


 


                lstInvoice.Add(new POJO.Order

                {

                    OrderId = row["OrderId"].ToString(),

                    CustomerName = row["CustomerName"].ToString(),

                    ODate =  DateTime.Parse( row["Date"].ToString()),

                    ItemName = row["Item-Name"].ToString(),

                    Qty = int.Parse(row["Quantity"].ToString()),

                    Cost = int.Parse(row["Cost"].ToString()),


                    TotalCost = Convert.ToInt32(row["TotalCost"])

                });

                




            }

            foreach (DataRow row in ds.Rows)
            {



                
                crystalReportInvoice1.SetDataSource(lstInvoice);


                string gg = row[0].ToString();
                string rr = row[1].ToString();
                DateTime dd = DateTime.Parse(row[2].ToString());



                crystalReportInvoice1.SetParameterValue("CustomerName", gg);
                crystalReportInvoice1.SetParameterValue("InvoiceNo", rr);
                crystalReportInvoice1.SetParameterValue("Date", dd);





            }


            crystalReportViewer1.ReportSource = crystalReportInvoice1;








        }
    }
}
