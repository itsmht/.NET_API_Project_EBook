using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderRepo
    {
        static EbookEntities db;
        static OrderRepo()
        {
            db = new EbookEntities();
        }
        public static void GiveOrder(int id)
        {
            
            
            var book = (from o in db.OrderDetails
                        where o.Id == id
                        select o).FirstOrDefault();

            book.Process = "Placed";
            db.SaveChanges();
        }
        public static void ApproveOrder(int id)
        {
            var book = (from o in db.OrderDetails
                        where o.Id == id
                        select o).FirstOrDefault();

            book.Process = "Approved";
            db.SaveChanges();
        }
        public static void CancelOrder(int id)
        {
            var book = (from o in db.OrderDetails
                        where o.Id == id
                        select o).FirstOrDefault();

            book.Process = "Cancelled";
            db.SaveChanges();
        }
        public static void GiveRating5(int id)
        {
            var book = (from o in db.OrderDetails
                        where o.Id == id
                        select o).FirstOrDefault();
            book.Ratings = 5;
            db.SaveChanges();
        }
        public static void GiveRating4(int id)
        {
            var book = (from o in db.OrderDetails
                        where o.Id == id
                        select o).FirstOrDefault();
            book.Ratings = 4;
            db.SaveChanges();
        }
        public static void GiveRating3(int id)
        {
            var book = (from o in db.OrderDetails
                        where o.Id == id
                        select o).FirstOrDefault();
            book.Ratings = 3;
            db.SaveChanges();
        }
        public static void GiveRating2(int id)
        {
            var book = (from o in db.OrderDetails
                        where o.Id == id
                        select o).FirstOrDefault();
            book.Ratings = 2;
            db.SaveChanges();
        }
        public static void GiveRating1(int id)
        {
            var book = (from o in db.OrderDetails
                        where o.Id == id
                        select o).FirstOrDefault();
            book.Ratings = 1;
            db.SaveChanges();
        }
    }
}