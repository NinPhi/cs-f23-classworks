using L17_DependencyInjection.Entities;

namespace L17_DependencyInjection.Services;

public interface IUserService
{
    public Task<List<User>> GetUsersAsync();
}
