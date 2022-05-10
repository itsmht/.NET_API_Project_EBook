using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SellerRepo : IRepo<Seller, int>
    {
        EbookEntities db;
        public SellerRepo(EbookEntities db)
        {
            this.db = db;
        }
        public void Add(Seller seller)
        {
            db.Sellers.Add(seller);
            db.SaveChanges();
        }

        public void Delete(Seller seller)
        {
            var _seller = db.Sellers.FirstOrDefault(s => s.Id == seller.Id);
            db.Sellers.Remove(_seller);
            db.SaveChanges();
        }

        public void Edit(Seller seller)
        {
            var _seller = db.Sellers.FirstOrDefault(s => s.Id == seller.Id);
            db.Entry(_seller).CurrentValues.SetValues(seller);
            db.SaveChanges();
        }

        public List<Seller> Get()
        {
            return db.Sellers.ToList();
        }

        public Seller Get(int id)
        {
            return db.Sellers.FirstOrDefault(s => s.Id == id);
        }
    }
}