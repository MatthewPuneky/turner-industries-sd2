using System;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters.EnemyCharacters
{
    public abstract class EnemyCharacter : Character
    {
        public abstract int AttributePool { get; }
        public abstract EnemyCharacterType EnemyCharacterType { get; }
        public bool WasLooted { get; private set; }
        public override CharacterController CharacterController => CharacterController.NPC;

        public EnemyCharacter()
        {
            var attributeProfile = RandomizeAttributes(AttributePool);

            Strength.Value = attributeProfile.Strength.Value;
            Intelligence.Value = attributeProfile.Dexterity.Value;
            Dexterity.Value = attributeProfile.Intelligence.Value;

            Initialize();
        }

        public bool TryLoot(out Loot lootedItems)
        {
            if (WasLooted && !IsAlive)
            {
                WasLooted = true;

                lootedItems = new Loot
                {
                    Weapon = Weapon,
                    Armor = Armor,
                    Potions = Potions
                };

                return true;
            }

            PrintCantLootTarget();

            lootedItems = null;
            return false;
        }
        
        private static AttributeProfile RandomizeAttributes(int totalAttributesToSeparate)
        {
            var randomizer = new Random();

            var strength = randomizer.Next(0, totalAttributesToSeparate);
            var intelligence = randomizer.Next(0, totalAttributesToSeparate - strength);
            var dexterity = totalAttributesToSeparate - intelligence;

            var attributeProfile = new AttributeProfile();

            attributeProfile.Strength.Value = strength;
            attributeProfile.Intelligence.Value = intelligence;
            attributeProfile.Dexterity.Value = dexterity;

            return attributeProfile;
        }

        private void PrintCantLootTarget()
        {
            Console.WriteLine($"Cannot loot {CharacterName}.");
        }
    }

    public enum EnemyCharacterType
    {
        Rat = 1,
        Goblin
    }
}
