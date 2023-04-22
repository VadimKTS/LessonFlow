using Lesson15main_2.Models.EFDto;
using Microsoft.EntityFrameworkCore;

namespace Lesson15main_2.Models
{
	public class ApplicationContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Manufacture> Manufactures { get; set; }
        public DbSet<PayCard> PayCard { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
		{
            //Database.EnsureCreated();
        }
		protected override void OnModelCreating(ModelBuilder modelbuilder)
		{
            var manufacture1 = new Manufacture { Id = 1, Name = "Google", CountOfMembers = 540 };
            var manufacture2 = new Manufacture { Id = 2, Name = "Microsoft", CountOfMembers = 400 };
            var manufacture3 = new Manufacture { Id = 3, Name = "Intel", CountOfMembers = 250 };


            modelbuilder.Entity<Manufacture>().HasData(
               manufacture1,
               manufacture2,
               manufacture3
               );

            var card1 = new PayCard { Id = 1, BankName = "АльфаБанк", Number = "3215-1235-1235", ManufactureId = 1 };
            var card2 = new PayCard { Id = 2, BankName = "Дабрабыт", Number = "3578-3467-3457",ManufactureId = 2 };
            var card3 = new PayCard { Id = 3, BankName = "БелАПБ", Number = "3255-6509-5700", ManufactureId = 3 };

            modelbuilder.Entity<PayCard>().HasData(
                card1,
                card2,
                card3
                );

            //modelbuilder.Entity<PayCard>().HasData(
            //    card1.Manufacture = manufacture1,
            //    card2.Manufacture = manufacture2,
            //    card3.Manufacture = manufacture3
            //    ) ;

            modelbuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Vadik", LastName = "Tatyrzha", Age = 35, Address = "Slobodskaya 17", ManufactureId = 1 },
                new User { Id = 2, Name = "Artem", LastName = "Zyglin", Age = 30, Address = "Lobanka 45", ManufactureId = 2 },
                new User { Id = 3, Name = "Paul", LastName = "Krechko", Age = 31, Address = "Zhilunovicha 24", ManufactureId = 3 }
            );




        }
	}
}
