using Domain.Modules.Scooters;

namespace L47P_MediatR.Web;

public class ScooterRepository : IScooterRepository
{
    public async Task<List<Scooter>> GetAllAsync()
    {
        return
        [
            new Scooter
            {
                CringePhrase = CringePhrase.JustVibin,
                Location = "Академия Наук",
            }
        ];
    }
}
