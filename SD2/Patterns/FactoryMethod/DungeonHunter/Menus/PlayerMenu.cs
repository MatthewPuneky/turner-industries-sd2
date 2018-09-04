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
            Printer.PrintLine("PLAYER MENU");
        }

        protected override void PrintMenuBody()
        {
            Printer.PrintLine($"{(int)PlayerMenuOptions.EquipWeapon}: Equip Weapon");
            Printer.PrintLine($"{(int)PlayerMenuOptions.EquipArmor}: Equip Armor");
            Printer.PrintLine($"{(int)PlayerMenuOptions.UsePotion}: Use Potion");
            Printer.PrintLine($"{(int)PlayerMenuOptions.DescribeSelf}: Describe Self");
        }

        protected override void MenuOptions(string userInput)
        {
            var option = (PlayerMenuOptions)int.Parse(userInput);

            switch (option)
            {
                case PlayerMenuOptions.EquipWeapon: Printer.PrintLine(Constants.Menu.UnderConstructionToUserResponse); break;
                case PlayerMenuOptions.EquipArmor: Printer.PrintLine(Constants.Menu.UnderConstructionToUserResponse); break;
                case PlayerMenuOptions.UsePotion: Printer.PrintLine(Constants.Menu.UnderConstructionToUserResponse); break;
                case PlayerMenuOptions.DescribeSelf: Printer.PrintLine(Constants.Menu.UnderConstructionToUserResponse); break;
                default:
                    Printer.PrintLine(Constants.Menu.FailedToHandle(option.ToString()));
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
