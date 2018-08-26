using System.Collections.Generic;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.SharedFeatures.Common;
using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.Composite.Tree.Menus.TrunkMenus
{
    public class TrunkMenu : Menu<Trunk>
    {
        public TrunkMenu(Trunk state) : base(state)
        {
        }

        protected override List<string> LegalValues => EnumHelper.PoistionValuesToStringList(typeof(TrunkMenuOptions));
        protected override bool CanExit => true;

        protected override void PrintMenuHeader()
        {
            Printer.WriteLine("TRUNK MENU");
        }

        protected override void PrintMenuBody()
        {
            Printer.WriteLine($"{(int)TrunkMenuOptions.Describe}: Describe");
            Printer.WriteLine($"{(int)TrunkMenuOptions.SelectBranch}: Select a Branch");
        }

        protected override void MenuOptions(string userInput)
        {
            var option = (TrunkMenuOptions) int.Parse(userInput);

            switch (option)
            {
                case TrunkMenuOptions.Describe: State.Describe(); break;
                case TrunkMenuOptions.SelectBranch:
                    if (State.Branches.Count == 0)
                    {
                        Printer.WriteLine();
                        Printer.WriteLine("No branches exist for this trunk");
                        Printer.WriteLine();
                    }
                    else
                    {
                        CompositeTreeMenuFactory.SelectBranchMenu(State.Branches).Display();
                    }
                    break;
                default:
                    Printer.WriteLine(Constants.Menu.FailedToHandle(option.ToString()));
                    break;
            }
        }
    }

    public enum TrunkMenuOptions
    {
        Describe = 1,
        SelectBranch
    }
}
