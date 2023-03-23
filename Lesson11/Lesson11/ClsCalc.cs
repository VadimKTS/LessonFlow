namespace Lesson11
{
    public class ClsCalc<T>
    {
        private  T Value1;
        private  T Value2;
        private bool result = default;

        public ClsCalc(T value1, T value2)
        {
            Value1 = value1;
            Value2 = value2;
        }

        public bool Equal(T value1, T value2)
        { return value1.Equals(value2); }
    }
}