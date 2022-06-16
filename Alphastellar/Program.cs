using Alphastellar.Business.Implementations;
using Alphastellar.DataAccess.Context;
using Alphastellar.DataAccess.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<CarService>();
builder.Services.AddScoped<BusService>();
builder.Services.AddScoped<BoatService>();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("Test"));
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();
var scope = app.Services.CreateScope();
var context= scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
GetMyDb(context);


app.Run();



static void GetMyDb(ApplicationDbContext context)
{


    if (context.Cars.Any() && context.Boats.Any() && context.Buses.Any())
        return;
    else
    {
        context.AddRange(
            new Bus
            {
                BusID = 1,
                color = "Red"
            },
            new Bus
            {
                BusID = 2,
                color = "Blue"
            },
            new Bus
            {
                    BusID = 3,
                color = "Green"
            });
        context.AddRange(
        new Car
        {
            CarID = 4,
            color = "Red",
            headlights = true,
            wheels = true,
        },
        new Car
        {
            CarID = 5,
            color = "Blue",
            headlights = false,
            wheels = true,
        },
        new Car
        {
            CarID = 6,
            color = "Green",
            headlights = true,
            wheels = false,
        });
        context.AddRange(
         new Boat
         {
             BoatID = 7,
             color = "Red"
         },
        new Boat
        {
            BoatID = 8,
            color = "Blue"
        },
        new Boat
        {
            BoatID = 9,
            color = "Green"
        }
     );
        context.SaveChanges();
    }


}