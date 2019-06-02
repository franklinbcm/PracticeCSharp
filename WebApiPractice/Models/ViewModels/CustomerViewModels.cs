using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiPractice.Models.ViewModels
{
    public class CustomerViewModels
    {
        public static IEnumerable<CustomerModels> GetCustomerList()
        {
            List<CustomerModels> list = new List<CustomerModels>()
        {   new CustomerModels(){ CustomerId=1, City="San Juan", Name="Franklin" },
            new CustomerModels(){ CustomerId=2, City="Santiago", Name="Pedro" },
            new CustomerModels(){ CustomerId=3, City="Mao", Name="Miguel" }

        };
            return list;
        }
    }
}