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
    public class DashboardController : ApiController
    {
        [Route("api/Dashboard/CustomerOrders")]
        [HttpGet]
        public List<OrderDetailModel> CustomerOrders()
        {
            return DashboardService.CustomerOrders();
        }
        [Route("api/ProductBook/Activate/{id}")]
        [HttpPost]
        public void Activate(int id)
        {
            DashboardService.Activate(id);
        }
        [Route("api/ProductBook/Deactivate/{id}")]
        [HttpPost]
        public void Deactivate(int id)
        {
            DashboardService.Deactivate(id);
        }
        [Route("api/ProductBook/ConditionA/{id}")]
        [HttpPost]
        public void ConditionAvailable(int id)
        {
            DashboardService.ConditionAvailable(id);
        }
        [Route("api/ProductBook/ConditionB/{id}")]
        [HttpPost]
        public void ConditionUnAvailable(int id)
        {
            DashboardService.ConditionUnAvailable(id);
        }

    }
}