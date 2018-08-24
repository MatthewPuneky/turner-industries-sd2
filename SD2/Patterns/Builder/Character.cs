using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Builder
{
    public class Character
    {
        public string Name { get; set; }

        public string Armor { get; set; }
        public string Weapon { get; set; }

        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }

        public void Describe()
        { 
            Console.WriteLine("YOUR BUILT CHARACTER");
            Console.WriteLine($"Armor: {Armor}");
            Console.WriteLine($"Weapon: {Weapon}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Dexterity: {Dexterity}");
            Console.WriteLine();
        }
    }
}
