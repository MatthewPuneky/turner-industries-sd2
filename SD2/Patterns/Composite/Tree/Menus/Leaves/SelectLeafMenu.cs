using System.Collections.Generic;
using System.Linq;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.Composite.Tree.Menus.Leaves
{
    public class SelectLeafMenu : Menu<List<Leaf>>
    {
        public SelectLeafMenu(List<Leaf> state) : base(state)
        {
        }

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

        protected override void PrintMenuHeader()
        {
            Printer.PrintLine("LEAF SELECTOR");
        }

        protected override void PrintMenuBody()
        {
            var numberOfLeaves = State.Count + 1;
            var maxPadding = numberOfLeaves.ToString().Length;

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
            var leafIndex = int.Parse(userInput) - 1;
            var leaf = State[leafIndex];
            leaf.DisplayMenu();
        }
    }
}
