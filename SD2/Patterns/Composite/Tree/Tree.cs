using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.Patterns.Composite.Tree.Informationals;
using SD2.Patterns.Composite.Tree.Menus;

namespace SD2.Patterns.Composite.Tree
{
    public class Tree
    {
        public List<Trunk> Trunks = new List<Trunk>();

        public string TypeOfTree { get; set; }

        public Tree(string typeOfTree)
        {
            TypeOfTree = typeOfTree;
        }

        public IEnumerable<(int index, string name)> GetTrunkInfo()
        {
            return Trunks.Select((trunk, i) => (i, trunk.Name));
        }

        public void Describe()
        {
            CompositeTreeInformationalFactory.TreeInformational(this).Display();
        }

        public void DisplayMenu()
        {
            CompositeTreeMenuFactory.TreeMenu(this).Display();
        }
    }
}
