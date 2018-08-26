using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters
{
    public class Rogue : PlayerCharacter
    {
        public override PlayerCharacterClass ClassType => PlayerCharacterClass.Rogue;

        public override void Describe()
        {
            Printer.WriteLine("A mysterious fighter, willing to use any tactics to survive.");
        }
    }
}
