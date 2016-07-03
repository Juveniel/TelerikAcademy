namespace BankAccounts.Models.Accounts.Interfaces
{
    public interface IDepositable<T>
    {
        T DepositSum(decimal amount);
    }
}
