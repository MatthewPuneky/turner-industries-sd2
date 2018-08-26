using System.Collections.Generic;
using SD2.SharedFeatures.Informationals;

namespace SD2.Patterns.Composite.Tree.Informationals
{
    public class BranchInformational : Informational<Branch>
    {
        public BranchInformational(Branch state) : base(state)
        {
        }

        protected override IEnumerable<string> LoadLinesToDisplay()
        {
            yield return "BRANCH";
            yield return $"Name: {State.Name}";
            yield return $"Number of Branches: {State.Branches.Count}";
            yield return $"Number of Leaves: {State.Leaves.Count}";
            yield return "";
        }
    }
}