using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters
{
    public class AttributeProfile
    {
        public Attribute Strength = AttributeFactory.GenerateAttribute(AttributeType.Strength);
        public Attribute Dexterity = AttributeFactory.GenerateAttribute(AttributeType.Dexterity);
        public Attribute Intelligence = AttributeFactory.GenerateAttribute(AttributeType.Intelligence);
    }
}
