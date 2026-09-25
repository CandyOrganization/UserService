using System.Reflection;
using Application;
using CandyOrg.Controllers;
using CandyOrg.DapperContext;
using Infrastructure;
using Infrastructure.Settings;

namespace Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddAuthenticationWithoutValidation();
        builder.Services.AddControllers();
        builder.Services.AddSwaggerGen();
        var dapperSettings = new DapperSettings(builder.Configuration);
        builder.Services.AddDapper(dapperSettings);
        builder.Services.AddMigrations(dapperSettings, Assembly.GetAssembly(typeof(Infrastructure.DependencyInjection)));
        builder.Services.AddRepositories();
        builder.Services.AddServices();

        var app = builder.Build();
        app.Services.UseMigrations();
        app.MapSwagger();
        app.MapControllers();
        app.UseSwaggerUI();
        app.Run();
    }
}