using System;
using SD2.SharedFeatures.Menus;

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
            MenuFactory.SelectCrustMenu().Display();
        }

        private static void PrintPizzaOrder()
        {
            var state = PizzaOrderState.Instance;

            Console.WriteLine($"Crust: {state.CurrentOrder.Crust}");

            Console.ReadLine();
        }
    }
}
