namespace Lesson11
{
    public class GenericClass<T, K>
    {
        private T value;
        private K key;
        public T GenerikField { get; set; }

        public GenericClass(T value, K key)
        {
            this.value = value;
            this.key = key;
        }

        public T GetValue()
        {
            Console.WriteLine( key );
            return value;
        }

        //internal void GetValue<T1, T2>()
        //{
        //    throw new NotImplementedException();
        //}
    }
}