using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.BEnt;
using AutoMapper;
using DAL;
using Bll.BEnt;

namespace BLL
{
    public class CartService
    {
        public static List<CartModel>  Get()
            {
            var config = new MapperConfiguration
            (
                c =>
                {
                    c.CreateMap<Cart, CartModel>();
                    
                    c.CreateMap<Customer, CustomerModel>();
                    c.CreateMap<ProductBook, ProductBookModel>();
                }
            );
            var mapper = new Mapper(config);
            var sa = DataAccessFactory.CartDataAccess();
            var data = mapper.Map<List<CartModel>>(sa.Get());
            return data;
        }

        public static void Add(CartModel cart)
        {
            var config = new MapperConfiguration
            (
                c =>
                {
                    c.CreateMap<Cart, CartModel>();
                    c.CreateMap<ProductBook, ProductBookModel>();
                    c.CreateMap<Customer, CustomerModel>();
                }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<Cart>(cart);
            DataAccessFactory.CartDataAccess().Add(data);
        }
        public static void Edit(CartModel cart)
        {
            var config = new MapperConfiguration
            (
                c =>
                {
                    c.CreateMap<Cart, CartModel>();
                    c.CreateMap<ProductBook, ProductBookModel>();
                    c.CreateMap<Customer, CustomerModel>();
                }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<Cart>(cart);
            DataAccessFactory.CartDataAccess().Edit(data);
        }
        public static void Delete(CartModel cart)
        {
            var config = new MapperConfiguration
            (
                c =>
                {
                    c.CreateMap<Cart, CartModel>();
                    c.CreateMap<ProductBook, ProductBookModel>();
                    c.CreateMap<Customer, CustomerModel>();
                }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<Cart>(cart);
            DataAccessFactory.CartDataAccess().Delete(data);
        }
        public static CartModel Get(int id)
        {
            var config = new MapperConfiguration
            (
                c =>
                {
                    c.CreateMap<Cart, CartModel>();
                    c.CreateMap<ProductBook, ProductBookModel>();
                    c.CreateMap<Customer, CustomerModel>();
                }
            );
            var mapper = new Mapper(config);
            var ca = DataAccessFactory.CartDataAccess();
            var data = mapper.Map<CartModel>(ca.Get(id));
            return data;
        }

    }
}
