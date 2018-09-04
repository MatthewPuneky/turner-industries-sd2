using SD2.Patterns.Builder.CharacterBuilders;
using SD2.Patterns.Builder.States;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.SharedFeatures.Common;
using SD2.SharedFeatures.Menus;
using System.Collections.Generic;
using SD2.SharedFeatures.Printers;

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
            Printer.PrintLine("SELECT A CLASS TO BUILD");
        }

        protected override void PrintMenuBody()
        {
            Printer.PrintLine($"{(int)BuildableClassTypes.Warrior}: {BuildableClassTypes.Warrior}");
            Printer.PrintLine($"{(int)BuildableClassTypes.Ranger}: {BuildableClassTypes.Ranger}");
            Printer.PrintLine($"{(int)BuildableClassTypes.Wizzard}: {BuildableClassTypes.Wizzard}");
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
                    Printer.PrintLine(Constants.Menu.FailedToHandle(option.ToString()));
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
