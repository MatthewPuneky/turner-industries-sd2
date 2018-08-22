using System;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters
{
    public class Rogue : PlayerCharacter
    {
        public override PlayerCharacterClass ClassType => PlayerCharacterClass.Rogue;

        public override void PrintDescription()
        {
            Console.WriteLine("A mysterious fighter, willing to use any tactics to survive.");
        }
    }
}
