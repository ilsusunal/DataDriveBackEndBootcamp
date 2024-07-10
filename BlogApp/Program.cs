using BlogApp.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BlogContext>(options => {
    var config = builder.Configuration;
    var connectionString = config.GetConnectionString("sql_connection");
    options.UseSqlite(builder.Configuration["ConnectionStrings:sql_connection"]);
});
var app = builder.Build();

app.UseStaticFiles();

SeedData.CreateTestData(app);

app.MapDefaultControllerRoute();

app.Run();
