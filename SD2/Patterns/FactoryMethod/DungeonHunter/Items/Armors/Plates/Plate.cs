using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Armors.Plates
{
    public abstract class Plate : Armor
    {
        public override ArmorType ArmorType => ArmorType.Plate;
    }
}
