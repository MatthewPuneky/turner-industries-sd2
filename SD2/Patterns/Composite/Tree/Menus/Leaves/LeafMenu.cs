using System.Collections.Generic;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.SharedFeatures.Common;
using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.Composite.Tree.Menus.Leaves
{
    public class LeafMenu : Menu<Leaf>
    {
        public LeafMenu(Leaf state) : base(state)
        {
        }

        protected override List<string> LegalValues => EnumHelper.PoistionValuesToStringList(typeof(LeafMenuOptions));
        protected override bool CanExit => true;

        protected override void PrintMenuHeader()
        {
            Printer.WriteLine("Leaf MENU");
        }

        protected override void PrintMenuBody()
        {
            Printer.WriteLine($"{(int)LeafMenuOptions.Describe}: Describe");
        }

        protected override void MenuOptions(string userInput)
        {
            var option = (BranchMenus.BranchMenuOptions)int.Parse(userInput);

            switch (option)
            {
                case BranchMenus.BranchMenuOptions.Describe: State.Describe(); break;
                default:
                    Printer.WriteLine(Constants.Menu.FailedToHandle(option.ToString()));
                    break;
            }
        }
    }

    public enum LeafMenuOptions
    {
        Describe = 1
    }
}