using SD2.Patterns.Builder.States;
using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Builder
{
    public static class Run
    {
        public static void Operation()
        {
            MenuFactory.SelectClassToBuildMenu().Display();
            BuilderPatternState.Instance.Character.Describe();
        }
    }
}
