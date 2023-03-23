namespace Lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 522;
            //int result = num / 0;  // ошибка. деление на ноль
            //Console.WriteLine($"Результат: {result}");
            //Console.WriteLine("Конец программы");

            //try
            //{
            //    int num = 522;
            //    int result = num / 0;  // ошибка. деление на ноль
            //    Console.WriteLine($"Результат: {result}");
            //}
            //catch 
            //{

            //    Console.WriteLine("Возникло исключение!");
            //}
            //finally { }//выполниться в любом случае

            //Console.WriteLine("Конец программы");

            //try
            //{
            //    string  password = "12345";
            //    string confirmPasword = "123456йц";
            //    if (!password.Equals(confirmPasword))
            //    {
            //        throw new Exception("Пароли не совпадают");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}

            try
            {
                var login = new Login { Value = "Vadik", ConfirmLogin = "Vadik" };
                //throw new LoginException("ОК. Пароли совпадают");                     
            }
            catch ( LoginException ex)
            {
                Console.WriteLine($"Ошибка!!!--- {ex.Message}");                 
            }




            //Console.WriteLine("Hello, World!");
        }
    }
}