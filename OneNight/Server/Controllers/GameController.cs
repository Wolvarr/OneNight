using Microsoft.AspNetCore.Mvc;
using OneNight.Shared;
using OneNight.Shared.Dto;

namespace OneNight.Server.Controllers;
[ApiController]
[Route("[controller]")]
public class GameController : ControllerBase
{
    private readonly GameManager gameManager;

    public GameController(GameManager gameManager)
    {
        this.gameManager = gameManager;
    }

    [HttpGet("users")]
    public List<string> GetAllUsers(string gameId)
    {
        return gameManager.GetAllUsers(gameId);
    }

    [HttpPost("init-game")]
    public async Task<string> InitGame(List<CharacterType> characterTypes)
    {
        return await gameManager.InitGameAsync(characterTypes);
    }

    [HttpPost("{gameId}/join")]
    public async Task JoinGameAsync(JoinLobbyDto dto)
    {
        await this.gameManager.JoinGameAsync(dto);
    }

    [HttpPost("start-game")]
    public async Task StartGameAsync(string gameId)
    {
        await gameManager.StartGameAsync(gameId);
    }
}
