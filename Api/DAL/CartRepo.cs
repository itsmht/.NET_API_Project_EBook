using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CartRepo : IRepo<Cart, int>
    {
        EbookEntities db;
        public CartRepo(EbookEntities db)
        {
            this.db = db;
        }
        public void Add(Cart e)
        {
            db.Carts.Add(e);
            db.SaveChanges();
        }

        public void Delete(Cart e)
        {
            var _e = db.Carts.FirstOrDefault(c => c.Id == e.Id);
            db.Carts.Remove(_e);
            db.SaveChanges();
        }

        public void Edit(Cart e)
        {
            var _e = db.Carts.FirstOrDefault(c => c.Id == e.Id);
            db.Entry(_e).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Cart> Get()
        {
            return db.Carts.ToList();
        }

        public Cart Get(int id)
        {
            return db.Carts.FirstOrDefault(c => c.Id == id);
        }
    }
}
