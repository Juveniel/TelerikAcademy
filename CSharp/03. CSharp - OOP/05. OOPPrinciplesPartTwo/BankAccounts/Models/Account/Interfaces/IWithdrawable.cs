namespace BankAccounts.Models.Accounts.Interfaces
{
    public interface IWithdrawable<T>
    {
        T WithdrawSum(decimal amount);
    }
}
