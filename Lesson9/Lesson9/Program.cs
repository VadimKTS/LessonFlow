namespace Lesson9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var b = new B();
            var c = new C();
            Console.Write(b.Sum(2, 3));
            Console.Write(c.Sum(2, 3));
            Console.ReadLine();
        }
    }
    class A
    {
        public virtual int Sum(int a, int b)
        {

            teachmeskills.by
        
return a + b;
        }
    }
    class B : A
    {

    }
    class C : A
    {
        public override int Sum(int a, int b)
        {
            return a + b + 1;
        }
    }





    //int ex = char.Parse(Console.ReadLine());//

    //var intro = new IntroStruct();
    //var transaction = new AccountTransact();

    //int opt;

    //intro.Intro();
    //intro.Loading();
    //Console.Clear();

    //do
    //{
    //    Console.Write("\n\tОсновное Меню");
    //    Console.Write("\n 1. Создать новый Аккаунт");
    //    Console.Write("\n 2. Посмотреть информацию об Аккаунте");
    //    Console.Write("\n 4. Внести сумму на баланс Счета");
    //    Console.Write("\n 5. Вывести деньги с баланса");
    //    Console.Write("\n 6. Обновите информацию об Аккаунте");
    //    Console.Write("\n 7. Выход из приложения");
    //    Console.Write("\n Выбери опцию (1-7)");
    //    opt = int.Parse(Console.ReadLine());
    //    Console.Clear();
    //    switch (opt)
    //    {
    //        case (int)Options.New:
    //            {
    //                Console.Clear();
    //                intro.Loading();
    //                Console.Clear();
    //                transaction.CreateAccount();
    //                break;
    //            }
    //        case (int)Options.Exit:
    //            {
    //                Environment.Exit(0);
    //                break;
    //            }
    //        case (int)Options.Show:
    //            {
    //                Console.Clear();
    //                intro.Loading();
    //                Console.Clear();
    //                transaction.ShowAccount();
    //                break;
    //            }
    //        case (int)Options.Deposit:
    //            {
    //                Console.Clear();
    //                intro.Loading();
    //                Console.Clear();
    //                transaction.MoneyDeposit();
    //                break;
    //            }
    //        case (int)Options.Withdraw:
    //            {
    //                Console.Clear();
    //                intro.Loading();
    //                Console.Clear();
    //                transaction.MoneyWithdraw();
    //                break;
    //            }
    //        case (int)Options.BalanceShow:
    //            {
    //                Console.Clear();
    //                intro.Loading();
    //                Console.Clear();
    //                transaction.BalanceShow() ;
    //                break;
    //            }
    //        case (int)Options.Modify:
    //            {
    //                Console.Clear();
    //                intro.Loading();
    //                Console.Clear();
    //                Console.WriteLine("Введите Id Аккаунта");
    //                int id = int.Parse(Console.ReadLine());
    //                transaction.ModifyAccount(id);
    //                break;
    //            }
    //    }
    //} while ( opt != (int)Options.Exit );

    //Console.WriteLine("Hello, World!");
}
    }
}