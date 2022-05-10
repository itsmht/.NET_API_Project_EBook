using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductBookRepo : IRepo<ProductBook, int>
    {
        EbookEntities db;
        public ProductBookRepo(EbookEntities db)
        {
            this.db = db;
        }
        public void Add(ProductBook e)
        {
            db.ProductBooks.Add(e);
            db.SaveChanges();
        }

        public void Delete(ProductBook e)
        {
            var _e = db.ProductBooks.FirstOrDefault(p => p.Id == e.Id);
            db.ProductBooks.Remove(_e);
            db.SaveChanges();
        }

        public void Edit(ProductBook e)
        {
            var _e = db.ProductBooks.FirstOrDefault(p => p.Id == e.Id);
            db.Entry(_e).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<ProductBook> Get()
        {
            return db.ProductBooks.ToList();
        }

        public ProductBook Get(int id)
        {
            return db.ProductBooks.FirstOrDefault(p => p.Id == id);
        }
    }
}