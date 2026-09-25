using CandyOrg.DapperContext.Common.Interfaces.Dapper.Settings;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Settings;

public class DapperSettings : IDapperSettings
{
    public DapperSettings(IConfiguration configuration)
    {
        ConnectionString = configuration.GetConnectionString("Database") ?? throw new ArgumentException("Не обнаружен ConnectionString к БД");
    }

    public string ConnectionString { get; set; }
}