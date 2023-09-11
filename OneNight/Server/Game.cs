using OneNight.Server.Models;
using OneNight.Shared;
using OneNight.Shared.Cards;

namespace OneNight.Server;

public class Game
{
    public string SessionId { get; set; }

    public List<Player> Players { get; set; } = new();

    public List<Card> OtherCards { get; set; } = new();

    public List<Card> AllCards
    {
        get
        {
            return this.OtherCards.Union(this.Players.Select(x => x.Card!)).ToList();
        }
    }

    public Game(string sessionId, List<CharacterType> cards)
    {
        this.SessionId = sessionId;
        this.OtherCards = cards.Select(x => new Card( x)).ToList();

        Random rng = new Random();
        this.Players.ForEach(player =>
        {
            player.Card = this.OtherCards[rng.Next(this.OtherCards.Count)];
            this.OtherCards.Remove(player.Card);
        });
    }

    public void PlayerJoin(Player player)
    {
        this.Players.Add(player);
    }

    public void StartGame()
    {

    }

    public void NightPhase()
    {
        if (this.AllCards.Any(x => x.CardType == Shared.CharacterType.Doppelganger))
        {

        }

        if (this.AllCards.Any(x => x.CardType == Shared.CharacterType.Werewolf))
        {

        }

        if (this.AllCards.Any(x => x.CardType == Shared.CharacterType.Minion))
        {

        }

        if (this.AllCards.Any(x => x.CardType == Shared.CharacterType.Mason))
        {

        }

        if (this.AllCards.Any(x => x.CardType == Shared.CharacterType.Seer))
        {

        }

        if (this.AllCards.Any(x => x.CardType == Shared.CharacterType.Robber))
        {

        }

        if (this.AllCards.Any(x => x.CardType == Shared.CharacterType.Troublemaker))
        {

        }

        if (this.AllCards.Any(x => x.CardType == Shared.CharacterType.Drunk))
        {

        }

        if (this.AllCards.Any(x => x.CardType == Shared.CharacterType.Insomniac))
        {

        }
    }

    public void DayPhase()
    {
    }
}
