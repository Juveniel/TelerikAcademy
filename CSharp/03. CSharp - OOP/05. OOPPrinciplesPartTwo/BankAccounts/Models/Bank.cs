namespace BankAccounts.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Accounts;
    using Customers;
   
    public class Bank
    {
        private string name;
        private List<Account> accounts;
        private List<Customer> customers;
        
        public Bank(string name)
        {
            this.Name = name;
            this.accounts = new List<Account>();
            this.customers = new List<Customer>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Bank name cannot be empty!");
                }

                this.name = value;
            }
        }

        public List<Customer> Customers
        {
            get
            {
                return this.customers;
            }
        }

        public void AddAccount(Account[] accounts)
        {
            foreach (var account in accounts)
            {
                this.accounts.Add(account);
                this.customers.Add(account.Customer);
            }           
        }

        public override string ToString()
        {
            var bankData = new StringBuilder();
            var divider = new string('-', 40);

            bankData.AppendLine($"Accounts: ");

            foreach (var account in this.accounts)
            {
                bankData.AppendLine(account.ToString());
            }

            return bankData.ToString();
        }
    }
}
