using EmployeeDashboard.Models;
using EmployeeDashboard.Services;

var builder = WebApplication.CreateBuilder(args);

// 🔧 Läs in MongoDbSettings från user-secrets eller appsettings
builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection("MongoDbSettings"));

// 💡 Lägg till din MongoDB-tjänst
builder.Services.AddSingleton<MongoDailyLogService>();

// 🚀 Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

// Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();
app.MapRazorPages();

app.Run();
