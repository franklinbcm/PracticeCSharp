using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiPractice.Models;
using WebApiPractice.Models.ViewModels;

namespace WebApiPractice.Controllers
{
    public class CustomersController : ApiController
    {


        [HttpGet]
        public IEnumerable<CustomerModels> GetCustomerDetails()
        {

            return CustomerViewModels.GetCustomerList();
        }

        [HttpGet]
        public IEnumerable<CustomerModels> GetCustomerDetailsbyId(int customerId, string Info)
        {
            //Consumin Example: http://localhost:62902/Api/Customers/GetCustomerDetailsbyId?customerId=1

            return CustomerViewModels.GetCustomerList().Where(item=> item.CustomerId.Equals(customerId));
        }

    }
}
