using System.Collections.Generic;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.SharedFeatures.Printers;
using SD2.Patterns.Singleton.State;
using SD2.SharedFeatures.Common;
using SD2.SharedFeatures.Menus;

namespace SD2.Patterns.Singleton.Menus
{
    public class SelectCrustMenu : Menu<PizzaOrderState>
    {
        public SelectCrustMenu() 
            : base(PizzaOrderState.Instance)
        {
        }

        protected override List<string> LegalValues => EnumHelper.PoistionValuesToStringList(typeof(CrustTypes));
        
        protected override void PrintMenuHeader()
        {
            Printer.PrintLine("SELECT CRUST");
        }

        protected override void PrintMenuBody()
        {
            Printer.PrintLine($"{(int)CrustTypes.PanTossed}: Pan Tossed");
            Printer.PrintLine($"{(int)CrustTypes.Thin}: Thin");
            Printer.PrintLine($"{(int)CrustTypes.StuffedCrust}: Stuffed Crust");
        }

        protected override void MenuOptions(string userInput)
        {
            var option = (CrustTypes)int.Parse(userInput);

            MenuIsActive = false;

            switch (option)
            {
                case CrustTypes.PanTossed: State.CurrentOrder.Crust = "Pan Tossed"; break;
                case CrustTypes.Thin: State.CurrentOrder.Crust = "Thin"; break;
                case CrustTypes.StuffedCrust: State.CurrentOrder.Crust = "Stuffed Crust"; break;
                default:
                    Printer.PrintLine(Constants.Menu.FailedToHandle(option.ToString()));
                    MenuIsActive = true;
                    break;
            }
        }
    }

    public enum CrustTypes
    {
        PanTossed = 1,
        Thin,
        StuffedCrust
    }
}
