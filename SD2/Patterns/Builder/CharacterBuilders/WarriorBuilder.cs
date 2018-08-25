using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Builder.CharacterBuilders
{
    public class WarriorBuilder : CharacterBuilder
    {
        private Character _character = new Character();

        public override void BuildArmor()
        {
            _character.Armor = "Heavy Plate";
        }

        public override void BuildAttributes()
        {
            _character.Strength = 10;
            _character.Dexterity = 4;
            _character.Intelligence = 1;
        }

        public override void BuildWeapon()
        {
            _character.Weapon = "Iron Axe";
        }

        public override Character GetResult()
        {
            return _character;
        }
    }
}
