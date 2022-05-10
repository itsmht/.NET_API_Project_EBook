using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bll.BEnt;


namespace BLL.BEnt
{
    public class OrderDetailModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int Quantity { get; set; }
        public string Proccess { get; set; }
        public int Unitprice { get; set; }
        public Nullable<int> Product_Id { get; set; }
        public Nullable<int> Order_Id { get; set; }
        public string Process { get; set; }
        public Nullable<int> Ratings { get; set; }

        public virtual OrderModel Order { get; set; }
        public virtual ProductBookModel ProductBook { get; set; }
    }
}