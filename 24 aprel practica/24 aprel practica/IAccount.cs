using System;
using System.Collections.Generic;
using System.Text;

namespace _24_aprel_practica
{
    interface IAccount
    {
        public bool PasswordChecker(string password);
        public void ShowInfo();
    }
}
