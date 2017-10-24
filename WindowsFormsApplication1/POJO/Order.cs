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
        public int PId { get; set; }

        public string CustomerName { get; set; }

        public int IId { get; set; }
        public string ItemName { get; set; }


        public int Qty { get; set; }
        public int Cost { get; set; }
        public decimal TotalCost { get; set; }
        public decimal AmountPaid { get; set; }
        public string Status { get; set; }

        //public virtual Item Item { get; set; }
    }
}
