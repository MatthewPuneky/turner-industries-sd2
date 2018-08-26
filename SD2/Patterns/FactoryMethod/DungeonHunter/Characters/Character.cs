using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common;
using SD2.Patterns.FactoryMethod.DungeonHunter.Items.Armors;
using SD2.Patterns.FactoryMethod.DungeonHunter.Items.Potions;
using SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters
{
    public abstract class Character : IDescribable
    {
        public abstract int TotalAttributePoints { get; set; }
        public int RemainingStatsToDistribute
        {
            get
            {
                var remainingPoints = TotalAttributePoints;
                remainingPoints -= Strength.Value;
                remainingPoints -= Intelligence.Value;
                remainingPoints -= Dexterity.Value;

                return remainingPoints;
            }
        }

        public static int MiniumumStartingHealth = 10;

        public bool IsAlive { get; private set; } = true;
        public int HealthPool { get; set; } = MiniumumStartingHealth;
        public int RemainingHealth { get; protected set; } = MiniumumStartingHealth;

        public abstract string CharacterName { get; set; }
        public abstract CharacterController CharacterController { get; }
        public abstract UnarmedAttackStyle UnarmedAttackStyle { get; }

        private Weapon _weapon;
        public Weapon Weapon
        { 
            get => _weapon;
            set
            {
                _weapon = value;
                if (value != null && value.Weilder != this) value.Weilder = this;
            }
        }

        private Armor _armor = ArmorFactory.GenerateArmor(ArmorType.Unarmoed);
        protected Armor Armor
        {
            get => _armor;
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

        protected Character()
        {
            Strength.Character = this;
            Dexterity.Character = this;
            Intelligence.Character = this;
        }
        
        internal void Initialize()
        {
            RemainingHealth = HealthPool;
            Weapon = WeaponFactory.GenerateWeapon(WeaponType.Unarmed);
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
            var didDodge = GlobalRandomizer.Next(1, 11 - Dexterity.Value) == 1;

            if (didDodge)
            {
                PrintDodge();
                return;
            }

            var appliedDamange = Armor.MitigateDamage(incomingDamange);

            RemainingHealth -= Armor.MitigateDamage(incomingDamange);
            Printer.WriteLine($"{CharacterName} took {appliedDamange} damange!");

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
                Printer.WriteLine($"{CharacterName} has died.");
            }
        }

        private void PrintDodge()
        {
            Printer.WriteLine($"{CharacterName} dodged the attack!");
        }
        
        public abstract void Describe();
    }

    public enum CharacterController
    {
        Player = 1,
        NPC
    }
}
