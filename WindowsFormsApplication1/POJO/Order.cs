using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.POJO
{
    class Order
    {
        public string OrderId { get; set; }
        public int OrderNo { get; set; }
        public System.DateTime ODate { get; set; }

        public string CustomerName { get; set; }

        // public int IId { get; set; }
        public int LotNo { get; set; }

        public string Grade { get; set; }

        

        public string Garden { get; set; }

        public decimal RatePerKg { get; set; }

        public decimal WtperBag { get; set; }


        public decimal TotalWeight { get; set; }

        public decimal Shortage { get; set; }




        public string BrokerName { get; set; }
        public string BrokerAmount { get; set; }

        public decimal NetWeight { get; set; }






        //public decimal TotalWtPerg { get; set; }


        public int Qty { get; set; }
       // public int Cost { get; set; }
        public decimal TotalCost { get; set; }

        public decimal Cost { get; set; }

        public decimal AmountPaid { get; set; }
        //  public string Status { get; set; }

        public int DoNo { get; set; }



        //public virtual Item Item { get; set; }
    }
}
