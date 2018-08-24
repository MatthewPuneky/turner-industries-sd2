using SD2.Patterns.FactoryMethod.DungeonHunter.States;
using SD2.SharedFeatures.Menus;
using System;
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
            Console.WriteLine("Current Stats");
            Console.Write($"Str: {State.ChosenCharacter.Strength.Value} - ");
            Console.Write($"Int: {State.ChosenCharacter.Dexterity.Value} - ");
            Console.Write($"Dex: {State.ChosenCharacter.Intelligence.Value}");
            Console.WriteLine($"Remaining Points : {State.ChosenCharacter.RemainingStatsToDistribute}");
        }

        protected override void PrintUserInputPrompt()
        {
            var remainingPoints = State.ChosenCharacter.RemainingStatsToDistribute;
            Console.Write($"Select a value (0-{remainingPoints}): ");
        }
    }

    public class ManageStrengthMenu : ManageAttributeMenu
    {
        protected override void PrintMenuHeader()
        {
            Console.WriteLine("ENTER STRENGTH");
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
            Console.WriteLine("ENTER DEXTERITY");
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
            Console.WriteLine("ENTER INTELLIGENCE");
        }

        protected override void MenuOptions(string userInput)
        {
            var amount = int.Parse(userInput);
            State.ChosenCharacter.Intelligence.Value += amount;
            MenuIsActive = false;
        }
    }
}
