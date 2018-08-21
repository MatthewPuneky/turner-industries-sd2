using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters
{
    public class Warrior : PlayerCharacter
    {
        public Warrior()
        {
            Health = 100;
        }

        public override void PrintDescription()
        {
            Console.WriteLine("A hearty being, able to weild mighty weapons.");
        }

        public override (string className, PlayerCharacterClass classEnum) GetClass()
        {
            return ("Warrior", PlayerCharacterClass.Warrior);
        }
    }
}
