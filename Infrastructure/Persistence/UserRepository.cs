using Application.Interfaces;
using Application.Interfaces.Repositories;
using CandyOrg.DapperContext.Common.Interfaces.Dapper;
using CandyOrg.DapperContext.Dapper;
using Infrastructure.Persistence.Sql;
using Models;

namespace Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private IDapperContext _dapperContext;
    
    public UserRepository(IDapperContext dapperContext)
    {
        _dapperContext = dapperContext;
    }

    public async Task<DbUser> AddAsync(DbUser dbUser)
    {
        var queryObject = new QueryObject(
            PostgresUserSql.AddUser,
            new
            {
                dbUser.HashedPassword,
                dbUser.Email,
                role = dbUser.Role,
            });

        var res = await _dapperContext.CommandWithResponse<DbUser>(queryObject);
        return res;
    }


    public async Task<DbUser?> GetByEmailAsync(string email)
    {
        var queryObject = new QueryObject(
            PostgresUserSql.GetUserByEmail,
            new { email });

        return await _dapperContext.FirstOrDefault<DbUser>(queryObject);
    }

    public async Task<DbUser?> GetByIdAsync(Guid userId)
    {
        var queryObject = new QueryObject(
            PostgresUserSql.GetUserById,
            new
            {
                id = userId
            });

        return await _dapperContext.FirstOrDefault<DbUser>(queryObject);
    }
}