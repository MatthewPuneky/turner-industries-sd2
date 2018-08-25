using SD2.SharedFeatures.Helpers;
using System;

namespace SD2.SharedFeatures.Printers
{
    // This will become an interface in the future for DI
    // Easy solution for now
    public static class Printer
    {
        public static void WriteLine(string line)
        {
            Console.WriteLine(line);
        }

        public static void Write(string partialLine)
        {
            Console.Write(partialLine);
        }

        public static string ReadLine()
        {
            return Console.ReadLine();
        }

        public static void ClearPreviousLine()
        {
            ConsoleHelpers.ClearPreviousLine();
        }

        public static void ClearCurrentConsoleLine()
        {
            ConsoleHelpers.ClearCurrentConsoleLine();
        }
    }
}
