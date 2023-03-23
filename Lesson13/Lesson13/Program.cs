using System.Runtime.Serialization;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text.Json;

namespace Lesson13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var book = new Book("Война и мир", "Лев Толстой", 960);
            //var formater = new BinaryFormatter();
            //using (var fs = new FileStream("MyBook.dat", FileMode.OpenOrCreate))
            //{
            //    formater.Serialize(fs, book);

            //    Console.WriteLine("Объект сериализован");
            //}


            //using (var fs = new FileStream("MyBook.dat", FileMode.OpenOrCreate))
            //{
            //    Book newPerson = (Book)formater.Deserialize(fs);
            //    Console.WriteLine("Объект десериализован");
            //}

            //-----------------------------------------------------------------

            //Doctor[] doctors =
            //{
            //    new Doctor("Хаус", 15, 582, "Хирург"),
            //    new Doctor("Быков", 100, 246, "Терапевт")
            //};

            //var formatter = new XmlSerializer(typeof(Doctor[]));

            //using (var fstream = new FileStream("doctors.xml", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fstream, doctors);

            //    Console.WriteLine("Объект сериализован");
            //}


            //using (var fstream = new FileStream("doctors.xml", FileMode.OpenOrCreate))
            //{
            //    Doctor[] newDoctor = formatter.Deserialize(fstream) as Doctor[];

            //    Console.WriteLine($"Объект десериализован");

            //}

            //-------------------------------------------------

            //var doctor = new Doctor("Alban",15, 76523, "Singer" );

            using ( var stream = new FileStream("Vadik.json", FileMode.OpenOrCreate) ) 
            {
                var doctor = new Doctor("Alban", 15, 76523, "Singer");
                JsonSerializer.Serialize(stream, doctor);
            }

            using (var stream = new FileStream("Vadik.json", FileMode.OpenOrCreate))
            {
                Doctor newdoctor = JsonSerializer.Deserialize<Doctor>(stream);
                Console.WriteLine($"{newdoctor.DepartmentNumber}");
            }



            //Console.WriteLine("Hello, World!");
        }
    }
}