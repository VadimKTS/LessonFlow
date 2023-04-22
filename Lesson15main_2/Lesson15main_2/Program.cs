using Lesson15main_2.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson15main_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            string connection = builder.Configuration.GetConnectionString("DefaultConnection"); //получаем строку подключения
			// добавляем контекст ApplicationContext в качестве сервиса в приложение
			builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

            
			var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}