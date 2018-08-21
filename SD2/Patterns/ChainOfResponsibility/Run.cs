using System;
using System.Diagnostics;
using SD2.Patterns.ChainOfResponsibility.CacheNodes;

namespace SD2.Patterns.ChainOfResponsibility
{
    public class Run
    {
        public static void Operation()
        {
            while (true)
            {
                Console.Write("Please enter an Id to find (0 to exit): ");
                var userInput = Console.ReadLine();
                Console.WriteLine();

                var wasParseable = int.TryParse(userInput, out var idToFind);
                if (!wasParseable) continue;

                if (idToFind == 0) break;

                var cacheL1 = new IndexCache();
                var cacheL2 = new LinkedListCache();
                var longTermUserStorage = new LongTermUserStorage();

                cacheL1.SetSuccessor(cacheL2);
                cacheL2.SetSuccessor(longTermUserStorage);

                var stopwatch = new Stopwatch();
                stopwatch.Start();
                var response = cacheL1.HandleRequest(idToFind);
                stopwatch.Stop();

                Console.WriteLine(response != null
                    ? $"User {response.User.Username} was found."
                    : $"User was not found.");

                Console.WriteLine($"Elapsed time is {stopwatch.Elapsed}");

                Console.WriteLine();
            }
        }
    }
}
