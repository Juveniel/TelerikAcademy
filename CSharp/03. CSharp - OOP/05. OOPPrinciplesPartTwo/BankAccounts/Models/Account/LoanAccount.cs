namespace BankAccounts.Models.Accounts
{
    using System;
    using Customers;

    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterestRate(int months)
        {
            int zeroInterestMonthsCount = 0;

            if (this.Customer is Company)
            {
                zeroInterestMonthsCount = 2;
            }
            else if (this.Customer is Individual)
            {
                zeroInterestMonthsCount = 3;
            }

            return (months - zeroInterestMonthsCount) * this.InterestRate;
        }

        public override Account WithdrawSum(decimal amount)
        {
            Console.WriteLine("Customer {0} cannot withdrawl from this account type: {1}", this.Customer.Name, this.GetType().Name);

            return this;
        }
    }
}
