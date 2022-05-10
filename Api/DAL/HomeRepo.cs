using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HomeRepo
    {
        static EbookEntities db;

        static HomeRepo()
        {
            db = new EbookEntities();
        }


        public static ProductBook BookDetails(int id)
        {
            return db.ProductBooks.FirstOrDefault(pb => pb.Id == id);
        }
    }
}