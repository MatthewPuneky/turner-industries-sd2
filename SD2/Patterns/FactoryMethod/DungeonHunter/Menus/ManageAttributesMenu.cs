using SD2.Patterns.FactoryMethod.DungeonHunter.Characters;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.Patterns.FactoryMethod.DungeonHunter.States;
using SD2.SharedFeatures.Menus;
using System;
using System.Collections.Generic;
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
            Console.WriteLine("ASSIGN YOUR ATTRIBUTES");
        }

        protected override void PrintMenuBody()
        {
            Console.WriteLine("Current Stats");
            Console.Write($"Str: {State.ChosenCharacter.Strength.Value} - ");
            Console.Write($"Int: {State.ChosenCharacter.Dexterity.Value} - ");
            Console.Write($"Dex: {State.ChosenCharacter.Intelligence.Value}");
            Console.WriteLine();
            Console.WriteLine($"Remaining Points : {State.ChosenCharacter.RemainingStatsToDistribute}");
            Console.WriteLine($"SELECT ATTRIBUTE TO IMPROVE");
            Console.WriteLine($"{(int)AttributeType.Strength}: {AttributeType.Strength}");
            Console.WriteLine($"{(int)AttributeType.Dexterity}: {AttributeType.Dexterity}");
            Console.WriteLine($"{(int)AttributeType.Intelligence}: {AttributeType.Intelligence}");
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
                    Console.WriteLine(MenuConstants.FailedToHandle(option.ToString()));
                    break;
            }
        }
    }
}
