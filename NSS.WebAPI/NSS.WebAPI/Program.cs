using Microsoft.EntityFrameworkCore;
using NSS.WebAPI.Data;
using NSS.WebAPI.Respository;
using NSS.WebAPI.Respository.Abstraction;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<NSSDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("NSSDb"));
});

builder.Services.AddScoped<ICustomerRepository, CustomerRespository>();

builder.Services.AddAutoMapper(typeof(Program).Assembly);

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
