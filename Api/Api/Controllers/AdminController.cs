using BLL;
using BLL.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class AdminController : ApiController
    {
        [Route("api/Admin/GetNames")]
        [HttpGet]
        public List<string> GetNames()
        {
            return AdminService.GetNames();
        }
        [Route("api/Admin/Get")]
        [HttpGet]
        public List<AdminModel> Get()
        {
            return AdminService.Get();
        }
        [Route("api/Admin/Create")]
        [HttpPost]
        public void Add(AdminModel admin)
        {
            AdminService.Add(admin);
        }
        [Route("api/Admin/Edit")]
        [HttpPost]
        public void Edit(AdminModel admin)
        {
            AdminService.Edit(admin);
        }
        [Route("api/Admin/Delete")]
        [HttpPost]
        public void Delete(AdminModel admin)
        {
            AdminService.Delete(admin);
        }
    }
}