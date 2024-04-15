using DataAccessLayer.Data;
using DomainLayer.Contracts;
using DomainLayer.Entities;

namespace BusinessLogicLayer.Services;

public class ShavarmaService(AppDbContext dbContext) : IShavarmaService
{
    public async Task CreateAsync(CreateShavarmaRequest request)
    {
        var shavarma = new Shavarma
        {
            Meat = request.Meat!,
            Veggies = request.Veggies!,
            IsSpicy = request.IsSpicy,
            HasCheese = request.HasCheese,
        };

        dbContext.Add(shavarma);

        await dbContext.SaveChangesAsync();
    }
}
