using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;

namespace SD2
{
    public static class ApplicationStart
    {
        public static void Main(string[] args)
        {
            //PrintHeader();

            MenuFactory.ApplicationMainMenu().Display();
        }

        public static void PrintHeader()
        {
            Printer.WriteLine(@"#####################################################################");
            Printer.WriteLine(@"#   _____        __ _                            _____              #");
            Printer.WriteLine(@"#  / ____|      / _| |                          |  __ \             #");
            Printer.WriteLine(@"# | (___   ___ | |_| |___      ____ _ _ __ ___  | |  | | _____   __ #");
            Printer.WriteLine(@"#  \___ \ / _ \|  _| __\ \ /\ / / _` | '__/ _ \ | |  | |/ _ \ \ / / #");
            Printer.WriteLine(@"#  ____) | (_) | | | |_ \ V  V / (_| | | |  __/ | |__| |  __/\ V /  #");
            Printer.WriteLine(@"# |_____/ \___/|_|_ \__|_\_/\_/ \__,_|_|  \___| |_____/ \___| \_/   #");
            Printer.WriteLine(@"#   _____ _____ ___    _______                                      #");
            Printer.WriteLine(@"#  / ____|  __ \__ \  |__   __|      (_)     (_)                    #");
            Printer.WriteLine(@"# | (___ | |  | | ) |    | |_ __ __ _ _ _ __  _ _ __   __ _         #");
            Printer.WriteLine(@"#  \___ \| |  | |/ /     | | '__/ _` | | '_ \| | '_ \ / _` |        #");
            Printer.WriteLine(@"#  ____) | |__| / /_     | | | | (_| | | | | | | | | | (_| |        #");
            Printer.WriteLine(@"# |_____/|_____/____|    |_|_|  \__,_|_|_| |_|_|_| |_|\__, |        #");
            Printer.WriteLine(@"#                                                      __/ |        #");
            Printer.WriteLine(@"#                                                     |___/         #");
            Printer.WriteLine(@"#                                                                   #");
            Printer.WriteLine(@"#####################################################################");
        }
    }
}
