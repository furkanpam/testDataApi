using ConnectionProvider.Api.Properties;
using ConnectionProvider.Core.Helpers;
using ConnectionProvider.Core.IoC;
using ConnectionProvider.Container.Bootstrappers;
using ConnectionProvider.Abstraction.Data.Context;
using ConnectionProvider.Abstraction.Data.EfCore.Repository;
using ConnectionProvider.Abstraction.Data.EfCore.UnitOfwork;
using ConnectionProvider.Abstraction.Data.MongoDb;
using ConnectionProvider.Abstraction.Domain;
using ConnectionProvider.Core.Domain.Entity;
using ConnectionProvider.Core.Base;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();
AppSettingsHelper.AppSettingsHelperConfigure(builder.Configuration);
ResourceHelper.ConfigureResourceHelper<Resources>("ConnectionProvider.Api.Properties.Resources");
builder.Services.AddDbContext();
builder.Services.RegisterIdentity();
builder.Services.RegisterCPIntegration();
builder.Services.RegisterImplementations<IUnitOfWork<DbContextBase>>("ConnectionProvider.Infrastructre");
builder.Services.RegisterImplementations<IRepository<IBaseEntity>>("ConnectionProvider.Infrastructre");
builder.Services.RegisterImplementations<IBaseManager>("ConnectionProvider.Application");
builder.Services.RegisterMapper();

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

app.UseAuthentication();
app.AddHelpers();
app.IntegrationHelperConfig();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
//app.UseHealthChecks("/health");
//app.UseMetricServer();
app.Run();
