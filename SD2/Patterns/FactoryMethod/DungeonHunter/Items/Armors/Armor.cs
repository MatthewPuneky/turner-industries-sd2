using SD2.Patterns.FactoryMethod.DungeonHunter.Characters;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Armors
{
    public abstract class Armor : IDescribable
    {
        private Character _wearer;
        public Character Wearer
        {
            get
            {
                return _wearer;
            }
            set
            {
                if (value != null) value.EquipArmor(this);
                _wearer = value;
            }
        }

        public abstract ArmorType ArmorType { get; }
        public abstract ArmorWeight ArmorWeight { get; }
        public abstract string ArmorName { get; }
        public abstract int ArmorRaiting { get; }
        
        public int MitigateDamage(int incomingDamage)
        {
            return incomingDamage - ArmorRaiting;
        }

        public abstract void Describe();
    }

    public enum ArmorType
    {
        Unarmoed = 1,
        Cloth,
        Plate
    }

    public enum ArmorWeight
    {
        None = 1,
        Light,
        Medium, 
        Heavy
    }
}
