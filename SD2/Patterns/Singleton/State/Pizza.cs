using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Singleton.State
{
    public class Pizza
    {
        public string Crust { get; set; }
        public string Cheese { get; set; }

        public List<Toppings> Toppings { get; set; } = new List<Toppings>();
    }
}
