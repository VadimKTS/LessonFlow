using Microsoft.VisualBasic;

namespace Lesson9
{
    public class AccountTransact : AccountInfo, ITransaction
    {
        
        public void CreateAccount()
        {
            Console.WriteLine("-----Введи информацию об Аккаунте------");
            Console.Write("Введите Аккаунт Id");
            AccountId =int.Parse(Console.ReadLine());
            Console.Write("Введите Имя Аккаунта");
            AccountName = Console.ReadLine();
            Console.Write("Введите Тип Аккаунта (Коммерческий/Персональный  - C / P)");
            AccountType = char.Parse(Console.ReadLine());
            Console.Write("Введите Депозит");
            Deposit = decimal.Parse(Console.ReadLine());
        }

        public void ModifyAccount(int accountId)
        {
            if (accountId == AccountId)
            {
                Console.Write("-----Обновление Аккаунта------");
                Console.Write($"Текущий Аккаунт Id {AccountId} ");
                Console.Write("Обновите Имя Аккаунта");
                AccountName = Console.ReadLine();
                Console.Write("Обновите Тип Аккаунта (Коммерческий/Персональный  - C / P)");
                AccountType = char.Parse(Console.ReadLine());
            }
            else { Console.Write("Неверный Id Аккаунта"); }
            
        }

        public void MoneyDeposit()
        {
            decimal amount;
            Console.Write("Введи сколько ты хочешь внести Денег:");
            amount = decimal.Parse(Console.ReadLine());
            Deposit += amount;
        }

        public void MoneyWithdraw()
        {
            decimal amount;
            Console.Write("Введи сколько ты хочешь вывести Денег:");
            amount = decimal.Parse(Console.ReadLine());
            Deposit -= amount;
        }

        public void ShowAccount()
        {
            Console.WriteLine("-----Информация об Аккаунте------");
            Console.WriteLine($"Аккаунт Id = {AccountId}");
            Console.WriteLine($"Имя Аккаунта = {AccountName}");
            Console.WriteLine($"Тип Аккаунта = {AccountType}");
            Console.WriteLine($"Баланс Аккаунта = {Deposit}");
            Console.WriteLine($"Время создания Аккаунта - {OpenedDate.ToString("dd-MM-yyyy HH:mm")}"); // ввести формат
        }
        public void BalanceShow()
        {
            Console.WriteLine("-----Информация о текущем балансе------");
            Console.WriteLine($"Аккаунт Id = {AccountId}");
            Console.WriteLine($"Баланс Аккаунта = {Deposit}");
        }
    }
}
