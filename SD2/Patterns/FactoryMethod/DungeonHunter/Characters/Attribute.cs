using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters
{
    public class Attribute
    {
        public Character character { get; private set; }
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
                if (character != null) character.HealthPool *= _value;
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
