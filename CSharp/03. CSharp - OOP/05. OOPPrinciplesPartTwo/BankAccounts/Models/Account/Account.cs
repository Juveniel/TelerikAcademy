namespace BankAccounts.Models.Accounts
{
    using System;   
    using Customers;
    using Interfaces;

    public abstract class Account : IDepositable<Account>, IWithdrawable<Account>
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customer cannot be null!");
                }

                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            set
            {
                this.interestRate = value;
            }
        }

        public virtual Account DepositSum(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Cannot deposite a negative amount of money!");
            }
            else
            {
                this.Balance += amount;
                Console.WriteLine("Customer {0} deposited {1} successfully!", this.Customer.Name, amount);
            }

            return this;
        }

        public virtual Account WithdrawSum(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("You cannot withdraw negative amount of money!");
            }
            else
            {
                this.Balance -= amount;
                Console.WriteLine("Customer {0} withdrawed {1} successful", this.Customer.Name, amount);
            }

            return this;
        }

        public abstract decimal CalculateInterestRate(int months);

        public override string ToString()
        {
            return string.Format("Customer: {0} | Balance: {1} | Interest rate: {2}", this.customer,  this.balance, this.interestRate);
        }       
    }
}
