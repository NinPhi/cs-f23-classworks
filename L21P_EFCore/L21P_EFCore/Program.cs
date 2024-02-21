using L21P_EFCore;
using L21P_EFCore.Entities;

Console.WriteLine("App started!");

using var context = new AppDbContext();

var user = new User() { Username = "test" };

context.Users.Add(user);
await context.SaveChangesAsync();

Console.WriteLine($"User named {user.Username} was created under ID {user.Id}");

Console.WriteLine("App finished!");
