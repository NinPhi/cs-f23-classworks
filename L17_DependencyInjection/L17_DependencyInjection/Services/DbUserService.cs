using L17_DependencyInjection.Entities;

namespace L17_DependencyInjection.Services;

public class DbUserService : IUserService
{
    public Task<List<User>> GetUsersAsync()
    {
        throw new NotImplementedException();
    }
}
