using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Lab_OOP
{
    class ATM
    {
        private Account currentAccount;
        private List<Account> accounts;

        public Account CurrentAccount
        {
            get { return currentAccount; }
            set { currentAccount = value; }
        }
        public List<Account> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public ATM()
        {
            Accounts = new List<Account>();
            CurrentAccount = null;
        }
        
        public void Register(string name, string password)
        {
            Account account = new Account(name, password);
            //Account account= new Account();
            //account.Name = name;
            //account.Password = password;

            Accounts.Add(account);
            Console.WriteLine("Successfully Registered.");
        }

        public void Login (string username, string password)
        {
            if (CurrentAccount==null)
            {
                for (int i = 0; i <Accounts.Count; i++)
                {
                    if(Accounts[i].Name == username && Accounts[i].Password == password)
                    {
                        CurrentAccount = Accounts[i];
                        Console.WriteLine("Successfully Logged in...");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error. User still logged in.");
            }

        }
        public void Logout()
        {
            CurrentAccount = null;
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Your current balance is {CurrentAccount.Balance:C2}");
        }
        public void Deposit (int amount)
        {
            CurrentAccount.Balance += amount;       
        }
public void Withdraw(int amount)
    {
        if(CurrentAccount.Balance >= amount)
        {
                CurrentAccount.Balance -= amount;
        }
        else
            {
                Console.WriteLine("Insufficient Funds!");
            }
    }
    }
}
