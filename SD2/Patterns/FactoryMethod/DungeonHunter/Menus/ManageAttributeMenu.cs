using SD2.Patterns.FactoryMethod.DungeonHunter.States;
using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using System.Linq;
using static SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers.IEnumerableHelpers;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Menus
{
    public abstract class ManageAttributeMenu : Menu<CharacterCreateState>
    {
        public ManageAttributeMenu()
            : base(CharacterCreateState.Instance)
        {
        }

        protected override List<string> LegalValues
        {
            get => Series()
                .Take(State.ChosenCharacter.RemainingStatsToDistribute + 1)
                .Select(x => x.ToString())
                .ToList();
        }

        protected override void PrintMenuBody()
        {
            Printer.PrintLine("Current Stats");
            Printer.Print($"Str: {State.ChosenCharacter.Strength.Value} - ");
            Printer.Print($"Int: {State.ChosenCharacter.Dexterity.Value} - ");
            Printer.Print($"Dex: {State.ChosenCharacter.Intelligence.Value}");
            Printer.PrintLine($"Remaining Points : {State.ChosenCharacter.RemainingStatsToDistribute}");
        }

        protected override void PrintUserInputPrompt()
        {
            var remainingPoints = State.ChosenCharacter.RemainingStatsToDistribute;
            Printer.Print($"Select a value (0-{remainingPoints}): ");
        }
    }

    public class ManageStrengthMenu : ManageAttributeMenu
    {
        protected override void PrintMenuHeader()
        {
            Printer.PrintLine("ENTER STRENGTH");
        }

        protected override void MenuOptions(string userInput)
        {
            var amount = int.Parse(userInput);
            State.ChosenCharacter.Strength.Value += amount;
            MenuIsActive = false;
        }
    }

    public class ManageDexterityMenu : ManageAttributeMenu
    {
        protected override void PrintMenuHeader()
        {
            Printer.PrintLine("ENTER DEXTERITY");
        }

        protected override void MenuOptions(string userInput)
        {
            var amount = int.Parse(userInput);
            State.ChosenCharacter.Dexterity.Value += amount;
            MenuIsActive = false;
        }
    }

    public class ManageIntelligenceMenu : ManageAttributeMenu
    {
        protected override void PrintMenuHeader()
        {
            Printer.PrintLine("ENTER INTELLIGENCE");
        }

        protected override void MenuOptions(string userInput)
        {
            var amount = int.Parse(userInput);
            State.ChosenCharacter.Intelligence.Value += amount;
            MenuIsActive = false;
        }
    }
}
