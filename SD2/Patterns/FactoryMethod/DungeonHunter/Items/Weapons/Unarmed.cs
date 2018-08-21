using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons
{
    public class Unarmed : Weapon
    {
        public Unarmed(string weaponName, int attackPower) : base(weaponName, attackPower)
        {
        }

        public override void PrintWeaponAttack()
        {
            Console.WriteLine("Fists fly violently through the air.");
        }

        public override void PrintDescription()
        {
            Console.WriteLine("Only knuckles for bare fist brawling.");
        }
    }
}
