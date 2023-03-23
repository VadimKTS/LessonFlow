namespace Lesson8
{

    //struct Equipment
    //{ string Sword;
    //    string Shield;
    //    string Armor; 

    //public Equipment(string Sword, string Shield, string Armor)
    //    {
    //        this.Sword = Sword;
    //        this.Shield = Shield;
    //        this.Armor = Armor;
    //    }
    //}
     
    public enum DayOfTheWeek 
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dayNow = DayOfTheWeek.Monday;

            switch (dayNow)
            {
                case DayOfTheWeek.Sunday:
                    Console.WriteLine(DayOfTheWeek.Sunday);
                    break;
                case DayOfTheWeek.Monday:
                    Console.WriteLine(DayOfTheWeek.Monday);
                    break;                     
                case DayOfTheWeek.Tuesday:
                    Console.WriteLine(DayOfTheWeek.Tuesday);
                    break;
                case DayOfTheWeek.Wednesday:
                    Console.WriteLine(DayOfTheWeek.Wednesday);
                    break;
                case DayOfTheWeek.Thursday:
                    Console.WriteLine(DayOfTheWeek.Thursday);
                    break;
                case DayOfTheWeek.Friday:
                    Console.WriteLine(DayOfTheWeek.Friday);
                    break;
                case DayOfTheWeek.Saturday:
                    Console.WriteLine(DayOfTheWeek.Saturday);
                    break;
            }
            
            
            
            
            
            
            //Equipment player1 = new Equipment("Меч1", "Щит1", "Кирасса1");
            //Equipment player2 = new Equipment("Меч2", "Щит2", "Кирасса2");

            //Console.WriteLine(player1.Armor);
            //Console.WriteLine(player2.Shield);
            
            
            
            //var car1 = new Car();
            //car1.Move();
            //car1.Stop();
            //Console.WriteLine(car1.Speed);
            //var car2 = new Car();

            //var train1 = new Train();
            //train1.Move();
            //train1.Stop();
            //Console.WriteLine(train1.Speed);
            //var train2 = new Train();

            //var plane1 = new Plane();
            //plane1.Move();
            //plane1.Stop();
            //Console.WriteLine(plane1.Speed);
            //var plane2 = new Plane();

            //Console.WriteLine(Operations.Pow(5,2));
            //Console.WriteLine(Operations.Pow(5, 0));

            //Console.WriteLine(Operations.Abs(-5));
            //Console.WriteLine(Operations.Abs(5));







            //Console.WriteLine("Hello, World!");
        }
    }
}