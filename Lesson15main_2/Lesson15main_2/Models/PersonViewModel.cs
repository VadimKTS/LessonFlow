using System.ComponentModel.DataAnnotations;

namespace Lesson15main_2.Models
{
    public class PersonViewModel
	{
		[MaxLength(16)]
		public string UserName { get; set; }
		[MinLength(8)]
		public string Password { get; set; }
		[MinLength(8)]
		public string ConfirmPassword { get; set; }
		[MaxLength(16)]
		public string Adress { get; set; }
    }
}