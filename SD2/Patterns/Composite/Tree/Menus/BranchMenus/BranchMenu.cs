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
            Printer.WriteLine("BRANCH MENU");
        }

        protected override void PrintMenuBody()
        {
            Printer.WriteLine($"{(int)BranchMenuOptions.Describe}: Describe");
            Printer.WriteLine($"{(int)BranchMenuOptions.SelectBranch}: Select a Branch");
            Printer.WriteLine($"{(int)BranchMenuOptions.SelectLeaf}: Select a Leaf");
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
                        Printer.WriteLine();
                        Printer.WriteLine("No branches exist for this trunk");
                        Printer.WriteLine();
                    }
                    else
                    {
                        CompositeTreeMenuFactory.SelectBranchMenu(State.Branches).Display();
                    }
                    break;
                case BranchMenuOptions.SelectLeaf:
                    if (State.Leaves.Count == 0)
                    {
                        Printer.WriteLine();
                        Printer.WriteLine("No leaves exist for this trunk");
                        Printer.WriteLine();
                    }
                    else
                    {
                        CompositeTreeMenuFactory.SelectLeavesMenu(State.Leaves).Display();
                    }
                    break;
                default:
                    Printer.WriteLine(Constants.Menu.FailedToHandle(option.ToString()));
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