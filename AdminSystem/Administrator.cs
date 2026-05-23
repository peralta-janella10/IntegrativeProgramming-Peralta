using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSystem
{
    internal class Administrator : User
    {
        private string admin_name;

        public Administrator(string name, string id, string pass)
            : base(id, pass)
        {
            admin_name = name;
        }

        public override void updatePassword(string newPassword)
        {
            user_password = newPassword;
        }

        public void updateAdminName(string name)
        {
            admin_name = name;
        }

        public string getAdminName()
        {
            return admin_name;
        }
    }
}
