using Data_Access_Layer.dbContext;
using Microsoft.EntityFrameworkCore;
using Session2User.Interface;
using Session2User.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IService, Service>();
var LocalString = builder.Configuration.GetConnectionString("LocalDbConnection");
builder.Services.AddDbContext<UserDbContext>(u => u.UseSqlServer(LocalString));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=GetAllUser}/{id?}");

app.Run();
