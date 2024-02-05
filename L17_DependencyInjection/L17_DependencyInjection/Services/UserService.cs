using L17_DependencyInjection.Entities;

namespace L17_DependencyInjection.Services;

public class UserService : IUserService
{
    private readonly List<User> _users = new()
    {
        new User() { Id = 1, Username = "Dima228", PasswordHash = "vmkfldvhjlkdfvnkdl" },
        new User() { Id = 2, Username = "Mark337", PasswordHash = "vkflkdvjlkfdjkvfdc" },
    };

    public async Task<List<User>> GetUsersAsync()
    {
        await Task.Delay(2000);

        return _users;
    }
}
