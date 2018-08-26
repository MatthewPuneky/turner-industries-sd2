using System.Collections.Generic;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.Patterns.FactoryMethod.DungeonHunter.Game;
using SD2.SharedFeatures.Common;
using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Menus
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
            Printer.WriteLine("PLAYER MENU");
        }

        protected override void PrintMenuBody()
        {
            Printer.WriteLine($"{(int)PlayerMenuOptions.EquipWeapon}: Equip Weapon");
            Printer.WriteLine($"{(int)PlayerMenuOptions.EquipArmor}: Equip Armor");
            Printer.WriteLine($"{(int)PlayerMenuOptions.UsePotion}: Use Potion");
            Printer.WriteLine($"{(int)PlayerMenuOptions.DescribeSelf}: Describe Self");
        }

        protected override void MenuOptions(string userInput)
        {
            var option = (PlayerMenuOptions)int.Parse(userInput);

            switch (option)
            {
                case PlayerMenuOptions.EquipWeapon: Printer.WriteLine(Constants.Menu.UnderConstructionToUserResponse); break;
                case PlayerMenuOptions.EquipArmor: Printer.WriteLine(Constants.Menu.UnderConstructionToUserResponse); break;
                case PlayerMenuOptions.UsePotion: Printer.WriteLine(Constants.Menu.UnderConstructionToUserResponse); break;
                case PlayerMenuOptions.DescribeSelf: Printer.WriteLine(Constants.Menu.UnderConstructionToUserResponse); break;
                default:
                    Printer.WriteLine(Constants.Menu.FailedToHandle(option.ToString()));
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
