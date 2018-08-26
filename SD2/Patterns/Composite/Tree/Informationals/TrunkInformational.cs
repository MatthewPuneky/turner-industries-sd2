using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.SharedFeatures.Informationals;

namespace SD2.Patterns.Composite.Tree.Informationals
{
    public class TrunkInformational : Informational<Trunk>
    {
        public TrunkInformational(Trunk state) : base(state)
        {
        }

        protected override IEnumerable<string> LoadLinesToDisplay()
        {
            yield return "TRUNK";
            yield return $"Name: {State.Name}";
            yield return $"Number of Branches: {State.Branches.Count}";
            yield return "";
        }
    }
}
