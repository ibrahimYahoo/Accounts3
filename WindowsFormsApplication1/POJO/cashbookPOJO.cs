using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.POJO
{
    class cashbookPOJO
    {

        public int CashBook_Id { get; set; }


        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string AmountType { get; set; }

        public string Ref_No { get; set; }

        public decimal Amount { get; set; }

//        public decimal Expense { get; set; }

     //   public int InvoiceNo { get; set; }

        public string customerName { get; set; }



    }
}
