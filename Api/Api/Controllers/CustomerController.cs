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
    public class CustomerController : ApiController
    {
        [Route("api/Customer/GetNames")]
        [HttpGet]
        public List<string> GetNames()
        {
            return CustomerService.GetNames();
        }
        [Route("api/Customer/Get")]
        [HttpGet]
        public List<CustomerModel> Get()
        {
            return CustomerService.Get();
        }
        [Route("api/Customer/Create")]
        [HttpPost]
        public void Add(CustomerModel customer)
        {
            CustomerService.Add(customer);
        }
        [Route("api/Customer/Edit")]
        [HttpPost]
        public void Edit(CustomerModel customer)
        {
            CustomerService.Edit(customer);
        }
        [Route("api/Customer/Delete")]
        [HttpPost]
        public void Delete(CustomerModel customer)
        {
            CustomerService.Delete(customer);
        }
        [Route("api/Customer/Get/{id}")]
        [HttpGet]
        public CustomerModel Get(int id)
        {
            return CustomerService.Get(id);
        }
    }
}