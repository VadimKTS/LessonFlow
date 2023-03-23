namespace Lesson9
{
    struct IntroStruct
    {
        public void Intro() 
        {
            Console.WriteLine("Добро пожаловать в наш Банк");
        }

        public void Loading() 
        {
            Console.WriteLine("Загрузка");
            for (int i = 0; i < 5; i++)
            {
                Console.Write('#');
                Thread.Sleep(500);  // позволяет сделать задержку
            }
        }

    }
}
