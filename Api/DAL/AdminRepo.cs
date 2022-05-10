using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdminRepo
    {
        static EbookEntities db;

        static AdminRepo()
        {
            db = new EbookEntities();
        }


        public static List<Admin> Get()
        {
            return db.Admins.ToList();
        }
        public static Admin Get(int id)
        {
            return db.Admins.FirstOrDefault(a => a.Id == id);
        }
        public static void Edit(Admin admin)
        {
            var _admin = db.Admins.FirstOrDefault(a => a.Id == admin.Id);
            db.Entry(_admin).CurrentValues.SetValues(admin);
            db.SaveChanges();
        }
        public static void Delete(Admin admin)
        {
            var _admin = db.Admins.FirstOrDefault(a => a.Id == admin.Id);
            db.Admins.Remove(_admin);
            db.SaveChanges();
        }
        public static void Add(Admin admin)
        {
            db.Admins.Add(admin);
            db.SaveChanges();
        }


    }
}