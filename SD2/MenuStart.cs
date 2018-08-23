using System;

namespace SD2
{
    public class MenuStart
    {
        private const int GeneralId = 1;
        private const int BackendId = 2;
        private const int PatternsId = 3;
        private const int SolidPrincipalsId = 4;
        private const int TSqlId = 5;
        private const int DevOpsId = 6;

        public static void Main(string[] args)
        {
            WiteIntro();

            while (true)
            {
                Console.WriteLine("MAIN MENU");
                Console.WriteLine($"{GeneralId}: General");
                Console.WriteLine($"{BackendId}: Backend");
                Console.WriteLine($"{PatternsId}: Patterns");
                Console.WriteLine($"{SolidPrincipalsId}: Solid Principals");
                Console.WriteLine($"{TSqlId}: T-SQL");
                Console.WriteLine($"{DevOpsId}: DevOps");

                Console.Write("Select an option (0 to exit): ");
                var userInput = Console.ReadLine();
                Console.WriteLine();

                var wasParseable = int.TryParse(userInput, out var option);
                if(!wasParseable) continue;

                if (option == 0) break;

                switch (option)
                {
                    case GeneralId: Console.WriteLine("Under construction\n"); break;
                    case BackendId: Console.WriteLine("Under construction\n"); break;
                    case PatternsId: Patterns.BaseMenu.Print(); break;
                    case SolidPrincipalsId: Console.WriteLine("Under construction\n"); break;
                    case TSqlId: Console.WriteLine("Under construction\n"); break;
                    case DevOpsId: Console.WriteLine("Under construction\n"); break;
                    default: Console.WriteLine("INVALID OPTION\n"); break;
                }
            }
        }

        private static void WiteIntro()
        {
            Console.WriteLine(@"#####################################################################");
            Console.WriteLine(@"#   _____        __ _                            _____              #");
            Console.WriteLine(@"#  / ____|      / _| |                          |  __ \             #");
            Console.WriteLine(@"# | (___   ___ | |_| |___      ____ _ _ __ ___  | |  | | _____   __ #");
            Console.WriteLine(@"#  \___ \ / _ \|  _| __\ \ /\ / / _` | '__/ _ \ | |  | |/ _ \ \ / / #");
            Console.WriteLine(@"#  ____) | (_) | | | |_ \ V  V / (_| | | |  __/ | |__| |  __/\ V /  #");
            Console.WriteLine(@"# |_____/ \___/|_|_ \__|_\_/\_/ \__,_|_|  \___| |_____/ \___| \_/   #");
            Console.WriteLine(@"#   _____ _____ ___    _______                                      #");
            Console.WriteLine(@"#  / ____|  __ \__ \  |__   __|      (_)     (_)                    #");
            Console.WriteLine(@"# | (___ | |  | | ) |    | |_ __ __ _ _ _ __  _ _ __   __ _         #");
            Console.WriteLine(@"#  \___ \| |  | |/ /     | | '__/ _` | | '_ \| | '_ \ / _` |        #");
            Console.WriteLine(@"#  ____) | |__| / /_     | | | | (_| | | | | | | | | | (_| |        #");
            Console.WriteLine(@"# |_____/|_____/____|    |_|_|  \__,_|_|_| |_|_|_| |_|\__, |        #");
            Console.WriteLine(@"#                                                      __/ |        #");
            Console.WriteLine(@"#                                                     |___/         #");
            Console.WriteLine(@"#                                                                   #");
            Console.WriteLine(@"#####################################################################");
            Console.WriteLine("");
        }
    }
}
