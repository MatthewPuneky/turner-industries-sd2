using System;
using SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters
{
    public abstract class PlayerCharacter : Character
    {
        public override string CharacterName { get; set; } = "(name not created yet)";
        public override UnarmedAttackStyle UnarmedAttackStyle => UnarmedAttackStyle.Fist;
        public override CharacterController CharacterController => CharacterController.Player;
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
