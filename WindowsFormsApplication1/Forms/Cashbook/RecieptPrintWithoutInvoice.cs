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
    public partial class RecieptPrintWithoutInvoice : MetroFramework.Forms.MetroForm
    {
        public RecieptPrintWithoutInvoice()
        {
            InitializeComponent();
        }

        private void RecieptPrintWithoutInvoice_Load(object sender, EventArgs e)
        {
           int  CBId = new DAO().getLastCBId();

            List<WindowsFormsApplication1.POJO.cashbookPOJO> lstInvoice = new List<POJO.cashbookPOJO>();
            DataTable ds = new DAO().getRecieptReportData(CBId);

            foreach (DataRow row in ds.Rows)
            {





                lstInvoice.Add(new POJO.cashbookPOJO

                {

                    CashBook_Id = int.Parse(row["CBId"].ToString()),

                   // customerName = row["CustomerName"].ToString(),

                    Date = DateTime.Parse(row["Date"].ToString()),

                    Description = row["Description"].ToString(),

                    AmountType = row["AmountType"].ToString(),

                    Amount = int.Parse(row["Income"].ToString()),

                  


                    Ref_No = row["ReferenceNo"].ToString()

                });






            }

            foreach (DataRow row in ds.Rows)
            {




                crystalReportRecieptWithoutInvoiceNo1.SetDataSource(lstInvoice);

                string ChequeNo = "";
                string BankCode = "";

                string cusName = row[0].ToString();
                string accNo = row["AccountId"].ToString();
                DateTime dd = DateTime.Parse(row["Date"].ToString());
                string AmountType = row["AmountType"].ToString();

                if (AmountType == "Cash")
                {
                    //Cash = "\u221A";
                }
                else
                {
                    ChequeNo = row[11].ToString();
                    BankCode = row[12].ToString();

                }


                crystalReportRecieptWithoutInvoiceNo1.SetParameterValue("CustomerName", cusName);
                crystalReportRecieptWithoutInvoiceNo1.SetParameterValue("AccountNumber", accNo);
                crystalReportRecieptWithoutInvoiceNo1.SetParameterValue("Date", dd);
                crystalReportRecieptWithoutInvoiceNo1.SetParameterValue("Cheque", ChequeNo);
                crystalReportRecieptWithoutInvoiceNo1.SetParameterValue("BankCode", BankCode);





            }


            crystalReportViewer1.ReportSource = crystalReportRecieptWithoutInvoiceNo1;


        }
    }
}
