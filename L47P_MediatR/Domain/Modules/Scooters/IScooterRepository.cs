namespace Domain.Modules.Scooters;

public interface IScooterRepository
{
    Task<List<Scooter>> GetAllAsync();
}
