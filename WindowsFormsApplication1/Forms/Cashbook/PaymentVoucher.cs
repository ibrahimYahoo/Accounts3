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
    public partial class PaymentVoucher : MetroFramework.Forms.MetroForm
    {
        public PaymentVoucher()
        {
            InitializeComponent();
        }

        private void RecieptPrint_Load(object sender, EventArgs e)
        {

            int CBId = new DAO().getLastCBId();

            DataTable ds = new DAO().getRecieptReportData(CBId);

            
            foreach (DataRow row in ds.Rows)
            {
                //crPaymentVoucher1.SetDataSource(lstInvoice);

                string InvoiceNo = "";
                string To = row[0].ToString();

                try
                {
                    InvoiceNo = row[8].ToString();

                }
                catch (Exception ex)
                {

                }
                DateTime Date = DateTime.Parse(row[2].ToString());
                string VoucherNo = row[10].ToString();

                //string BrokerAmount = row["BrokeryAmount"].ToString();

                //string BrokerName = row["BrokerName"].ToString();
                string Cash = " ";
                decimal Amount = 0;
                string ChequeNo = "";
                string BankCode = "";
                string Expense = row[13].ToString();
                if(Expense == "Purchase")
                {
                    Expense = "";

                }
                else
                {
                    To = "";
                }


                string AmountType = row["AmountType"].ToString();
                if(AmountType == "Cash")
                {
                    Cash = "\u221A";
                }
                else
                {
                    ChequeNo = row[11].ToString();
                    BankCode = row[12].ToString();

                }

                Amount = decimal.Parse(row[7].ToString());
                string SumOf = NumberToWords.ConvertToWords(Amount.ToString());
                
                string Narrative = row[4].ToString();


                crPaymentVoucher1.SetParameterValue("To", To);
                crPaymentVoucher1.SetParameterValue("InvoiceNo", InvoiceNo);
                crPaymentVoucher1.SetParameterValue("Date", Date.Date);
                crPaymentVoucher1.SetParameterValue("Cash", Cash);
                crPaymentVoucher1.SetParameterValue("Amount", Amount);
                crPaymentVoucher1.SetParameterValue("PVNo", VoucherNo);
                crPaymentVoucher1.SetParameterValue("SumOf", SumOf);
                crPaymentVoucher1.SetParameterValue("Cheque", ChequeNo);
                crPaymentVoucher1.SetParameterValue("BankCode", BankCode);
                crPaymentVoucher1.SetParameterValue("Narrative", Narrative);
                crPaymentVoucher1.SetParameterValue("Expense", Expense);



            }


            crystalReportViewer1.ReportSource = crPaymentVoucher1;


        }
    }
}
