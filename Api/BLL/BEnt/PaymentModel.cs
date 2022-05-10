using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.BEnt;


namespace BLL.BEnt

{
    public class PaymentModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }
        public System.DateTime Date { get; set; }
        public int Order_Id { get; set; }
        public int Customer_Id { get; set; }

        public virtual CustomerModel Customer { get; set; }
        public virtual OrderModel Order { get; set; }
    }
}