using System.Collections.Generic;

namespace SD2.Patterns.Singleton.State
{
    public sealed class PizzaOrderState
    {
        private PizzaOrderState() { }
        private static PizzaOrderState _instance;
        public static PizzaOrderState Instance => _instance ?? (_instance = new PizzaOrderState());

        public Pizza CurrentOrder { get; set; } = new Pizza();
    }
}
