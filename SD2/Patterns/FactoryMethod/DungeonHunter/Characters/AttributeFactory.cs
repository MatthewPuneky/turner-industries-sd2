using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters
{
    public static class AttributeFactory
    {
        public static Attribute GenerateAttribute(AttributeType attributeType)
        {
            switch(attributeType)
            {
                case AttributeType.Strength:
                    return new Attribute
                    {
                        AttributeType = AttributeType.Strength,
                        Value = 0
                    };
                case AttributeType.Intelligence:
                    return new Attribute
                    {
                        AttributeType = AttributeType.Intelligence,
                        Value = 0
                    };
                case AttributeType.Dexterity:
                    return new Attribute
                    {
                        AttributeType = AttributeType.Dexterity,
                        Value = 0
                    };
                default: throw new Exception("Unrecognized attribute type.");
            }
        }
    }
}
