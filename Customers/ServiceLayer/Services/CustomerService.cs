using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CustomerService : ICustomerService
    {
        public int GetCustomerCountByFiltered()
        {
            var customers = GetAll();

            int count = 0;

            foreach (var item in customers)
            {
                if (item.Age > 25 && item.Age < 30)
                {
                    count++;
                }
            }
              return count;
        }

        public double GetCustomersAverageByAges()
        {
            var customers = GetAll();

            double sumAge = 0;


            foreach (var item in customers)
            {
                sumAge += item.Age;
            }

            return sumAge / customers.Length;

        }



       private Customer[] GetAll()
        {
            Customer c1 = new Customer
            {
                Id = 1,
                Name = "Mirze",
                Surname = "Beshirzade",
                Age = 26,
                Position = "FullStack-Developer (Allah Qoysa)"

            };




            Customer c2 = new Customer
            {
                Id = 2,
                Name = "Hemze",
                Surname = "Elizade",
                Age = 25,
                Position = "Geolog (Allah Qoysa)"

            };



            Customer c3 = new Customer
            {
                Id = 3,
                Name = "Eli",
                Surname = "Kazimov",
                Age = 23,
                Position = "Musqant"

            };




            Customer c4 = new Customer
            {
                Id = 4,
                Name = "Efqan",
                Surname = "Kazimov",
                Age = 30,
                Position = "Vekil"

            };


            Customer[] customers = { c1, c2, c3, c4 };
            return customers;


        }
        
    }
}
