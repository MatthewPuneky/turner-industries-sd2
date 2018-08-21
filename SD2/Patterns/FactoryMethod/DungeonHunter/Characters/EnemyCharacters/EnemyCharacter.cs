using System;
using System.Collections.Generic;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common;
using SD2.Patterns.FactoryMethod.DungeonHunter.Items.Armors;
using SD2.Patterns.FactoryMethod.DungeonHunter.Items.Potions;
using SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters.EnemyCharacters
{
    public abstract class EnemyCharacter : Character
    {
        public bool WasLooted { get; private set; }

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

        private void PrintCantLootTarget()
        {
            Console.WriteLine($"Cannot loot {CharacterName}.");
        }
    }
}
