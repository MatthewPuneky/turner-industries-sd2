using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons
{
    public static class WeaponFactory
    {
        public static Weapon GenerateWeapon(WeaponType weaponType)
        {
            switch (weaponType)
            {
                case WeaponType.Unarmed: return new Unarmed("Fists", 1);
                default: return new Unarmed("Fists", 1);
            }
        }
    }
}
