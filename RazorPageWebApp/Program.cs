using Aspdotnet.Repository;

namespace RazorPageWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {   //configure services
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
			builder.Services.AddSingleton<IProductService, ProductService>();//to implement loosely coupled (dependency injection)
			var app = builder.Build();
            // Configuration of middleware
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
