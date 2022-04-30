using System;
using System.Collections.Generic;
using System.Text;

namespace _24_aprel_practica
{
    class User : IAccount
    {
        public bool PasswordChecker(string password)
        {
            bool IsDigit = false;
            bool IsLower = false;
            bool IsUpper = false;
            if (password.Length >= 8)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsDigit(password[i]))
                        IsDigit = true;
                    else if (char.IsUpper(password[i]))
                        IsUpper = true;
                    else if (char.IsLower(password[i]))
                        IsLower = true;
                    if (IsLower && IsDigit && IsLower)
                    {
                        return (true);
                    }
                }
            }
            return false;

        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id} Fullname: { Fullname} Email:{Email}");
        }
        private static int _id;
        private string _password;
        public int Id { get; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
            }
        }
        public User(string fullname, string email, string password)
        {
            _id++;
            Id = _id;
            Fullname = fullname;
            Email = email;
            Password = password;
        }
    }
}
