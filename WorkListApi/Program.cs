

using Microsoft.EntityFrameworkCore;
using NewWorkPlaceDomain.Interface;
using NewWorkPlaceInfrastructure;
using NewWorkPlaceInfrastructure.Repository;
using NewWorkPlaceInfrastructure.Seeders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IRegisterToFindJob, RegisterToFindJobRepository>();
builder.Services.AddScoped<IRegisterToTakeJob, RegisterToTakeJobRepository>();
builder.Services.AddScoped<SeederRoles>();

var connectionString = 

builder.Services.AddDbContext<NewWorkPlaceDbContext>(options =>
    options.UseSqlServer(connectionString));
var app = builder.Build();

var scope = app.Services.CreateScope();

var seeder = scope.ServiceProvider.GetRequiredService<SeederRoles>();
await seeder.Seed();
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
