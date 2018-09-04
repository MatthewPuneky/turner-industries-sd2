using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons
{
    public class Unarmed : Weapon
    {
        public override WeaponType WeaponType => WeaponType.Unarmed;
        public override string Name => "Unarmed";
        public override int AttackPower => 1;
        public override int Range => 1;
        public override int DamageMultiplyer => 1;
        public override Characters.Attribute EnhancingAttribute => Weilder.Strength;

        public override void PrintWeaponAttack()
        {
            switch (Weilder.UnarmedAttackStyle)
            {
                case UnarmedAttackStyle.Fist: Printer.PrintLine("Fists fly violently through the air!"); break;
                case UnarmedAttackStyle.Claws: Printer.PrintLine("Claws slice towards their enemy!"); break;
                default: Printer.PrintLine($"(unknown unarmed attack style {Weilder.UnarmedAttackStyle})"); break;
            }
        }

        public override void Describe()
        {
            switch (Weilder.UnarmedAttackStyle)
            {
                case UnarmedAttackStyle.Fist: Printer.PrintLine("Only knuckles for bare fist brawling."); break;
                case UnarmedAttackStyle.Claws: Printer.PrintLine("Serrated claws meant for rending."); break;
                default: Printer.PrintLine($"(unknown unarmed attack style {Weilder.UnarmedAttackStyle})"); break;
            }

            Printer.PrintLine();
        }
    }

    public enum UnarmedAttackStyle
    {
        Fist = 1,
        Claws
    }
}
