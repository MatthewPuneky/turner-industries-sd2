namespace SD2.Patterns.Composite.Tree.Informationals
{
    public class CompositeTreeInformationalFactory
    {
        public static TrunkInformational TrunkInformational(Trunk trunk) => new TrunkInformational(trunk);
        public static TreeInformational TreeInformational(Tree tree) => new TreeInformational(tree);
        public static BranchInformational BranchInformational(Branch branch) => new BranchInformational(branch);
        public static LeafInformational LeafInformational(Leaf leaf) => new LeafInformational(leaf);
    }
}
