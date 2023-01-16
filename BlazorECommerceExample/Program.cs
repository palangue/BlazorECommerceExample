using BlazorECommersData.DataAccess.DataContexts;
using Microsoft.EntityFrameworkCore;

namespace BlazorECommerceExample;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();

        // in mac. startup project does not match library. so dotnet ef cli needs to apply startup path like this:
        // dotnet ef --startup-project migrations add First_Database_Migration

        builder.Services.AddDbContext<ECommersContext>(options =>
        {

            // var connectionString = builder.Configuration.GetConnectionString("MariaDb");
            // options.UseMySql(ServerVersion.AutoDetect(connectionString), p => {
            //     p.MigrationsAssembly("../BlazorECommersData.DataAccess");
                
            // });
        });

        var app = builder.Build();

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

        app.MapBlazorHub();
        app.MapFallbackToPage("/_Host");

        app.Run();
    }
}
