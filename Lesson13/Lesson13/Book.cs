using System.Xml.Serialization;

namespace Lesson13
{
    [Serializable]
    public class Book
    {
        public string Name { get; set; }
        public string AutorName { get; set; }
        public int CountOfPages { get; set; }
        //public Person() { }
        public Book(string name, string autorName, int countOfPages)
        {
            Name = name;
            AutorName = autorName;
            CountOfPages = countOfPages;
        }
    }
}