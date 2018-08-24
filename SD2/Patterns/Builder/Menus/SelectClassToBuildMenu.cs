using SD2.Patterns.Builder.CharacterBuilders;
using SD2.Patterns.Builder.States;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.SharedFeatures.Common;
using SD2.SharedFeatures.Menus;
using System;
using System.Collections.Generic;

namespace SD2.Patterns.Builder.Menus
{
    public class SelectClassToBuildMenu : Menu<BuilderPatternState>
    {
        public SelectClassToBuildMenu() 
            : base(BuilderPatternState.Instance)
        {
        }

        protected override List<string> LegalValues => EnumHelper.PoistionValuesToStringList(typeof(BuildableClassTypes));
        protected override bool CanExit => true;

        private CharacterBuilderDirector director = new CharacterBuilderDirector();
        
        protected override void PrintMenuHeader()
        {
            Console.WriteLine("SELECT A CLASS TO BUILD");
        }

        protected override void PrintMenuBody()
        {
            Console.WriteLine($"{(int)BuildableClassTypes.Warrior}: {BuildableClassTypes.Warrior}");
            Console.WriteLine($"{(int)BuildableClassTypes.Ranger}: {BuildableClassTypes.Ranger}");
            Console.WriteLine($"{(int)BuildableClassTypes.Wizzard}: {BuildableClassTypes.Wizzard}");
        }

        protected override void MenuOptions(string userInput)
        {
            var option = (BuildableClassTypes)int.Parse(userInput);
            CharacterBuilder builder;
            MenuIsActive = false;

            switch (option)
            {
                case BuildableClassTypes.Warrior:
                    builder = new WarriorBuilder();
                    director.Construct(builder);
                    State.Character = builder.GetResult();
                    break;
                case BuildableClassTypes.Ranger:
                     builder = new RangerBuilder();
                    director.Construct(builder);
                    State.Character = builder.GetResult();
                    break;
                case BuildableClassTypes.Wizzard:
                     builder = new WizzardBuilder();
                    director.Construct(builder);
                    State.Character = builder.GetResult();
                    break;
                default:
                    Console.WriteLine(Constants.MenuConstants.FailedToHandle(option.ToString()));
                    MenuIsActive = true;
                    break;
            }
        }
    }

    public enum BuildableClassTypes
    {
        Warrior = 1,
        Ranger,
        Wizzard
    }
}
