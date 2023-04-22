using System;
using System.Data.Entity;
 
namespace Test_EntityFramework
{
	public class MyDbContext : DbContext
	{
		public MyDbContext() : base("DbConnectionString")
		{
		
		}

		public DbSet<Group> Groups { get; set; }
		public DbSet<Song> Songs { get; set; }
	}
}
