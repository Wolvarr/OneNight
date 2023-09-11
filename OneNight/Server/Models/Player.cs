using OneNight.Shared.Cards;

namespace OneNight.Server.Models;

public class Player
{
    public Player( string name)
    {
        this.Id = Guid.NewGuid();
        this.Name = name;
    }

    public Guid Id { get; }

    public string Name { get; set; }

    public Card? Card { get; set; }
}
