using System.Collections.Generic;
using SD2.Patterns.Composite.Tree.Menus.BranchMenus;
using SD2.Patterns.Composite.Tree.Menus.Leaves;
using SD2.Patterns.Composite.Tree.Menus.TreeMenus;
using SD2.Patterns.Composite.Tree.Menus.TrunkMenus;

namespace SD2.Patterns.Composite.Tree.Menus
{
    public class CompositeTreeMenuFactory
    {
        public static TreeMenu TreeMenu(Tree tree) => new TreeMenu(tree);

        public static TrunkMenu TrunkMenu(Trunk trunk) => new TrunkMenu(trunk);
        public static SelectTrunkMenu SelectTrunkMenu(List<Trunk> trunks) => new SelectTrunkMenu(trunks);

        public static BranchMenu BranchMenu(Branch branch) => new BranchMenu(branch);
        public static SelectBranchMenu SelectBranchMenu(List<Branch> branches) => new SelectBranchMenu(branches);

        public static LeafMenu LeafMenu(Leaf leaf) => new LeafMenu(leaf);
        public static SelectLeafMenu SelectLeavesMenu(List<Leaf> leaves) => new SelectLeafMenu(leaves);
    }
}
