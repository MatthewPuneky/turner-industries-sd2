using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Builder.CharacterBuilders
{
    public class WizzardBuilder : CharacterBuilder
    {
        private Character _character = new Character();

        public override void BuildArmor()
        {
            _character.Armor = "Cloth Robe";
        }

        public override void BuildAttributes()
        {
            _character.Strength = 2;
            _character.Dexterity = 2;
            _character.Intelligence = 11;
        }

        public override void BuildWeapon()
        {
            _character.Weapon = "Wood Staff";
        }

        public override Character GetResult()
        {
            return _character;
        }
    }
}
