using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal class UserAccount
    {
        private string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount(string name, string Uname, string password)
        {
            full_name = name;
            user_name = Uname;
            user_password = password;
        }
        public bool validateLogin(string Uname, string password)
        {
            return user_name == Uname && user_password == password;
        }
        public string getFullName()
        {
            return full_name;
        }
    }
}
