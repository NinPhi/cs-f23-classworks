using L19_REST_API.Entities;
using L19_REST_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace L19_REST_API.Controllers;

[ApiController]
[Route("api/games")]
public class GameController : ControllerBase
{
    private readonly GameService _gameService;

    public GameController(GameService gameService)
    {
        _gameService = gameService;
    }

    [HttpGet]
    public ActionResult GetAll()
    {
        var games = _gameService.GetAll();
        return Ok(games);
    }

    [HttpGet("{id}")]
    public ActionResult GetById(long id)
    {
        var game = _gameService.GetById(id);
        return Ok(game);
    }

    [HttpPost]
    public ActionResult Create(Game game)
    {
        long gameId = _gameService.Create(game);

        return Created($"api/games/{gameId}", game);
    }

    [HttpPut]
    public ActionResult Update(Game game)
    {
        _gameService.Update(game);

        return NoContent();
    }

    [HttpPatch("{id}")]
    public ActionResult UpdateTitle(long id, string newTitle)
    {
        var game = _gameService.GetById(id);

        if (game is null) return NotFound();

        game.Title = newTitle;

        _gameService.Update(game);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(long id)
    {
        bool result = _gameService.Delete(id);

        if (result)
            return NoContent();

        return NotFound();
    }
}
