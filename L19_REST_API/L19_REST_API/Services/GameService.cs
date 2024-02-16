using L19_REST_API.Entities;

namespace L19_REST_API.Services;

public class GameService
{
    private static readonly List<Game> _games = new List<Game>()
    {
        new Game() { Id = 1, Title = "Octodad", Price = 1.58M },
        new Game() { Id = 2, Title = "Baldur's Gate 3", Price = 38.01M },
        new Game() { Id = 3, Title = "GTA: Vice City", Price = 3.9M },
        new Game() { Id = 4, Title = "GTA VI", Price = 0M },
    };

    public List<Game> GetAll()
    {
        return _games.ToList();
    }

    public Game? GetById(long id)
    {
        return _games.FirstOrDefault(g => g.Id == id);
    }

    public long Create(Game game)
    {
        game.Id = _games.Max(g => g.Id) + 1;
        _games.Add(game);
        return game.Id;
    }

    public void Update(Game game)
    {
        var oldGame = _games.FirstOrDefault(g => g.Id == game.Id);

        if (oldGame is null) throw new Exception("Game does not exist.");

        oldGame.Title = game.Title;
        oldGame.Price = game.Price;
    }

    public bool Delete(long id)
    {
        var game = _games.FirstOrDefault(g => g.Id == id);

        if (game is null) return false;

        _games.Remove(game);

        return true;
    }
}
