using AFI_DAL.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFI_BussinesLayer.Services;

namespace AFI_API.Controllers
{
    [Route("api/[Customer]")]
    [ApiController]
    public class CustomerController : ControllerBase
{
        CustomerService customerService;
        public CustomerController(CustomerService _customerService)
        {
            this.customerService = _customerService;

        }
        [HttpPost]
        public int registerCustomer(Customer customer)
        {
            return customerService.registerCustomer(customer);
        }
    }
}
