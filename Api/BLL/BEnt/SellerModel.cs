using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.BEnt;

namespace BLL.BEnt
{
    public class SellerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public int Admin_Id { get; set; }

        public virtual AdminModel Admin { get; set; }
    }
}