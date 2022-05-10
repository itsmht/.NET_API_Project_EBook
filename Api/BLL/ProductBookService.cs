using AutoMapper;

using Bll.BEnt;
using BLL.BEnt;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductBookService
    {
        public static List<ProductBookModel> Get()
        {
            var config = new MapperConfiguration
            (
                c =>
                {
                    c.CreateMap<ProductBook, ProductBookModel>();
                    c.CreateMap<Seller, SellerModel>();
                    c.CreateMap<Admin, AdminModel>();
                }
            );
            var mapper = new Mapper(config);
            var sa = DataAccessFactory.ProductBookDataAccess();
            var data = mapper.Map<List<ProductBookModel>>(sa.Get());
            return data;
        }

        public static void Add(ProductBookModel productBook)
        {
            var config = new MapperConfiguration
           (
               c =>
               {
                   c.CreateMap<ProductBookModel, ProductBook>();
                   c.CreateMap<SellerModel, Seller>();
                   c.CreateMap<AdminModel, Admin>();
               }
           );
            var mapper = new Mapper(config);
            var data = mapper.Map<ProductBook>(productBook);
            DataAccessFactory.ProductBookDataAccess().Add(data);

        }

        public static void Edit(ProductBookModel productBook)
        {
            var config = new MapperConfiguration
               (
                   c =>
                   {
                       c.CreateMap<ProductBookModel, ProductBook>();
                       c.CreateMap<SellerModel, Seller>();
                       c.CreateMap<AdminModel, Admin>(); ;
                   }
               );
            var mapper = new Mapper(config);
            var data = mapper.Map<ProductBook>(productBook);
            DataAccessFactory.ProductBookDataAccess().Edit(data);

        }
        public static void Delete(ProductBookModel productBook)
        {
            var config = new MapperConfiguration
               (
                   c =>
                   {
                       c.CreateMap<ProductBookModel, ProductBook>();
                       c.CreateMap<SellerModel, Seller>();
                       c.CreateMap<AdminModel, Admin>(); ;
                   }
               );
            var mapper = new Mapper(config);
            var data = mapper.Map<ProductBook>(productBook);
            DataAccessFactory.ProductBookDataAccess().Delete(data);
        }

    }
}