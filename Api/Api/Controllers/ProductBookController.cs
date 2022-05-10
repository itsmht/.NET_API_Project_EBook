using Bll.BEnt;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class ProductBookController : ApiController
    {
        [Route("api/ProductBook/Get")]
        [HttpGet]
        public List<ProductBookModel> Get()
        {
            return ProductBookService.Get();
        }
        [Route("api/ProductBook/Create")]
        [HttpPost]
        public void Add(ProductBookModel productBook)
        {
            ProductBookService.Add(productBook);
        }
        [Route("api/ProductBook/Edit")]
        [HttpPost]
        public void Edit(ProductBookModel productBook)
        {
            ProductBookService.Edit(productBook);
        }
        [Route("api/ProductBook/Delete")]
        [HttpPost]
        public void Delete(ProductBookModel productBook)
        {
            ProductBookService.Delete(productBook);
        }
    }
}