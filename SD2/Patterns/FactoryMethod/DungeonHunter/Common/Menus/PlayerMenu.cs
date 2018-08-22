using System;
using System.Collections.Generic;
using System.Linq;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Common.Menus
{
    public class PlayerMenu : Menu
    {
        protected override List<string> LegalValues => Enum.GetValues(typeof(PlayerMenuOptions))
                                                        .Cast<PlayerMenuOptions>()
                                                        .Select(x => ((int)x).ToString())
                                                        .ToList();
        protected override bool CanExit { get; }

        protected override void PrintMenuHeader()
        {
            Console.WriteLine("PLAYER MENU");
        }

        protected override void PrintMenuBody()
        {
            Console.WriteLine($"{(int)PlayerMenuOptions.EquipWeapon}: Equip Weapon");
            Console.WriteLine($"{(int)PlayerMenuOptions.EquipArmor}: Equip Armor");
            Console.WriteLine($"{(int)PlayerMenuOptions.UsePotion}: Use Potion");
            Console.WriteLine($"{(int)PlayerMenuOptions.DescribeSelf}: Describe Self");
            Console.WriteLine($"{(int)PlayerMenuOptions.Exit}: Leave Menu");
        }

        public override void HandleMenu()
        {
            var menuIsActive = true;

            while (menuIsActive)
            {
                var userInput = PrintMenuWithUserInput();
                var option = (PlayerMenuOptions)int.Parse(userInput);

                switch (option)
                {
                    case PlayerMenuOptions.EquipWeapon: Console.WriteLine("Under Construction"); break;
                    case PlayerMenuOptions.EquipArmor: Console.WriteLine("Under Construction"); break;
                    case PlayerMenuOptions.UsePotion: Console.WriteLine("Under Construction"); break;
                    case PlayerMenuOptions.DescribeSelf: Console.WriteLine("Under Construction"); break;
                    case PlayerMenuOptions.Exit: menuIsActive = false; break;
                }

                Console.WriteLine();
            }
        }

        protected enum PlayerMenuOptions
        {
            EquipWeapon = 1,
            EquipArmor,
            UsePotion,
            DescribeSelf,
            Exit
        }
    }
}
