using Models;

namespace Application.Interfaces.Repositories;

public interface IUserRepository
{
    // Task AddAsync(User user);
    // Task<User?> GetByEmailAsync(string email);
    // Task<User?> GetByIdAsync(Guid userId);
    // Task<List<User>> GetByCompanyIdAsync(Guid companyId);
    // Task<List<User>> GetDriversByCompanyIdAsync(Guid companyId);
    // Task<User?> GetDriverByIdAndCompanyIdAsync(Guid driverId, Guid companyId);
    // Task<User?> GetDriverByEmployeeIdAsync(Guid employeeId);
    public Task<DbUser> AddAsync(DbUser user);
    public Task<DbUser?> GetByEmailAsync(string email);
    public Task<DbUser?> GetByIdAsync(Guid userId);
}