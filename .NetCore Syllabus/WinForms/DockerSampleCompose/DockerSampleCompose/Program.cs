using DockerSampleCompose.Data;
using DockerSampleCompose.Model;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProductContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.MapGet("/products", async (ProductContext db) =>
    await db.products.ToListAsync()) ;
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ProductContext>();
    context.Database.Migrate();
    if(!context.products.Any())
    {
        context.products.AddRange(
            new Product { name = "soap", price = 10 },
            new Product { name = "newsoap", price = 20 },
             new Product { name = "barsoap", price = 20 }
            );
        context.SaveChanges();
    }
}


app.MapControllers();

app.Run();
