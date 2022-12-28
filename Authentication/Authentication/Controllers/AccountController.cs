using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Controllers
{
    public class AccountController
    {
        public void Login()
        {
            Console.WriteLine("Please Add Email");
            string email = Console.ReadLine();

            Console.WriteLine("Please Add Password");
            string password = Console.ReadLine();

            int roleId = 1;

            IAccountService account = new AccountService();

            string result = account.Login(email, password, roleId);

            Console.WriteLine(result);

        }

    }
}
