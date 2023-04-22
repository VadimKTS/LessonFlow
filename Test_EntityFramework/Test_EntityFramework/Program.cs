using System;
using System.Collections.Generic;

namespace Test_EntityFramework
{
	internal class Program
	{
		static void Main(string[] args)
		{
			using (var context = new MyDbContext())
			{


				var group = new Group()
				{
					Name = "Rammstein",
					Year = 1994
				};

				var group2 = new Group()
				{
					Name = "Linkin Park"
				};

				context.Groups.Add(group); //передаем в context(в кэш, не в БД)
				context.Groups.Add(group2);
				context.SaveChanges(); //передаем в БД

				var songs = new List<Song>
				{
					new Song() { Name = "In the end", GroupId = group2.Id},
					new Song() { Name = "Numb", GroupId = group2.Id},
					new Song() { Name = "Mutter", GroupId = group.Id},
					new Song() { Name = "Sonne", GroupId = group.Id}
				};
				context.Songs.AddRange(songs);
				context.SaveChanges();

				foreach (var song in songs)
				{
					Console.WriteLine($"Song name: {song.Name}, Group name: {song.Group?.Name}");
				}
				Console.ReadKey();
			}
		}
	}
}
