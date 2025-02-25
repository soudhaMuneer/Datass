using JobPortalApplication.Extensions;
using JobPortalApplication.Interfaces;
using JobPortalApplication.Repositories;
using JobPortalApplication.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSession();
builder.Services.AddRazorPages();
/*builder.Services.AddRazorPages(options =>
{
	options.Conventions.AddPageRoute("/", "/public/Login");
});*/
builder.Services.AddApplicationServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}
app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
