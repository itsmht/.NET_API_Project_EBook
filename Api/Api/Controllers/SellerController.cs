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
    public class SellerController : ApiController
    {
        [Route("api/Seller/GetNames")]
        [HttpGet]
        public List<string> GetNames()
        {
            return SellerService.GetNames();
        }
        [Route("api/Seller/Get")]
        [HttpGet]
        public List<SellerModel> Get()
        {
            return SellerService.Get();
        }
        [Route("api/Seller/Create")]
        [HttpPost]
        public void Add(SellerModel seller)
        {
            SellerService.Add(seller);
        }
        [Route("api/Seller/Edit")]
        [HttpPost]
        public void Edit(SellerModel seller)
        {
            SellerService.Edit(seller);
        }
        [Route("api/Seller/Delete")]
        [HttpPost]
        public void Delete(SellerModel seller)
        {
            SellerService.Delete(seller);
        }
        [Route("api/Seller/Get/{id}")]
        [HttpGet]
        public SellerModel Get(int id)
        {
            return SellerService.Get(id);
        }
    }
}