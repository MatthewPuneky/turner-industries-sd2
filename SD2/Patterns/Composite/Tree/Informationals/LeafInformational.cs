using System.Collections.Generic;
using SD2.SharedFeatures.Informationals;

namespace SD2.Patterns.Composite.Tree.Informationals
{
    public class LeafInformational : Informational<Leaf>
    {
        public LeafInformational(Leaf state) : base(state)
        {
        }

        protected override IEnumerable<string> LoadLinesToDisplay()
        {
            yield return "LEAF";
            yield return $"Name: {State.Name}";
            yield return "";
        }
    }
}
