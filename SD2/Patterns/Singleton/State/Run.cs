using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Singleton.State
{
    public class Run
    {
        public static void Operation()
        {
            SelectCrustType();

            PrintPizzaOrder();
        }

        private static void SelectCrustType()
        {
            var menu = MenuFactory.SelectCrustMenu();
            menu.HandleMenu();
        }

        private static void PrintPizzaOrder()
        {
            var state = PizzaOrderState.Instance;

            Console.WriteLine($"Crust: {state.CurrentOrder.Crust}");

            Console.ReadLine();
        }
    }
}
