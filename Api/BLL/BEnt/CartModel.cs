using Bll.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
    public class CartModel
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CustomerId { get; set; }

        public virtual CustomerModel Customer { get; set; }
        public virtual ProductBookModel ProductBook { get; set; }
    }
}
