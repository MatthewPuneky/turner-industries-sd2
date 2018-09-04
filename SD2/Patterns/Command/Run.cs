using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.SharedFeatures.Menus;

namespace SD2.Patterns.Command
{
    public static class Run
    {
        public static void Operation()
        {
            MenuFactory.TakeoffCommandMainMenu().Display();
        }
    }
}
