using DomainLayer.Contracts;

namespace BusinessLogicLayer.Services;

public interface IShavarmaService
{
    Task CreateAsync(CreateShavarmaRequest request);
}