using System;
using System.Threading;

namespace SD2.SharedFeatures.Printers
{
    // This will become an interface in the future for DI
    // Easy solution for now
    public static class Printer
    {
        public static void WriteLine(string line)
        {
            Wait();
            Console.WriteLine(line);
        }

        public static void WriteLine()
        {
            Wait();
            Console.WriteLine();
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
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            ClearCurrentConsoleLine();
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        private static void Wait()
        {
            Thread.Sleep(90);
        }
    }
}
