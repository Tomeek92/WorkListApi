

using Microsoft.EntityFrameworkCore;
using NewWorkPlaceDomain.Interface;
using NewWorkPlaceInfrastructure;
using NewWorkPlaceInfrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IRegisterToFindJob, RegisterToFindJobRepository>();
builder.Services.AddScoped<IRegisterToTakeJob, RegisterToTakeJobRepository>();

var connectionString = "Server=DESKTOP-JD2U15O\\MSSQL1;Database=NewWorkList;Integrated Security=True;TrustServerCertificate=true;";

builder.Services.AddDbContext<NewWorkPlaceDbContext>(options =>
    options.UseSqlServer(connectionString));
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
