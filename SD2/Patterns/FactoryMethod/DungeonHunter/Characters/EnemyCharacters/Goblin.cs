using System;
using SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters.EnemyCharacters
{
    public class Goblin : EnemyCharacter
    {
        public override UnarmedAttackStyle UnarmedAttackStyle => UnarmedAttackStyle.Fist;
        public override EnemyCharacterType EnemyCharacterType => EnemyCharacterType.Goblin;
        public override string CharacterName { get; set; } = "Pesky Goblin";
        public override int TotalAttributePoints { get; set; } = 5;

        public override void PrintDescription()
        {
            Console.WriteLine("A warted Goblin, small yet nimble.");
        }
    }
}
