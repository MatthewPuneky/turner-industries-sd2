namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters
{
    public class Attribute
    {
        public Character Character { get; set; }
        public AttributeType AttributeType { get; set; }

        private int _value;
        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (Character != null && AttributeType == AttributeType.Strength)
                    Character.HealthPool = Character.MiniumumStartingHealth + Character.MiniumumStartingHealth * value;
                _value = value;
            }
        }
    }

    public enum AttributeType
    {
        Strength = 0,
        Intelligence,
        Dexterity
    }
}
