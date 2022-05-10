using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerRepo : IRepo<Customer, int>
    {
        EbookEntities db;
        public CustomerRepo(EbookEntities db)
        {
            this.db = db;
        }
        public void Add(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
        }

        public void Delete(Customer customer)
        {
            var _customer = db.Customers.FirstOrDefault(c => c.Id == customer.Id);
            db.Customers.Remove(_customer);
            db.SaveChanges();
        }

        public void Edit(Customer customer)
        {
            var _customer = db.Customers.FirstOrDefault(c => c.Id == customer.Id);
            db.Entry(_customer).CurrentValues.SetValues(customer);
            db.SaveChanges();
        }

        public List<Customer> Get()
        {
            return db.Customers.ToList();
        }

        public Customer Get(int id)
        {
            return db.Customers.FirstOrDefault(c => c.Id == id);
        }
    }
}