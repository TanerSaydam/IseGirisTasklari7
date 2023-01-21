using IseGirisTasklari7.Application.Services;
using IseGirisTasklari7.Domain;
using IseGirisTasklari7.Domain.Repositories.CompanyRepositories;
using IseGirisTasklari7.Domain.Repositories.OrderRepositories;
using IseGirisTasklari7.Domain.Repositories.ProductRepositories;
using IseGirisTasklari7.Persistance;
using IseGirisTasklari7.Persistance.Context;
using IseGirisTasklari7.Persistance.Repositories.CompanyRepositories;
using IseGirisTasklari7.Persistance.Repositories.OrderRepositories;
using IseGirisTasklari7.Persistance.Repositories.ProductRepositories;
using IseGirisTasklari7.Persistance.Services;
using IseGirisTasklari7.Presentation;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

#region DbContext
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
#endregion



#region Dependency Injection
builder.Services.AddScoped<IProductCommandRepository, ProductCommandRepository>();
builder.Services.AddScoped<IProductQueryRepository, ProductQueryRepository>();
builder.Services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
builder.Services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
builder.Services.AddScoped<IOrderCommandRepository, OrderCommandRepository>();
builder.Services.AddScoped<IOrderQueryRepository, OrderQueryRepository>();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
#endregion

builder.Services.AddMediatR(typeof(IseGirisTasklari7.Application.AssemblyReference).Assembly);

builder.Services.AddControllers()
    .AddApplicationPart(typeof(IseGirisTasklari7.Presentation.AssemblyReference).Assembly);
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
