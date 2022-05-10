using BLL;
using BLL.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class CartController : ApiController
    {
        [Route("api/Cart/Get")]
        [HttpGet]
        public List<CartModel> Get()
        {
            return CartService.Get();
        }
        [Route("api/Cart/Create")]
        [HttpPost]
        public void Add(CartModel cart)
        {
            CartService.Add(cart);
        }
        [Route("api/Cart/Edit")]
        [HttpPost]
        public void Edit(CartModel cart)
        {
            CartService.Edit(cart);
        }
        [Route("api/Cart/Delete")]
        [HttpPost]
        public void Delete(CartModel cart)
        {
            CartService.Delete(cart);
        }
        [Route("api/Cart/Get/{id}")]
        [HttpGet]
        public CartModel Get(int id)
        {
            return CartService.Get(id);
        }
    }
}
