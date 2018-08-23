using System;
using System.Collections.Generic;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.Patterns.FactoryMethod.DungeonHunter.Game;
using SD2.SharedFeatures.Common;
using SD2.SharedFeatures.Menus;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Common.Menus
{
    public class PlayerMenu : Menu
    {
        protected override List<string> LegalValues => EnumHelper.PoistionValuesToStringList(typeof(PlayerMenuOptions));
        protected override bool CanExit => true;

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
    }

    public class PlayerMenuHandler : MenuHandler<DungeonHunterState>
    {
        public PlayerMenuHandler() 
            : base(MenuFactory.PlayerMenu(), DungeonHunterState.Instance)
        {
        }

        protected override void MenuOptions(string userInput)
        {
            var option = (PlayerMenuOptions)int.Parse(userInput);

            switch (option)
            {
                case PlayerMenuOptions.EquipWeapon: Console.WriteLine("Under Construction"); break;
                case PlayerMenuOptions.EquipArmor: Console.WriteLine("Under Construction"); break;
                case PlayerMenuOptions.UsePotion: Console.WriteLine("Under Construction"); break;
                case PlayerMenuOptions.DescribeSelf: Console.WriteLine("Under Construction"); break;
                case PlayerMenuOptions.Exit: MenuIsActive = false; break;
                default:
                    Console.WriteLine(Constants.MenuConstants.FailedToHandle(option.ToString()));
                    break;
            }
        }
    }

    public enum PlayerMenuOptions
    {
        EquipWeapon = 1,
        EquipArmor,
        UsePotion,
        DescribeSelf,
        Exit
    }
}
