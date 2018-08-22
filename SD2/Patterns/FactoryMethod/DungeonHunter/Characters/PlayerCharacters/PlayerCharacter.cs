using System;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters
{
    public abstract class PlayerCharacter : Character
    {
        public abstract PlayerCharacterClass ClassType { get; }
    }

    public enum PlayerCharacterClass
    {
        Undecided = 0,
        Warrior = 1,
        Rogue = 2,
        Mage = 3
    }
}
