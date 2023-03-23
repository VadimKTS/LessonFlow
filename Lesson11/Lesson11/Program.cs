namespace Lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GenericClass<int> intGeneric = new GenericClass<int>(42);
            //var intValue = intGeneric.GetValue();
            //Console.WriteLine(intValue);
            ////intGeneric.GenerikField = 122;
            ////intGeneric.GenerikField = 122.22;

            //GenericClass<double> doubleGeneric = new GenericClass<double>(12.2);
            //Console.WriteLine($"{doubleGeneric.GetValue()}");

            //var stringGeneric = new GenericClass<string>("Hellow Guys");
            //Console.WriteLine(stringGeneric.GetValue());


            //var myGeneric = new GenericClass<string, int>("ABC", 12);
            //var v = myGeneric.GetValue();
            //Console.WriteLine(v);

            //var person = new Person<int>(546, "Vadik");
            //Person<int>.code = 1234;

            //var max = new Person<string>("test", "Maxim");
            //Person<string>.code = "madMax";

            //var result = ClsCalc<string>.Equal("Vadik", "Vadik1");
            //Console.WriteLine(result);

            //result = ClsCalc<int>.Equal(12, 13);
            //Console.WriteLine(result);


            var test1 = new Class1<int>();
            test1.Test1( 12 );

            var test2 = new Class2<Enum>();
            test2.Test2(EnumTest.qwert);


            //Console.WriteLine("Hello, World!");
        }
    }
        //public class GenericClass : IGenericInterface<int> 
        //{ 
        //    public void PrintValue(int value) 
        //    {
        //        throw new NotImplementedException();
        //    }

        //    //void IGenericInterface<int>.PrintValue(int value)
        //    //{
        //    //    throw new NotImplementedException();
        //    //}
        //}
    


        //class Person<T>
        //{
        //public static T? code; 
        //public  T Id { get; set; }
        //public string Name { get; set; }
        //public Person(T id, string name) 
        //    {
        //        Id = id;
        //        Name = name;
        //    }
        //}
    
}