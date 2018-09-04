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
            Printer.PrintLine(@"#####################################################################");
            Printer.PrintLine(@"#   _____        __ _                            _____              #");
            Printer.PrintLine(@"#  / ____|      / _| |                          |  __ \             #");
            Printer.PrintLine(@"# | (___   ___ | |_| |___      ____ _ _ __ ___  | |  | | _____   __ #");
            Printer.PrintLine(@"#  \___ \ / _ \|  _| __\ \ /\ / / _` | '__/ _ \ | |  | |/ _ \ \ / / #");
            Printer.PrintLine(@"#  ____) | (_) | | | |_ \ V  V / (_| | | |  __/ | |__| |  __/\ V /  #");
            Printer.PrintLine(@"# |_____/ \___/|_|_ \__|_\_/\_/ \__,_|_|  \___| |_____/ \___| \_/   #");
            Printer.PrintLine(@"#   _____ _____ ___    _______                                      #");
            Printer.PrintLine(@"#  / ____|  __ \__ \  |__   __|      (_)     (_)                    #");
            Printer.PrintLine(@"# | (___ | |  | | ) |    | |_ __ __ _ _ _ __  _ _ __   __ _         #");
            Printer.PrintLine(@"#  \___ \| |  | |/ /     | | '__/ _` | | '_ \| | '_ \ / _` |        #");
            Printer.PrintLine(@"#  ____) | |__| / /_     | | | | (_| | | | | | | | | | (_| |        #");
            Printer.PrintLine(@"# |_____/|_____/____|    |_|_|  \__,_|_|_| |_|_|_| |_|\__, |        #");
            Printer.PrintLine(@"#                                                      __/ |        #");
            Printer.PrintLine(@"#                                                     |___/         #");
            Printer.PrintLine(@"#                                                                   #");
            Printer.PrintLine(@"#####################################################################");
        }
    }
}
