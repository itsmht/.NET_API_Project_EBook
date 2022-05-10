using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.BEnt;

namespace BLL
{
    public class OrderService
    {
        public static void GiveOrder(int id)
        {
            OrderRepo.GiveOrder(id);

        }
        public static void ApproveOrder(int id)
        {
            OrderRepo.ApproveOrder(id);

        }
        public static void CancelOrder(int id)
        {
            OrderRepo.CancelOrder(id);
        }
        public static void GiveRating5(int id)
        {
            OrderRepo.GiveRating5(id);
        }
        public static void GiveRating4(int id)
        {
            OrderRepo.GiveRating4(id);
        }
        public static void GiveRating3(int id)
        {
            OrderRepo.GiveRating3(id);
        }
        public static void GiveRating2(int id)
        {
            OrderRepo.GiveRating2(id);
        }
        public static void GiveRating1(int id)
        {
            OrderRepo.GiveRating1(id);
        }
    }
}