using Microsoft.AspNetCore.Identity;
using NamEcommerce.Web.Data;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace NamEcommerce.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<NamEcommerceDbContext>(opts =>
                opts.UseSqlServer(builder.Configuration.GetConnectionString(nameof(NamEcommerceDbContext))));

            builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<NamEcommerceDbContext>();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            app.UseRouting();
            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}