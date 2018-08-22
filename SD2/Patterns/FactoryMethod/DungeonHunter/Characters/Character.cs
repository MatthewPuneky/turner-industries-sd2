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
        public static int miniumumStartingHealth = 10;

        public bool IsAlive { get; private set; } = true;
        public string CharacterName { get; set; }
        public int HealthPool { get; set; } = miniumumStartingHealth;
        public int RemainingHealth { get; protected set; } = miniumumStartingHealth;

        private Weapon _weapon = WeaponFactory.GenerateWeapon(WeaponType.Unarmed);
        protected Weapon Weapon
        { 
            get
            {
                return _weapon;
            }
            set
            {
                if (value != null) value.Weilder = this;
                _weapon = value;
            }
        }

        private Armor _armor = ArmorFactory.GenerateArmor(ArmorType.Unarmoed);
        protected Armor Armor
        {
            get
            {
                return _armor;
            }
            set
            {
                if (value != null) value.Wearer = this;
                _armor = value;
            }
        }

        protected List<Potion> Potions { get; } = new List<Potion>();

        public Attribute Strength { get; set; } = AttributeFactory.GenerateAttribute(AttributeType.Strength);
        public Attribute Dexterity { get; set; } = AttributeFactory.GenerateAttribute(AttributeType.Dexterity);
        public Attribute Intelligence { get; set; } = AttributeFactory.GenerateAttribute(AttributeType.Intelligence);

        public Character()
        {
            Strength.Character = this;
            Dexterity.Character = this;
            Intelligence.Character = this;
        }
        
        internal void Initialize()
        {
            RemainingHealth = HealthPool;
        }

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
            var totalDamage = weaponDamage + Strength.Value;

            return totalDamage;
        }

        public void GetAttacked(int incomingDamange)
        {
            var randomizer = new Random();
            var didDodge = randomizer.Next(1, 10 - Dexterity.Value) == 1;

            if (didDodge)
            {
                PrintDodge();
                return;
            }

            var appliedDamange = Armor.MitigateDamage(incomingDamange);

            RemainingHealth -= Armor.MitigateDamage(incomingDamange);
            Console.WriteLine($"{CharacterName} took {appliedDamange} damange!");

            DeathCheck();
        }

        public void AddPoition(Potion potion)
        {
            if(potion != null)
            {
                potion.User = this;
                Potions.Add(potion);
            }
        }

        private void DeathCheck()
        {
            if (RemainingHealth <= 0)
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
