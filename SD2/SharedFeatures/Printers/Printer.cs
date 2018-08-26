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
            foreach(var @char in line)
            {
                if(@char != ' ')
                {
                    Wait();
                }
                Console.Write(@char);
            }
            Wait();
            Console.WriteLine();
        }

        public static void WriteLine()
        {
            Console.WriteLine();
        }

        public static void Write(string partialLine)
        {
            foreach (var @char in partialLine)
            {
                Wait();
                Console.Write(@char);
            }
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
            Thread.Sleep(2);
        }
    }
}
