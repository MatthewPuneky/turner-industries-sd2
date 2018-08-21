using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters
{
    public class CharacterFactory
    {
        public PlayerCharacter GeneratePlayerCharacter(PlayerCharacterClass playerCharacterClass)
        {
            switch (playerCharacterClass)
            {
                case PlayerCharacterClass.Warrior: return new Warrior();
                default: throw new Exception($"No character exists of type {playerCharacterClass}");
            }
        }
    }
}
