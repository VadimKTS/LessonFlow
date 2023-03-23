namespace Lesson9
{
    public class AccountInfo
    {
        private int accountId;
        private string accountName;
        private decimal deposit;
        private DateTime openedDate;
        private char accountType;

        public AccountInfo()
        {
            openedDate = DateTime.Now; // текущая дата и время
        }

        public int AccountId
        { 
            get { return accountId; } 
            set { accountId = value; } 
        }

        public string AccountName
        { 
            get { return accountName; } 
            set { accountName = value; }
        }

        public char AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }

        public decimal Deposit
        {

            get { return deposit; }
            set 
            {
                if (deposit >= 0)
                {
                    deposit = value;
                }
                else
                {
                    Console.WriteLine("Депозит не может быть меньше ноля!!!");
                } 
            }
        }

        // не нужно так как дата определяется сразу в конструкторе
        public DateTime OpenedDate
        {
            get { return openedDate; }
            set { openedDate = value; }
        }

    }
}
