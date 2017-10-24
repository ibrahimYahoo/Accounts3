using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.POJO
{
    class GLPojo
    {

        public int Gl_Id { get; set; }


        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string Trans_Type { get; set; }

        public string Ref_No { get; set; }

        public decimal Debit { get; set; }

        public decimal Credit { get; set; }



        public decimal Balance { get; set; }


        //        public decimal Expense { get; set; }

        //   public int InvoiceNo { get; set; }

        public string Account_Name { get; set; }



    }
}
