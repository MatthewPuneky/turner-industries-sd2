using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Armors
{
    public static class ArmorFactory
    {
        public static Armor GenerateArmor(ArmorType armorType)
        {
            switch (armorType)
            {
                case ArmorType.Unarmoed: return new Unarmored();
                default: return new Unarmored();
            }
        }
    }
}
