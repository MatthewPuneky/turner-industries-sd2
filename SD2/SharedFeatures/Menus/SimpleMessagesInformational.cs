using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.SharedFeatures.Informationals;

namespace SD2.SharedFeatures.Menus
{
    class SimpleMessagesInformational : Informational<List<string>>
    {
        public SimpleMessagesInformational(List<string> state) : base(state)
        {
        }

        protected override IEnumerable<string> LoadLinesToDisplay()
        {
            foreach (var line in State)
            {
                yield return line;
            }
        }
    }
}
