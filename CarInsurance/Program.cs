
using CarInsurance.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Enable MVC controllers and views.
builder.Services.AddControllersWithViews();

// Connect the application to SQLite.
builder.Services.AddDbContext<CarInsuranceContext>(options =>
    options.UseSqlite("Data Source=CarInsurance.db"));

var app = builder.Build();

// Configure error handling.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

// Configure the default route.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
