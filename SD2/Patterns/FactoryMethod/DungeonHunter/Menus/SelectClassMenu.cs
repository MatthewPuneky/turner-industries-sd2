using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using SD2.Patterns.FactoryMethod.DungeonHunter.Characters;
using SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.Patterns.FactoryMethod.DungeonHunter.States;
using SD2.SharedFeatures.Common;
using SD2.SharedFeatures.Menus;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Menus
{
    public class SelectClassMenu : Menu<CharacterCreateState>
    {
        public SelectClassMenu() 
            : base(CharacterCreateState.Instance)
        {
        }

        protected override List<string> LegalValues { get; } = EnumHelper.PoistionValuesToStringList(typeof(PlayerCharacterClass));

        protected override void PrintMenuHeader()
        {
            Printer.PrintLine("SELECT YOUR CLASS");
        }

        protected override void PrintMenuBody()
        {
            Printer.PrintLine($"{(int)PlayerCharacterClass.Warrior}: {PlayerCharacterClass.Warrior}");
            Printer.PrintLine($"{(int)PlayerCharacterClass.Rogue}: {PlayerCharacterClass.Rogue}");
            Printer.PrintLine($"{(int)PlayerCharacterClass.Mage}: {PlayerCharacterClass.Mage}");
        }

        protected override void MenuOptions(string userInput)
        {
            var option = (PlayerCharacterClass)int.Parse(userInput);
            MenuIsActive = false;

            switch (option)
            {
                case PlayerCharacterClass.Warrior:
                    State.ChosenCharacter = CharacterFactory.GeneratePlayerCharacter(PlayerCharacterClass.Warrior);
                    break;
                case PlayerCharacterClass.Rogue:
                    State.ChosenCharacter = CharacterFactory.GeneratePlayerCharacter(PlayerCharacterClass.Rogue);
                    break;
                case PlayerCharacterClass.Mage: 
                    State.ChosenCharacter = CharacterFactory.GeneratePlayerCharacter(PlayerCharacterClass.Mage);
                    break;
                default:
                    Printer.PrintLine(Constants.Menu.FailedToHandle(option.ToString()));
                    MenuIsActive = true;
                    break;
            }
        }
    }
}
