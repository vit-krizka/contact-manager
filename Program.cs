using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using contact_manager.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ContactContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ContactContext") ?? throw new InvalidOperationException("Connection string 'ContactContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

