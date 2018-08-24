using SD2.Patterns.FactoryMethod.DungeonHunter.States;
using SD2.SharedFeatures.Menus;
using System;
using System.Collections.Generic;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Menus
{
    public class NamePlayerCharacterMenu : Menu<CharacterCreateState>
    {
        public NamePlayerCharacterMenu()
            : base(CharacterCreateState.Instance)
        {
        }

        protected override List<string> IllegalVales => new List<string> { "" };

        protected override void PrintMenuHeader()
        {
            Console.WriteLine("SET YOUR CHARACTER NAME");
        }

        protected override void PrintUserInputPrompt()
        {
            Console.Write($"Character Name: ");
        }

        protected override void PrintMenuBody()
        {
        }

        protected override void MenuOptions(string userInput)
        {
            State.ChosenCharacter.CharacterName = userInput;
            MenuIsActive = false;
        }
    }
}
