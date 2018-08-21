using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Potions
{
    public abstract class Potion : IDescribable
    {
        public string NameOfPotion { get; }
        public int NumberOfUsesRemaining { get; protected set; }

        protected Potion(string nameOfPotion, int numberOfUses)
        {
            NameOfPotion = nameOfPotion;
            NumberOfUsesRemaining = numberOfUses;
        }

        public abstract void PrintDescription();
    }
}
