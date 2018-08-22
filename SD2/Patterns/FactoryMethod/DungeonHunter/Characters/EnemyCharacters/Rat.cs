using System;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters.EnemyCharacters
{
    public class Rat : EnemyCharacter
    {
        public override string Name => "Rat";
        public override int AttributePool => 3;

        public override void PrintDescription()
        {
            Console.WriteLine("A frothing rat, larger than normal.");
        }
    }
}
