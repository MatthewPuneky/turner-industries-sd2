using System.Collections.Generic;
using System.Linq;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.Composite.Tree.Menus.TrunkMenus
{
    public class SelectTrunkMenu : Menu<List<Trunk>>
    {
        protected override bool CanExit => true;

        protected override List<string> LegalValues
        {
            get
            {
                return IEnumerableHelpers
                    .Series(1)
                    .Take(State.Count)
                    .Select(x => x.ToString())
                    .ToList();
            }
        }
        
        public SelectTrunkMenu(List<Trunk> state) : base(state)
        {
        }

        protected override void PrintMenuHeader()
        {
            Printer.PrintLine("TRUNK SELECTOR");
        }

        protected override void PrintMenuBody()
        {
            var numberOfTrunks = State.Count + 1;
            var maxPadding = numberOfTrunks.ToString().Length;

            for (var i = 0; i < State.Count; i++)
            {
                var indexTo1Base = i + 1;
                var paddingAmount = maxPadding - indexTo1Base.ToString().Length;
                var padding = new string(' ', paddingAmount);
                Printer.PrintLine($"{padding}{indexTo1Base}: {State[i].Name}");
            }
        }

        protected override void MenuOptions(string userInput)
        {
            MenuIsActive = false;
            var trunkIndex = int.Parse(userInput) - 1;
            var trunk = State[trunkIndex];
            trunk.DisplayMenu();
        }
    }
}
