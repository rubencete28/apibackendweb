//1 . using to work with entiryframework
using Microsoft.EntityFrameworkCore;
using apibackend.Dates;

var builder = WebApplication.CreateBuilder(args);

// 2. conection to sql server
const string ConnectionName = "UniversityDb";
var ConnectionString = builder.Configuration.GetConnectionString(ConnectionName);

// 3. add context 
builder.Services.AddDbContext<UniversityDb>(options => options.UseSqlServer(ConnectionString));

// Add services to the container.

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

app.UseAuthorization();

app.MapControllers();

app.Run();
