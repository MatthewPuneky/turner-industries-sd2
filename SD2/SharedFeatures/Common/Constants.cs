using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.SharedFeatures.Common
{
    public class Constants
    {
        public static class MenuConstants
        {
            public const string UnderConstruction = "(under construction)";
            public const string UnderConstructionToUserResponse = "Under construction\n";

            public static string FailedToHandle(string option)
            {
                return $"{option} failed to be handled as an option.\n";
            }
        }
    }
}
