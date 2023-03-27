using System.ComponentModel.DataAnnotations;

namespace Lesson15main_2.Models
{
    public class PersonInventoryModel
	{
		public string UserName  { get; set; }
		public string Password { get; set; }

		public PersonInventoryModel(string userName, string password) 
		{
			UserName = userName;
			Password = password;
		}
    }
}