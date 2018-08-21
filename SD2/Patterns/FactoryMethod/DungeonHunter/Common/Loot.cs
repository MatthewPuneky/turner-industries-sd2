using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.Patterns.FactoryMethod.DungeonHunter.Items.Armors;
using SD2.Patterns.FactoryMethod.DungeonHunter.Items.Potions;
using SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Common
{
    public class Loot
    {
        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }
        public List<Potion> Potions { get; set; }
    }
}
