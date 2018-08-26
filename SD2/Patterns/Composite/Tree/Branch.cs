using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.Patterns.Composite.Tree.Informationals;
using SD2.Patterns.Composite.Tree.Menus;

namespace SD2.Patterns.Composite.Tree
{
    public class Branch
    {
        public List<Leaf> Leaves = new List<Leaf>();
        public List<Branch> Branches = new List<Branch>();

        public string Name { get; set; }

        public Branch(string name)
        {
            Name = name;
        }

        public IEnumerable<(int index, string name)> GetBranchInfo()
        {
            return Branches.Select((branch, i) => (i, branch.Name));
        }

        public IEnumerable<(int index, string name)> GetLeafInfo()
        {
            return Leaves.Select((leaf, i) => (i, leaf.Name));
        }

        public void Describe()
        {
            CompositeTreeInformationalFactory.BranchInformational(this).Display();
        }

        public void DisplayMenu()
        {
            CompositeTreeMenuFactory.BranchMenu(this).Display();
        }
    }
}
