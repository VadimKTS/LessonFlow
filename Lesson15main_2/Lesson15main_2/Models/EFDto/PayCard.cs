namespace Lesson15main_2.Models.EFDto
{
	public class PayCard
    {
		public int Id { get; set; }
		public string BankName { get; set; }
		public string Number { get; set; }
        public int? ManufactureId { get; set; } // Foreign key
        public Manufacture Manufacture { get; set; } // Reference navigation
    }
}
