namespace BankAccounts.Models.Accounts
{
    using System;
    using Customers;

    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {       
        }

        public override decimal CalculateInterestRate(int months)
        {
            decimal currentInterestRate = 0;

            if (this.Customer is Company && months <= 12)
            {
                currentInterestRate = (this.InterestRate / 100) / 2;
            }
            else if (this.Customer is Individual && months <= 6)
            {
                currentInterestRate = 0;
            }

            return currentInterestRate * months;
        }

        public override Account WithdrawSum(decimal amount)
        {
            Console.WriteLine("Customer {0} cannot withdrawl from this account type: {1}", this.Customer.Name, this.GetType().Name);

            return this;
        }
    }
}
