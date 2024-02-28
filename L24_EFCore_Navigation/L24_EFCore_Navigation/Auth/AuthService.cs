using L24_EFCore_Navigation.Auth.Contracts;
using L24_EFCore_Navigation.Auth.Exceptions;
using L24_EFCore_Navigation.Data;
using L24_EFCore_Navigation.Entities;
using Microsoft.EntityFrameworkCore;

using static BCrypt.Net.BCrypt;

namespace L24_EFCore_Navigation.Auth;

public class AuthService
{
    private const int MIN_PW_LENGTH = 4;

    private readonly AppDbContext _context;

    public AuthService(AppDbContext context)
    {
        _context = context;
    }

    public Task<bool> ExistsAsync(string username) =>
        _context.Users.AnyAsync(u => u.Username == username);

    public async Task RegisterAsync(AuthData data)
    {
        if (await ExistsAsync(data.Username))
            throw new UsernameTakenException();

        if (data.Password.Length < MIN_PW_LENGTH)
            throw new PasswordTooShortException(MIN_PW_LENGTH);

        var passwordHash = HashPassword(data.Password, 12);

        var user = new User
        {
            Username = data.Username,
            PasswordHash = passwordHash,
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }

    public async Task<UserData> ValidateAsync(AuthData data)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(u => u.Username == data.Username);

        if (user is null || Verify(data.Password, user.PasswordHash) is false)
            throw new WrongCredentialsException();

        return new UserData { Id = user.Id, Username = user.Username, };
    }
}
