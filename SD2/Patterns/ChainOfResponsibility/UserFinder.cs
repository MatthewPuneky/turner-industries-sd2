using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.ChainOfResponsibility
{
    public class UserFinder
    {
        public void Find(int userId)
        {
            Printer.PrintLine();

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var response = StorageState.Instance.TopOfChain.HandleRequest(userId);
            stopwatch.Stop();

            Printer.PrintLine(response != null
                ? $"User {response.User.Username} was found."
                : $"User was not found.");

            Printer.PrintLine($"Elapsed time is {stopwatch.Elapsed}");

            Printer.PrintLine();
        }
    }
}
