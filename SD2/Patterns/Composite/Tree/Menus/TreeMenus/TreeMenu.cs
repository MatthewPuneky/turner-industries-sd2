using System.Collections.Generic;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.SharedFeatures.Common;
using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.Composite.Tree.Menus.TreeMenus
{
    public class TreeMenu : Menu<Tree>
    {
        public TreeMenu(Tree tree) : base(tree)
        {
        }

        protected override List<string> LegalValues => EnumHelper.PoistionValuesToStringList(typeof(TreeOptions));
        protected override bool CanExit => true;

        protected override void PrintMenuHeader()
        {
            Printer.WriteLine("TREE MENU");
        }

        protected override void PrintMenuBody()
        {
            Printer.WriteLine($"{(int)TreeOptions.Describe}: Describe");
            Printer.WriteLine($"{(int)TreeOptions.SelectTrunk}: Select Trunk");
        }

        protected override void MenuOptions(string userInput)
        {
            var option = (TreeOptions)int.Parse(userInput);

            switch (option)
            {
                case TreeOptions.Describe: State.Describe(); break;
                case TreeOptions.SelectTrunk:
                    if (State.Trunks.Count == 0)
                    {
                        Printer.WriteLine();
                        Printer.WriteLine("No trunks exist for this trunk");
                        Printer.WriteLine();
                    }
                    else
                    {
                        CompositeTreeMenuFactory.SelectTrunkMenu(State.Trunks).Display();
                    }   
                    break;
                default:
                    Printer.WriteLine(Constants.Menu.FailedToHandle(option.ToString()));
                    break;
            }
        }
    }

    public enum TreeOptions
    {
        Describe = 1,
        SelectTrunk
    }
}
