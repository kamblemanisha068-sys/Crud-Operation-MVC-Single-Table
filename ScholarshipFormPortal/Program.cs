using Microsoft.EntityFrameworkCore;
using ScholarshipFormPortal.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ScholarshipFormDBContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("dbsf")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=ScholarshipForm}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
