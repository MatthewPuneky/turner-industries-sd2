using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters
{
    public class Mage : PlayerCharacter
    {
        public override PlayerCharacterClass ClassType => PlayerCharacterClass.Mage;

        public override void Describe()
        {
            Printer.PrintLine("An old frail body with incredible magical energy.");
        }
    }
}
