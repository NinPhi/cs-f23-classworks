using BusinessLogicLayer.Contracts;
using DataAccessLayer.Entities;
using DataAccessLayer.Data;

namespace BusinessLogicLayer.Services;

public class FruitService(AppDbContext dbContext)
{
    public async Task CreateAsync(CreateFruitRequest request)
    {
        var fruit = new Fruit() { Type = request.Type! };

        dbContext.Fruits.Add(fruit);
        await dbContext.SaveChangesAsync();
    }
}
