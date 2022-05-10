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
    public class AdminService
    {
        public static List<AdminModel> Get()
        {
            var config = new MapperConfiguration
            (
                c =>
                {
                    c.CreateMap<Admin, AdminModel>();
                }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<AdminModel>>(AdminRepo.Get());
            return data;
        }
        public static List<string> GetNames()
        {
            /*var admin = AdminRepo.Get();
            var data = (from v in admin select v.Name).ToList();*/
            var data = AdminRepo.Get().Select(a => a.Name).ToList();
            return data;
        }
        public static void Add(AdminModel admin)
        {
            var config = new MapperConfiguration
           (
               c =>
               {
                   c.CreateMap<AdminModel, Admin>();
               }
           );
            var mapper = new Mapper(config);
            var data = mapper.Map<Admin>(admin);
            AdminRepo.Add(data);

        }

        public static void Edit(AdminModel admin)
        {
            var config = new MapperConfiguration
               (
                   c =>
                   {
                       c.CreateMap<AdminModel, Admin>();
                   }
               );
            var mapper = new Mapper(config);
            var data = mapper.Map<Admin>(admin);
            AdminRepo.Edit(data);

        }
        public static void Delete(AdminModel admin)
        {
            var config = new MapperConfiguration
              (
                  c =>
                  {
                      c.CreateMap<AdminModel, Admin>();
                  }
              );
            var mapper = new Mapper(config);
            var data = mapper.Map<Admin>(admin);
            AdminRepo.Delete(data);
        }


    }
}