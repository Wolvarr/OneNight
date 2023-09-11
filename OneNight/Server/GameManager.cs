using OneNight.Server.Models;
using OneNight.Shared;
using OneNight.Shared.Dto;

namespace OneNight.Server;

public class GameManager
{
    private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string nums = "0123456789";
    private readonly GameHub hub;

    private static List<Game> CurrentGames { get; set; } = new();

    public GameManager(GameHub hub)
    {
        this.hub = hub;
    }

    public async Task<string> InitGameAsync(List<CharacterType> cards)
    {
        var gameId = GenerateGameId();
        CurrentGames.Add(new Game(gameId, cards));
        return gameId;
    }

    public async Task JoinGameAsync(JoinLobbyDto dto)
    {
        var game = CurrentGames.First(x => x.SessionId == dto.GameId);
        game.PlayerJoin(new Player(dto.UserName));

        await hub.PlayerJoined(dto.GameId, dto.UserName);
    }

    public async Task StartGameAsync(string gameId)
    {
        var game = CurrentGames.First(x => x.SessionId == gameId);
        game.StartGame();

        await hub.GameHasStarted(gameId);
    }
    public List<string> GetAllUsers(string gameId)
    {
        var game = CurrentGames.First(x => x.SessionId == gameId);
        return game.Players.Select(x => x.Name).ToList();
    }

    private static string GenerateGameId()
    {
        Random rng = new();
        return $"{chars[rng.Next(chars.Length)]}" +
            $"{chars[rng.Next(chars.Length)]}" +
            $"{chars[rng.Next(chars.Length)]}" +
            $"{nums[rng.Next(nums.Length)]}" +
            $"{nums[rng.Next(nums.Length)]}" +
            $"{nums[rng.Next(nums.Length)]}";
    }

}
