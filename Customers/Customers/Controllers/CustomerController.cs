using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.Controllers
{
    public class CustomerController
    {
        private readonly ICustomerService _service;

        public CustomerController()
        {
            _service = new CustomerService();

        }

        public void GetCustomerCountByFiltered()
        {
            Console.WriteLine(_service.GetCustomerCountByFiltered());

        }
        public void GetCustomersAverageByAges()
        {
            Console.WriteLine(_service.GetCustomersAverageByAges());


        }

    }
}
