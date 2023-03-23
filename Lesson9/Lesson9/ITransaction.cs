namespace Lesson9
{
    public interface ITransaction
    {
        public void CreateAccount();
        public void ShowAccount();
        public void ModifyAccount(int accountId);
        public void MoneyDeposit();
        public void MoneyWithdraw();
        public void BalanceShow();
    }
}
