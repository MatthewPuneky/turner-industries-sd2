using SD2.SharedFeatures.Printers;
using SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters;
using SD2.Patterns.FactoryMethod.DungeonHunter.States;
using SD2.SharedFeatures.Menus;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Game
{
    public class Setup
    {
        public static PlayerCharacter CreateYourCharacter()
        {
            Printer.WriteLine("CHARACTER CREATION");
            Printer.WriteLine();

            MenuFactory.SelectClassMenu().Display();
            MenuFactory.ManageAttributesMenu().Display();
            MenuFactory.NamePlayerCharacterMenu().Display();

            CharacterCreateState.Instance.ChosenCharacter.Initialize();

            return CharacterCreateState.Instance.ChosenCharacter;
        }
    }
}
