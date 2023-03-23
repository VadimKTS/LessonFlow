namespace Lesson11
{
    public class Class2<T>  where T : Enum
    {
        public void Test2(T value)
        {
            //Console.WriteLine(Enum.GetValues(((Enum)value).GetType()));
        }
    }
}