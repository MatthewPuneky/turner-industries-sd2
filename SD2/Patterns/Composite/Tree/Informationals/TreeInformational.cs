using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.SharedFeatures.Informationals;

namespace SD2.Patterns.Composite.Tree.Informationals
{
    public class TreeInformational : Informational<Tree>
    {
        public TreeInformational(Tree tree) : base(tree)
        {
        }

        protected override IEnumerable<string> LoadLinesToDisplay()
        {
            yield return "TREE";
            yield return $"Type: {State.TypeOfTree}";
            yield return $"Number of Trunks: {State.Trunks.Count}";
            yield return "";
        }
    }
}
