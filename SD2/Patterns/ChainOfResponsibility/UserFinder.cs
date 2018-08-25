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
            Printer.WriteLine();

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var response = StorageState.Instance.TopOfChain.HandleRequest(userId);
            stopwatch.Stop();

            Printer.WriteLine(response != null
                ? $"User {response.User.Username} was found."
                : $"User was not found.");

            Printer.WriteLine($"Elapsed time is {stopwatch.Elapsed}");

            Printer.WriteLine();
        }
    }
}
