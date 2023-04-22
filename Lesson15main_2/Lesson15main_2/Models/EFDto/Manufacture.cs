namespace Lesson15main_2.Models.EFDto
{
	public class Manufacture
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public int CountOfMembers { get; set; }
        public IList<PayCard> PayCards { get; } = new List<PayCard>(); // Collection navigation
        public IList<User> Users { get; } = new List<User>(); // Collection navigation
        //public User Users { get; set; } // Reference navigation
    }
}
