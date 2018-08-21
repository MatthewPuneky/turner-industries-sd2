using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Armors
{
    public abstract class Armor : IDescribable
    {
        public int ArmorRaiting { get; }
        public string ArmorName { get; }

        protected Armor(string armorName, int armorRaiting)
        {
            ArmorName = armorName;
            ArmorRaiting = armorRaiting;
        }
        
        public int MitigateDamage(int incomingDamage)
        {
            return incomingDamage - ArmorRaiting;
        }

        public abstract void PrintDescription();
    }

    public enum ArmorType
    {
        Unarmoed = 1
    }
}
