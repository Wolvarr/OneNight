using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNight.Shared.Cards;
public class Card
{
    public Card(CharacterType cardType)
    {
        this.Name = cardType.ToString();
        this.CardType = cardType;
    }

    public string Name { get; set; }

    public CharacterType CardType { get; }

}
