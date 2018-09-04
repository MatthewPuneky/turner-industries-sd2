using SD2.Patterns.FactoryMethod.DungeonHunter.Characters;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.Patterns.FactoryMethod.DungeonHunter.States;
using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using SD2.SharedFeatures.Common;
using static SD2.SharedFeatures.Common.Constants;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Menus
{
    public class ManageAttributesMenu : Menu<CharacterCreateState>
    {
        public ManageAttributesMenu() 
            : base(CharacterCreateState.Instance)
        {
        }

        protected override List<string> LegalValues => EnumHelper.PoistionValuesToStringList(typeof(AttributeType));
        protected override bool CanExit => true;

        protected override void PrintMenuHeader()
        {
            Printer.PrintLine("ASSIGN YOUR ATTRIBUTES");
        }

        protected override void PrintMenuBody()
        {
            Printer.PrintLine("Current Stats");
            Printer.Print($"Str: {State.ChosenCharacter.Strength.Value} - ");
            Printer.Print($"Int: {State.ChosenCharacter.Dexterity.Value} - ");
            Printer.Print($"Dex: {State.ChosenCharacter.Intelligence.Value}");
            Printer.PrintLine();
            Printer.PrintLine($"Remaining Points : {State.ChosenCharacter.RemainingStatsToDistribute}");
            Printer.PrintLine($"SELECT ATTRIBUTE TO IMPROVE");
            Printer.PrintLine($"{(int)AttributeType.Strength}: {AttributeType.Strength}");
            Printer.PrintLine($"{(int)AttributeType.Dexterity}: {AttributeType.Dexterity}");
            Printer.PrintLine($"{(int)AttributeType.Intelligence}: {AttributeType.Intelligence}");
        }

        protected override void MenuOptions(string userInput)
        {
            var option = (AttributeType)int.Parse(userInput);

            switch(option)
            {
                case AttributeType.Strength: MenuFactory.ManageStrengthMenu().Display(); break;
                case AttributeType.Dexterity: MenuFactory.ManageStrengthMenu().Display(); break;
                case AttributeType.Intelligence: MenuFactory.ManageStrengthMenu().Display(); break;
                default:
                    Printer.PrintLine(Constants.Menu.FailedToHandle(option.ToString()));
                    break;
            }
        }
    }
}
