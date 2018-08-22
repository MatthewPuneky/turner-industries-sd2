using SD2.Patterns.FactoryMethod.DungeonHunter.Characters;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Potions
{
    public abstract class Potion : IDescribable
    {
        private Character _user;
        public Character User
        {
            get
            {
                return _user;
            }
            set
            {
                if (value != null) value.AddPoition(this);
                _user = value;
            }
        }

        public string NameOfPotion { get; }
        public int NumberOfUsesRemaining { get; protected set; }

        protected Potion(string nameOfPotion, int numberOfUses)
        {
            NameOfPotion = nameOfPotion;
            NumberOfUsesRemaining = numberOfUses;
        }

        public abstract void UsePotion();
        public abstract void PrintDescription();
    }
}
