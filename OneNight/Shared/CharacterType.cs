using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNight.Shared;

public enum CharacterType
{
    Doppelganger = 1,
    Werewolf = 2,
    Minion = 3,
    Mason = 4,
    Seer = 5,
    Robber = 6,
    Troublemaker = 7,
    Drunk = 8,
    Insomniac = 9,
    Villager = 10,
    Tanner = 11,
    Hunter = 12
}

public static class EnumExtension
{
    public static string ToDisplayString(this CharacterType kind) => kind switch
    {
        CharacterType.Doppelganger => "Alakváltó",
        CharacterType.Werewolf => "Vérfarkas",
        CharacterType.Minion => "Csatlós",
        CharacterType.Mason => "Szabadkőműves",
        CharacterType.Seer => "Látnok",
        CharacterType.Robber => "Rabló",
        CharacterType.Troublemaker => "Bajkeverő",
        CharacterType.Drunk => "Részeges",
        CharacterType.Insomniac => "Éjjeli bagoly",
        CharacterType.Villager => "Falusi",
        CharacterType.Tanner => "Tímár",
        CharacterType.Hunter => "Vadász"
    };
}
