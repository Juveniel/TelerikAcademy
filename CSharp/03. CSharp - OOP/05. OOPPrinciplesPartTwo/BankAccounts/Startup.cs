namespace BankAccounts
{
    using System;
    using Models;
    using Models.Accounts;
    using Models.Customers;

    public class Startup
    {
        public static void Main()
        {
            // 1. Create a new banl
            Bank obb = new Bank("OBB");
            Console.WriteLine("Bank: {0} \r\n", obb.Name);

            // 2. Add new Accounts and  Customers and test deposit/withdrawal
            Console.WriteLine("Daily operations: ");
            Account[] accounts =
            {
                new DepositAccount(new Individual("Petar Petrov"), 2500, 45).WithdrawSum(500).DepositSum(3000.25M),
                new LoanAccount(new Company("Expanziq"), 250, 20).DepositSum(200).WithdrawSum(2000),
                new MortgageAccount(new Company("BBC"), 5000, 15).DepositSum(5000).WithdrawSum(200),              
            };
            obb.AddAccount(accounts);

            // 3. Print current bank data
            Console.WriteLine($"\r\n{obb}");

            // 4. Print calculated interest amount
            Console.WriteLine("Interest rates calculation");
            Console.WriteLine(new DepositAccount(new Individual("Gosho Goshev"), 2000, 45).CalculateInterestRate(5));
            Console.WriteLine(new DepositAccount(new Company("PG OOD"), 50000, 15).CalculateInterestRate(12));

            Console.WriteLine(new LoanAccount(new Individual("Alex Petrova"), 5500, 8).CalculateInterestRate(9));
            Console.WriteLine(new LoanAccount(new Company("Joro 2000"), 13000, 5).CalculateInterestRate(24));

            Console.WriteLine(new MortgageAccount(new Company("ADS"), 5000, 20).CalculateInterestRate(10));
            Console.WriteLine(new MortgageAccount(new Individual("Ivanka Ivanova"), 3020, 10).CalculateInterestRate(14));
        }
    }
}
