using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.Patterns.Composite.Tree.Informationals;
using SD2.Patterns.Composite.Tree.Menus;

namespace SD2.Patterns.Composite.Tree
{
    public class Leaf
    {
        public string Name { get; set; }

        public Leaf(string name)
        {
            Name = name;
        }

        public void Describe()
        {
            CompositeTreeInformationalFactory.LeafInformational(this).Display();
        }

        public void DisplayMenu()
        {
            CompositeTreeMenuFactory.LeafMenu(this).Display();
        }
    }
}
