using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Builder.CharacterBuilders
{
    public class RangerBuilder : CharacterBuilder
    {
        private Character _character = new Character();

        public override void BuildArmor()
        {
            _character.Armor = "Light Leather";
        }

        public override void BuildAttributes()
        {
            _character.Strength = 3;
            _character.Dexterity = 8;
            _character.Intelligence = 4;
        }

        public override void BuildWeapon()
        {
            _character.Weapon = "Elven Bow";
        }

        public override Character GetResult()
        {
            return _character;
        }
    }
}
