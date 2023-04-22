using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap6._1_HuynhLeAnhVu
{
    public class User
    {
        public String user_name;
        public String password;

        public User() { }
        public User(String user_name, String password)
        {
            this.user_name = user_name;
            this.password = password;
        }
    }
}
