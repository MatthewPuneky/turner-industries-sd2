using System.Collections.Generic;
using SD2.SharedFeatures.Informationals;

namespace SD2.SharedFeatures.Menus
{
    public class SimpleMessageInformational : Informational<string>
    {
        public SimpleMessageInformational(string state) : base(state)
        {
        }

        protected override IEnumerable<string> LoadLinesToDisplay()
        {
            yield return State;
        }
    }
}
