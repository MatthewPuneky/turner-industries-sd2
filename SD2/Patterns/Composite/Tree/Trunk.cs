using System.Collections.Generic;
using SD2.Patterns.Composite.Tree.Informationals;
using SD2.Patterns.Composite.Tree.Menus;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common;

namespace SD2.Patterns.Composite.Tree
{
    public class Trunk : IDescribable
    {
        public List<Branch> Branches = new List<Branch>();
        
        public string Name { get; set; }

        public Trunk(string name)
        {
            Name = name;
        }

        public void Describe()
        {
            CompositeTreeInformationalFactory.TrunkInformational(this).Display();
        }

        public void DisplayMenu()
        {
            CompositeTreeMenuFactory.TrunkMenu(this).Display();
        }
    }
}
