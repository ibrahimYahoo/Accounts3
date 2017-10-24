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
            DataTable ds = new DAO().getInvoiceReportData(AddReciept.OrderId);

            foreach (DataRow row in ds.Rows)
            {





                lstInvoice.Add(new POJO.Order

                {

                    OrderId = row["OrderId"].ToString(),

                    CustomerName = row["CustomerName"].ToString(),

                    ODate = DateTime.Parse(row["Date"].ToString()),

                    ItemName = row["Item-Name"].ToString(),

                    Qty = int.Parse(row["Quantity"].ToString()),

                    Cost = int.Parse(row["Cost"].ToString()),


                    TotalCost = Convert.ToInt32(row["TotalCost"])

                });






            }

            foreach (DataRow row in ds.Rows)
            {




                crystalReportReciept1.SetDataSource(lstInvoice);


                string gg = row[0].ToString();
                string rr = row[1].ToString();
                DateTime dd = DateTime.Parse(row[2].ToString());
                string accountno = row[5].ToString();
                string amountPaid = row["AmountPaid"].ToString();

              int bal =   int.Parse(row["TotalCost"].ToString()) - int.Parse(row["AmountPaid"].ToString());

                crystalReportReciept1.SetParameterValue("CustomerName", gg);
                //crystalReportReciept1.SetParameterValue("InvoiceNo", rr);
                crystalReportReciept1.SetParameterValue("Date", dd);
                crystalReportReciept1.SetParameterValue("AccountNumber", accountno);

                crystalReportReciept1.SetParameterValue("AmountPaid", amountPaid);

                crystalReportReciept1.SetParameterValue("Balance", bal.ToString());





            }


            crystalReportViewer1.ReportSource = crystalReportReciept1;


        }
    }
}
