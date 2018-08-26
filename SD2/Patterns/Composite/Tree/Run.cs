using SD2.Patterns.Composite.Tree.Menus;

namespace SD2.Patterns.Composite.Tree
{
    public static class Run
    {
        public static void Operation()
        {
            var tree = new Tree("Oak");
            tree.Trunks.Add(new Trunk("A Hardy Trunk 0"));
            tree.Trunks.Add(new Trunk("A Hardy Trunk 1"));
            tree.Trunks.Add(new Trunk("A Hardy Trunk 2"));
            tree.Trunks.Add(new Trunk("A Hardy Trunk 3"));
            tree.Trunks.Add(new Trunk("A Hardy Trunk 4"));
            tree.Trunks.Add(new Trunk("A Hardy Trunk 5"));
            tree.Trunks.Add(new Trunk("A Hardy Trunk 6"));
            tree.Trunks.Add(new Trunk("A Hardy Trunk 7"));
            tree.Trunks.Add(new Trunk("A Hardy Trunk 8"));
            tree.Trunks.Add(new Trunk("A Hardy Trunk 9"));
            tree.Trunks.Add(new Trunk("A Hardy Trunk 10"));
            tree.Trunks[0].Branches.Add(new Branch("A Hardy Branch(A) 0"));
            tree.Trunks[0].Branches.Add(new Branch("A Hardy Branch(A) 1"));
            tree.Trunks[0].Branches.Add(new Branch("A Hardy Branch(A) 2"));
            tree.Trunks[0].Branches.Add(new Branch("A Hardy Branch(A) 3"));
            tree.Trunks[0].Branches.Add(new Branch("A Hardy Branch(A) 4"));
            tree.Trunks[0].Branches.Add(new Branch("A Hardy Branch(A) 5"));
            tree.Trunks[0].Branches.Add(new Branch("A Hardy Branch(A) 6"));
            tree.Trunks[0].Branches.Add(new Branch("A Hardy Branch(A) 7"));
            tree.Trunks[0].Branches.Add(new Branch("A Hardy Branch(A) 8"));
            tree.Trunks[0].Branches.Add(new Branch("A Hardy Branch(A) 9"));
            tree.Trunks[0].Branches[0].Branches.Add(new Branch("A Hardy Branch(B) 0"));
            tree.Trunks[0].Branches[0].Branches.Add(new Branch("A Hardy Branch(B) 1"));
            tree.Trunks[0].Branches[0].Branches.Add(new Branch("A Hardy Branch(B) 2"));
            tree.Trunks[0].Branches[0].Branches.Add(new Branch("A Hardy Branch(B) 3"));
            tree.Trunks[0].Branches[0].Branches.Add(new Branch("A Hardy Branch(B) 4"));
            tree.Trunks[0].Branches[0].Branches.Add(new Branch("A Hardy Branch(B) 5"));
            tree.Trunks[0].Branches[0].Branches.Add(new Branch("A Hardy Branch(B) 6"));
            tree.Trunks[0].Branches[0].Branches.Add(new Branch("A Hardy Branch(B) 7"));
            tree.Trunks[0].Branches[0].Branches.Add(new Branch("A Hardy Branch(B) 8"));
            tree.Trunks[0].Branches[0].Branches.Add(new Branch("A Hardy Branch(B) 9"));
            tree.Trunks[0].Branches[0].Leaves.Add(new Leaf("A Hardy Leaf 0"));
            tree.Trunks[0].Branches[0].Leaves.Add(new Leaf("A Hardy Leaf 1"));
            tree.Trunks[0].Branches[0].Leaves.Add(new Leaf("A Hardy Leaf 2"));
            tree.Trunks[0].Branches[0].Leaves.Add(new Leaf("A Hardy Leaf 3"));
            tree.Trunks[0].Branches[0].Leaves.Add(new Leaf("A Hardy Leaf 4"));
            tree.Trunks[0].Branches[0].Leaves.Add(new Leaf("A Hardy Leaf 5"));
            tree.Trunks[0].Branches[0].Leaves.Add(new Leaf("A Hardy Leaf 6"));
            tree.Trunks[0].Branches[0].Leaves.Add(new Leaf("A Hardy Leaf 7"));
            tree.Trunks[0].Branches[0].Leaves.Add(new Leaf("A Hardy Leaf 8"));
            tree.Trunks[0].Branches[0].Leaves.Add(new Leaf("A Hardy Leaf 9"));

            CompositeTreeMenuFactory.TreeMenu(tree).Display();
        }
    }
}
