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
            Printer.PrintLine("TREE MENU");
        }

        protected override void PrintMenuBody()
        {
            Printer.PrintLine($"{(int)TreeOptions.Describe}: Describe");
            Printer.PrintLine($"{(int)TreeOptions.SelectTrunk}: Select Trunk");
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
                        Printer.PrintLine();
                        Printer.PrintLine("No trunks exist for this trunk");
                        Printer.PrintLine();
                    }
                    else
                    {
                        CompositeTreeMenuFactory.SelectTrunkMenu(State.Trunks).Display();
                    }   
                    break;
                default:
                    Printer.PrintLine(Constants.Menu.FailedToHandle(option.ToString()));
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
