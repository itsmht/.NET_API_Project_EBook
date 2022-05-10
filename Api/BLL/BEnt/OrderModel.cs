using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.BEnt;

namespace BLL.BEnt
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public int Customer_Id { get; set; }

        public virtual CustomerModel Customer { get; set; }
    }
}