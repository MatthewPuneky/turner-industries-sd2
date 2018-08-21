using System;
using System.Collections.Generic;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common;
using SD2.Patterns.FactoryMethod.DungeonHunter.Items.Armors;
using SD2.Patterns.FactoryMethod.DungeonHunter.Items.Potions;
using SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters
{
    public abstract class Character : IDescribable
    {
        public bool IsAlive { get; private set; } = true;

        public string CharacterName { get; set; }
        public int Health { get; protected set; }

        protected Weapon Weapon = WeaponFactory.GenerateWeapon(WeaponType.Unarmed);
        protected Armor Armor = ArmorFactory.GenerateArmor(ArmorType.Unarmoed);
        protected List<Potion> Potions = new List<Potion>();

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Inteligence { get; set; }

        public void EquipWeapon(Weapon weapon)
        {
            Weapon = weapon;
        }

        public void EquipArmor(Armor armor)
        {
            Armor = armor;
        }

        public void AddPotion(Potion potion)
        {
            Potions.Add(potion);
        }

        public int AttackWithWeapon()
        {
            var weaponDamage = Weapon.Use();
            var totalDamage = weaponDamage + Strength;

            return totalDamage;
        }

        public void GetAttacked(int incomingDamange)
        {
            var randomizer = new Random();
            var didDodge = randomizer.Next(1, 10 - Dexterity) == 1;

            if (didDodge)
            {
                PrintDodge();
                return;
            }

            var appliedDamange = Armor.MitigateDamage(incomingDamange);

            Health -= Armor.MitigateDamage(incomingDamange);
            Console.WriteLine($"{CharacterName} took {appliedDamange} damange!");

            DeathCheck();
        }

        private void DeathCheck()
        {
            if (Health <= 0)
            {
                IsAlive = false;
            }

            Console.WriteLine($"{CharacterName} has died.");
        }

        private void PrintDodge()
        {
            Console.WriteLine($"{CharacterName} dodged the attack!");
        }
        
        public abstract void PrintDescription();
    }
}
