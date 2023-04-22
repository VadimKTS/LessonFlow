namespace Lesson15main_2.Models.EFDto
{
	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public string Address { get; set; }
        public int? ManufactureId { get; set; } // Foreign key
        public Manufacture Manufacture { get; set; } // Reference navigation
    }
}
