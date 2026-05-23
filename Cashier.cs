using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string Uname, string password)
            : base(name, Uname, password)
        {
            department = "Finance";
        }
        public bool validateLogin(string Uname, string password)
        {
            return (user_name == Uname && user_password == password);
        }
        public string getDepartment()
        {
            return department;
        }
    }
}
