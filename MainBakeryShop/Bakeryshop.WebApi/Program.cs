using Bakeryshop.Domain.IRepositories;
using Bakeryshop.Infrastructure.EntityFramework;
using Bakeryshop.Infrastructure.Mapper;
using Bakeryshop.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BakeryshopContext>();


builder.Services.AddAutoMapper(typeof(OrderProfile));
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

builder.Services.AddAutoMapper(typeof(SchaduleProfile));
builder.Services.AddScoped<ISchaduleRepository, SchaduleRepository>();

builder.Services.AddAutoMapper(typeof(TypeBreadProfile));
builder.Services.AddScoped<ITypeBreadRepository, TypeBreadRepository>();

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
