using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Lesson13
{
    public class Doctor
    {
        //[XmlIgnore]
        [JsonIgnore]
        public string Name { get; set; }
        public int CountOfPatient { get; set; }
        //[XmlElement("Счетчик")]
        [JsonPropertyName("DN")]
        public int DepartmentNumber { get; set; }
        public string Specialization { get; set; }
        
        public Doctor() { }
        public Doctor(string name, int countOfPatient, int departmentNumber, string specialization)
        {
            Name = name;
            CountOfPatient = countOfPatient;
            DepartmentNumber = departmentNumber;
            Specialization = specialization;
        }
    }
}