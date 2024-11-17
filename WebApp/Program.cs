using DAL.Models.Concretes;
using DAL.Repository.Abstracts;
using DAL.Repository.Concretes;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BLL.Services.Abstracts;
using BLL.Services.Concretes;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<FoodContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<FoodContext>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IServiceManager<>), typeof(ServiceManager<>));

builder.Services.AddScoped<IFoodServiceManager, FoodServiceManager>();
builder.Services.AddScoped<ICategoryServiceManager, CategoryServiceManager>();
builder.Services.AddScoped<IMenuServiceManager, MenuServiceManager>();
builder.Services.AddScoped<IMenuItemServiceManager, MenuItemServiceManager>();

//Login Cookie
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.Name = "AccountCookie";
    options.LoginPath = "/Account/Login";
    options.AccessDeniedPath = "/Account/AccessDenied";
    options.LogoutPath = "/Account/Logout";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    options.SlidingExpiration = true;
});



var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
