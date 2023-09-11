using Microsoft.AspNetCore.SignalR;

namespace OneNight.Server;

public class GameHub : Hub
{
    public async Task GameHasStarted(string gameId)
    {
        await this.Clients.All.SendAsync("GameStarted", gameId);
    }

    public async Task PlayerJoined(string gameId, string playerName)
    {
        await this.Clients.Others.SendAsync("PlayerJoined", gameId, playerName);
    }
}
