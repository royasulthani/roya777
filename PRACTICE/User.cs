using System;
using System.Collections.Generic;
using System.Text;

namespace PRACTICE
{
    class User
    {
        private string _username;
        public string Username
        {
            get => _username;
            set
            {
                if (value.Length > 6)
                {
                    _username = value;
                }
            }
        }
        public User(string username, int password)
        {

            {
                Username = username;
                Password = password;
            }
            {

            }
        }
        private int _password;
        public int Password
        {
            get => _password;
            set
            {
                if (value > 0)
                {
                    _password = value;
                }
            }
        }
        
   
	{
        
        {      
        
	}  
        
    }
    
    public void ShowInfo();
}


   

