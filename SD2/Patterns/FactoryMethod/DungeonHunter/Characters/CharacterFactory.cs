using SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters;
using System;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters
{
    public class CharacterFactory
    {
        public static PlayerCharacter GeneratePlayerCharacter(PlayerCharacterClass playerCharacterClass)
        {
            switch (playerCharacterClass)
            {
                case PlayerCharacterClass.Warrior: return new Warrior();
                case PlayerCharacterClass.Rogue: return new Rogue();
                case PlayerCharacterClass.Mage: return new Mage();
                default: throw new Exception($"No character exists of type {playerCharacterClass}");
            }
        }
    }
}
