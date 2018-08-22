using System;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters.EnemyCharacters
{
    public class Goblin : EnemyCharacter
    {
        public override string Name => "Goblin";
        public override int AttributePool => 5;

        public override void PrintDescription()
        {
            Console.WriteLine("A warted Goblin, small yet nimble.");
        }
    }
}
