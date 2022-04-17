using System;
using System.Collections.Generic;
using System.Text;

namespace PRACTICE
{
    class Admin:User
    {
        public bool  IsSuperAdmin { get; set; }
        public string Section { get; set; }
        public Admin(string username,int password,bool isSuperAdmin,string section):base(username,password)
        {
            IsSuperAdmin = isSuperAdmin;
            Section = section;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Username:{Username} Password{Password} IsSuperAdmin{IsSuperAdmin} Section{Section}");
        }

    }
}
