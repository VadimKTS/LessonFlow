
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Test_EntityFramework
{
	public class Group
	{
		//[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public int? Year { get; set; }

		public virtual ICollection<Song> Songs { get; set; }
	}
}
