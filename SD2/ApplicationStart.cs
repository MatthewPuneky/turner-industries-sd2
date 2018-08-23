using System;
using SD2.SharedFeatures.Menus;

namespace SD2
{
    public static class ApplicationStart
    {
        public static void Main(string[] args)
        {
            PrintHeader();

            MenuFactory.ApplicationMainMenu().Display();
        }

        public static void PrintHeader()
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
        }
    }
}
