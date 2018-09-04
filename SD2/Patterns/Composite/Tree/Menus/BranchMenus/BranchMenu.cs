using System.Collections.Generic;
using SD2.Patterns.Composite.Tree.Menus.TrunkMenus;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.SharedFeatures.Common;
using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.Composite.Tree.Menus.BranchMenus
{
    public class BranchMenu : Menu<Branch>
    {
        public BranchMenu(Branch state) : base(state)
        {
        }

        protected override List<string> LegalValues => EnumHelper.PoistionValuesToStringList(typeof(BranchMenuOptions));
        protected override bool CanExit => true;

        protected override void PrintMenuHeader()
        {
            Printer.PrintLine("BRANCH MENU");
        }

        protected override void PrintMenuBody()
        {
            Printer.PrintLine($"{(int)BranchMenuOptions.Describe}: Describe");
            Printer.PrintLine($"{(int)BranchMenuOptions.SelectBranch}: Select a Branch");
            Printer.PrintLine($"{(int)BranchMenuOptions.SelectLeaf}: Select a Leaf");
        }

        protected override void MenuOptions(string userInput)
        {
            var option = (BranchMenuOptions)int.Parse(userInput);

            switch (option)
            {
                case BranchMenuOptions.Describe: State.Describe(); break;
                case BranchMenuOptions.SelectBranch:
                    if (State.Branches.Count == 0)
                    {
                        Printer.PrintLine();
                        Printer.PrintLine("No branches exist for this trunk");
                        Printer.PrintLine();
                    }
                    else
                    {
                        CompositeTreeMenuFactory.SelectBranchMenu(State.Branches).Display();
                    }
                    break;
                case BranchMenuOptions.SelectLeaf:
                    if (State.Leaves.Count == 0)
                    {
                        Printer.PrintLine();
                        Printer.PrintLine("No leaves exist for this trunk");
                        Printer.PrintLine();
                    }
                    else
                    {
                        CompositeTreeMenuFactory.SelectLeavesMenu(State.Leaves).Display();
                    }
                    break;
                default:
                    Printer.PrintLine(Constants.Menu.FailedToHandle(option.ToString()));
                    break;
            }
        }
    }

    public enum BranchMenuOptions
    {
        Describe = 1,
        SelectBranch,
        SelectLeaf
    }
}