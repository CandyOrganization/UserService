using CandyOrg.Controllers;

namespace Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddAuthenticationWithoutValidation();
        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");
        app.Run();
    }
}