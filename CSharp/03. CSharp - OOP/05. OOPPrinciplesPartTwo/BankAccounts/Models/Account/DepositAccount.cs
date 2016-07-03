namespace BankAccounts.Models.Accounts
{
    using Customers;

    public class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterestRate(int months)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }

            return months * this.InterestRate / 100;
        }
    }
}
