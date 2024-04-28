using HW4.Data;
using HW4.Models.Abstract_entities;
using HW4.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();

string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<FriendContext>(x=>x.UseSqlServer(connection));


bool isDevelopment = builder.Environment.IsDevelopment();

if (isDevelopment)
{
    builder.Services.AddTransient<IFriendService, FriendService>();
}
else
{
    builder.Services.AddTransient<IFriendService, StubFriendService>();
}




var app = builder.Build();

//add db migrations aplly to db
var scope = app.Services.CreateScope();
using (scope)
{
    var db = scope.ServiceProvider.GetRequiredService<FriendContext>();
    db.Database.Migrate();
}

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
