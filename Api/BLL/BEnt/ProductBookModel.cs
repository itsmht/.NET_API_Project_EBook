using BLL.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.BEnt
{
    public class ProductBookModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public int Admin_Id { get; set; }
        public int Seller_Id { get; set; }

        public virtual AdminModel Admin { get; set; }
        public virtual SellerModel Seller { get; set; }
    }
}