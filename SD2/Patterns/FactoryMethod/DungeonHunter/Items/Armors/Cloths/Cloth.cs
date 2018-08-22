using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Armors.Cloths
{
    public abstract class Cloth : Armor
    {
        public override ArmorType ArmorType => ArmorType.Cloth;
    }
}
