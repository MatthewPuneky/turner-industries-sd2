using System;
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
            Console.WriteLine();

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var response = StorageState.Instance.TopOfChain.HandleRequest(userId);
            stopwatch.Stop();

            Console.WriteLine(response != null
                ? $"User {response.User.Username} was found."
                : $"User was not found.");

            Console.WriteLine($"Elapsed time is {stopwatch.Elapsed}");

            Console.WriteLine();
        }
    }
}
