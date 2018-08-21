using System;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Armors
{
    public class Unarmored : Armor
    {
        private static readonly int _armorRaiting = 0;
        private static readonly string _armorName = "Unarmored";

        public Unarmored() : base(_armorName, _armorRaiting)
        {
        }

        public override void PrintDescription()
        {
            Console.WriteLine("Unarmored, like the day you were born.");
        }
    }
}
