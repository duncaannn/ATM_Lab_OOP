using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Lab_OOP
{
    class Account
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }

        public Account() { }
        public Account (string Name, string Password, int Balance)
        {
            this.Name = Name;
            this.Password = Password;
            this.Balance = Balance;

        }

        public Account(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
       
}
