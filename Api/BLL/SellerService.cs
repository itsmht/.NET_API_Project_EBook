using AutoMapper;
using BLL.BEnt;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SellerService
    {
        public static List<SellerModel> Get()
        {
            var config = new MapperConfiguration
            (
                c =>
                {
                    c.CreateMap<Seller, SellerModel>();
                    c.CreateMap<Admin, AdminModel>();
                }
            );
            var mapper = new Mapper(config);
            var sa = DataAccessFactory.SellerDataAccess();
            var data = mapper.Map<List<SellerModel>>(sa.Get());
            return data;
        }
        public static List<string> GetNames()
        {

            var data = DataAccessFactory.SellerDataAccess().Get().Select(s => s.Name).ToList();
            return data;
        }
        public static void Add(SellerModel seller)
        {
            var config = new MapperConfiguration
           (
               c =>
               {
                   c.CreateMap<SellerModel, Seller>();
                   c.CreateMap<AdminModel, Admin>();
               }
           );
            var mapper = new Mapper(config);
            var data = mapper.Map<Seller>(seller);
            DataAccessFactory.SellerDataAccess().Add(data);

        }

        public static void Edit(SellerModel seller)
        {
            var config = new MapperConfiguration
               (
                   c =>
                   {
                       c.CreateMap<SellerModel, Seller>();
                       c.CreateMap<AdminModel, Admin>();
                   }
               );
            var mapper = new Mapper(config);
            var data = mapper.Map<Seller>(seller);
            DataAccessFactory.SellerDataAccess().Edit(data);

        }
        public static void Delete(SellerModel seller)
        {
            var config = new MapperConfiguration
              (
                  c =>
                  {
                      c.CreateMap<SellerModel, Seller>();
                      c.CreateMap<AdminModel, Admin>();
                  }
              );
            var mapper = new Mapper(config);
            var data = mapper.Map<Seller>(seller);
            DataAccessFactory.SellerDataAccess().Delete(data);
        }
        public static SellerModel Get(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Seller, SellerModel>();
                c.CreateMap<Admin, AdminModel>();
            });
            var mapper = new Mapper(config);
            var sa = DataAccessFactory.SellerDataAccess();
            var data = mapper.Map<SellerModel>(sa.Get(id));
            return data;
        }
    }
}