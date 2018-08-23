using System.Collections.Generic;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Menus;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using System;
using SD2.Patterns.Singleton.State;
using SD2.SharedFeatures.Common;
using SD2.SharedFeatures.Menus;

namespace SD2.Patterns.Singleton.Menus
{
    public class SelectCrustMenu : Menu
    {
        protected override List<string> LegalValues => EnumHelper.PoistionValuesToStringList(typeof(CrustTypes));
        protected override bool CanExit => false;
        
        protected override void PrintMenuHeader()
        {
            Console.WriteLine("SELECT CRUST");
        }

        protected override void PrintMenuBody()
        {
            Console.WriteLine($"{(int)CrustTypes.PanTossed}: Pan Tossed");
            Console.WriteLine($"{(int)CrustTypes.Thin}: Thin");
            Console.WriteLine($"{(int)CrustTypes.StuffedCrust}: Stuffed Crust");
        }
    }

    public class SelectCrustMenuHandler : MenuHandler<PizzaOrderState>
    {
        public SelectCrustMenuHandler() 
            : base(MenuFactory.SelectCrustMenu(), PizzaOrderState.Instance)
        {
        }

        protected override void MenuOptions(string userInput)
        {
            var option = (CrustTypes)int.Parse(userInput);

            MenuIsActive = false;

            switch(option)
            {
                case CrustTypes.PanTossed: State.CurrentOrder.Crust = "Pan Tossed"; break;
                case CrustTypes.Thin: State.CurrentOrder.Crust = "Thin"; break;
                case CrustTypes.StuffedCrust: State.CurrentOrder.Crust = "Stuffed Crust"; break;
                default:
                    Console.WriteLine(Constants.MenuConstants.FailedToHandle(option.ToString()));
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
