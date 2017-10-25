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
using WindowsFormsApplication1.Forms.GeneralLedgerFol;

namespace WindowsFormsApplication1.Forms.GeneralLedger
{
    public partial class GlPrint : MetroFramework.Forms.MetroForm
    {
        public GlPrint()
        {
            InitializeComponent();
        }

        private void GlPrint_Load(object sender, EventArgs e)
        {
            int CBId = new DAO().getLastCBId();

            List<POJO.GLPojo> lstInvoice = new List<POJO.GLPojo>();
            DataTable ds = new DAO().getGlReportData(GeneralLedgerFol.GeneralLedger.AccountId, GeneralLedgerFol.GeneralLedger.strtDate, GeneralLedgerFol.GeneralLedger.endDate);

            foreach (DataRow row in ds.Rows)
            {





                lstInvoice.Add(new POJO.GLPojo

                {

                    Gl_Id = int.Parse(row["GLtransId"].ToString()),

                   // Account_Name = row["AccountName"].ToString(),

                    Date = DateTime.Parse(row["Date"].ToString()).Date,

                    Description = row["Narrative"].ToString(),

                    Trans_Type = row["TransType"].ToString(),

                    //     Amount = int.Parse(row["Income"].ToString()),

                    Debit = Decimal.Parse(row["Debit"].ToString()),


                    Credit = Decimal.Parse(row["Debit"].ToString()),

                    Balance = Decimal.Parse(row["Balance"].ToString()),


                    Ref_No = row["Reference"].ToString(),




                });






            }
            DataTable ds2 = new DAO().getGlReportDatafrAccName(GeneralLedgerFol.GeneralLedger.AccountId, GeneralLedgerFol.GeneralLedger.strtDate, GeneralLedgerFol.GeneralLedger.endDate);

            foreach (DataRow row in ds2.Rows)
            {




                crystalReportGL21.SetDataSource(lstInvoice);


                string cusName = row["AccountName"].ToString();
                string accNo = GeneralLedgerFol.GeneralLedger.AccountId.ToString();
                DateTime dd = DateTime.Now.Date;



                crystalReportGL21.SetParameterValue("CustomerName", cusName);
                crystalReportGL21.SetParameterValue("AccountNumber", accNo);
                crystalReportGL21.SetParameterValue("Date", dd);
                crystalReportGL21.SetParameterValue("StartDate", GeneralLedgerFol.GeneralLedger.strtDate.Date.ToString());
                crystalReportGL21.SetParameterValue("EndDate", GeneralLedgerFol.GeneralLedger.endDate.Date.ToString());





            }


            crystalReportViewer1.ReportSource = crystalReportGL21;

        }
    }
}
