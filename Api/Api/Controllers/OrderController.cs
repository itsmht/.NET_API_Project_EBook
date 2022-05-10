using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class OrderController : ApiController
    {
        [Route("api/Order/Give/{id}")]
        [HttpPost]
        public void GiveOrder(int id)
        {
            OrderService.GiveOrder(id);
        }
        [Route("api/Order/Approve/{id}")]
        [HttpPost]
        public void ApproveOrder(int id)
        {
            OrderService.ApproveOrder(id);
        }
        [Route("api/Order/Cancel/{id}")]
        [HttpPost]
        public void CancelOrder(int id)
        {
            OrderService.CancelOrder(id);
        }
        [Route("api/Order/Rating5/{id}")]
        [HttpPost]
        public void GiveRating5(int id)
        {
            OrderService.GiveRating5(id);
        }
        [Route("api/Order/Rating4/{id}")]
        [HttpPost]
        public void GiveRating4(int id)
        {
            OrderService.GiveRating4(id);
        }
        [Route("api/Order/Rating3/{id}")]
        [HttpPost]
        public void GiveRating3(int id)
        {
            OrderService.GiveRating3(id);
        }
        [Route("api/Order/Rating2/{id}")]
        [HttpPost]
        public void GiveRating2(int id)
        {
            OrderService.GiveRating2(id);
        }
        [Route("api/Order/Rating1/{id}")]
        [HttpPost]
        public void GiveRating1(int id)
        {
            OrderService.GiveRating1(id);
        }



    }
}