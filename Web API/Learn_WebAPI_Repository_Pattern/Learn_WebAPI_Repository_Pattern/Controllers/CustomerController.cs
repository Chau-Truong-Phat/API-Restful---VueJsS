using Repository;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Learn_WebAPI_Repository_Pattern.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*", SupportsCredentials = true)]
    public class CustomerController : ApiController
    {
        private readonly ICustomerService _customerService;
        public CustomerController()
        {
            _customerService = new CustomerService();
        }
        [Route("api/Customer/GetCustomers")]
        public IHttpActionResult GetCustomers()
        {
            return Json(_customerService.GetCustomers());
        }

        [Route("api/Customer/AddOrUpdateCustomer")]
        public IHttpActionResult AddOrUpdateCustomer(AddOrUpdateCustomerDto _customerDto)
        {
            return Json(_customerService.AddOrUpdateCustomer(_customerDto));
        }

        [Route("api/Customer/GetCustomerById")]
        public IHttpActionResult GetCustomerById(int _customerId)
        {
            return Json(_customerService.GetCustomerById(_customerId));
        }

        [Route("api/Customer/GetCustomerByNumberPhone")]
        public IHttpActionResult GetCustomerByNumberPhone(string _numberPhone)
        {
            return Json(_customerService.GetCustomerByNumberPhone(_numberPhone));
        }

        [Route("api/Customer/GetCustomerIdByNumberPhone")]
        public IHttpActionResult GetCustomerIdByNumberPhone(string _numberPhone)
        {
            return Json(_customerService.GetCustomerIdByNumberPhone(_numberPhone));
        }

        [Route("api/Customer/GetCustomerNameByNumberPhone")]
        public IHttpActionResult GetCustomerNameByNumberPhone(string _numberPhone)
        {
            return Json(_customerService.GetCustomerNameByNumberPhone(_numberPhone));
        }

        [Route("api/Customer/GetListCustomerByName")]
        public IHttpActionResult GetListCustomerByName(string _name)
        {
            return Json(_customerService.GetListCustomerByName(_name));
        }
    }
}
