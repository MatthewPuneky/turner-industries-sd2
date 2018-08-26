using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters
{
    public class Warrior : PlayerCharacter
    {
        public override PlayerCharacterClass ClassType => PlayerCharacterClass.Warrior;

        public override void Describe()
        {
            Printer.WriteLine("A hearty being, able to weild mighty weapons.");
        }
    }
}
