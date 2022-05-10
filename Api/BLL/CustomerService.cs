using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.BEnt;
using DAL;

namespace BLL
{
    public class CustomerService
    {
        public static List<CustomerModel> Get()
        {
            var config = new MapperConfiguration
            (
                c =>
                {
                    c.CreateMap<Customer, CustomerModel>();
                    c.CreateMap<Admin, AdminModel>();
                }
            );
            var mapper = new Mapper(config);
            var ca = DataAccessFactory.CustomerDataAccess();
            var data = mapper.Map<List<CustomerModel>>(ca.Get());
            return data;
        }
        public static List<string> GetNames()
        {

            var data = DataAccessFactory.CustomerDataAccess().Get().Select(a => a.Name).ToList();
            return data;
        }
        public static void Add(CustomerModel customer)
        {
            var config = new MapperConfiguration
           (
               c =>
               {
                   c.CreateMap<CustomerModel, Customer>();
                   c.CreateMap<AdminModel, Admin>();
               }
           );
            var mapper = new Mapper(config);
            var data = mapper.Map<Customer>(customer);
            DataAccessFactory.CustomerDataAccess().Add(data);

        }

        public static void Edit(CustomerModel customer)
        {
            var config = new MapperConfiguration
               (
                   c =>
                   {
                       c.CreateMap<CustomerModel, Customer>();
                       c.CreateMap<AdminModel, Admin>();
                   }
               );
            var mapper = new Mapper(config);
            var data = mapper.Map<Customer>(customer);
            DataAccessFactory.CustomerDataAccess().Edit(data);

        }
        public static void Delete(CustomerModel customer)
        {
            var config = new MapperConfiguration
              (
                  c =>
                  {
                      c.CreateMap<CustomerModel, Customer>();
                      c.CreateMap<AdminModel, Admin>();
                  }
              );
            var mapper = new Mapper(config);
            var data = mapper.Map<Customer>(customer);
            DataAccessFactory.CustomerDataAccess().Delete(data);
        }
        public static CustomerModel Get(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerModel>();
                c.CreateMap<Admin, AdminModel>();
            });
            var mapper = new Mapper(config);
            var ca = DataAccessFactory.CustomerDataAccess();
            var data = mapper.Map<CustomerModel>(ca.Get(id));
            return data;
        }

    }
}