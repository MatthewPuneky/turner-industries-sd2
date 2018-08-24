using System;
using System.Collections.Generic;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.Patterns.FactoryMethod.DungeonHunter.Game;
using SD2.SharedFeatures.Menus;
using static SD2.SharedFeatures.Common.Constants;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Common.Menus
{
    public class PlayerMenu : Menu<DungeonHunterState>
    {
        public PlayerMenu() 
            : base(DungeonHunterState.Instance)
        {
        }

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
        }

        protected override void MenuOptions(string userInput)
        {
            var option = (PlayerMenuOptions)int.Parse(userInput);

            switch (option)
            {
                case PlayerMenuOptions.EquipWeapon: Console.WriteLine(MenuConstants.UnderConstructionToUserResponse); break;
                case PlayerMenuOptions.EquipArmor: Console.WriteLine(MenuConstants.UnderConstructionToUserResponse); break;
                case PlayerMenuOptions.UsePotion: Console.WriteLine(MenuConstants.UnderConstructionToUserResponse); break;
                case PlayerMenuOptions.DescribeSelf: Console.WriteLine(MenuConstants.UnderConstructionToUserResponse); break;
                default:
                    Console.WriteLine(MenuConstants.FailedToHandle(option.ToString()));
                    break;
            }
        }
    }

    public enum PlayerMenuOptions
    {
        EquipWeapon = 1,
        EquipArmor,
        UsePotion,
        DescribeSelf
    }
}
