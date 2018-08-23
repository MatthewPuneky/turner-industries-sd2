using System.Collections.Generic;

namespace SD2.Patterns.Singleton.State
{
    public sealed class PizzaOrderState
    {
        private PizzaOrderState() { }
        private static PizzaOrderState _instance;

        public static PizzaOrderState Instance
        {
            get
            {
                if (_instance == null) _instance = new PizzaOrderState();
                return _instance;
            }
        } 

        public Pizza CurrentOrder { get; set; } = new Pizza();
    }
}
