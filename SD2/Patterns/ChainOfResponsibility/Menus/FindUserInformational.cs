using System.Collections.Generic;
using System.Diagnostics;
using SD2.SharedFeatures.Informationals;
using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.ChainOfResponsibility.Menus
{
    public class FindUserInformational : Informational<int>
    {
        public FindUserInformational(int state) : base(state)
        {
        }

        protected override IEnumerable<string> LoadLinesToDisplay()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var response = StorageState.Instance.TopOfChain.HandleRequest(State);
            stopwatch.Stop();

            if (response != null) yield return $"User {response.User.Username} was found.";
            else yield return $"User was not found.";

            Printer.PrintLine($"Elapsed time is {stopwatch.Elapsed}");

            Printer.PrintLine();
        }
    }
}
