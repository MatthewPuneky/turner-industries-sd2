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
                case UnarmedAttackStyle.Fist: Printer.WriteLine("Fists fly violently through the air!"); break;
                case UnarmedAttackStyle.Claws: Printer.WriteLine("Claws slice towards their enemy!"); break;
                default: Printer.WriteLine($"(unknown unarmed attack style {Weilder.UnarmedAttackStyle})"); break;
            }
        }

        public override void Describe()
        {
            switch (Weilder.UnarmedAttackStyle)
            {
                case UnarmedAttackStyle.Fist: Printer.WriteLine("Only knuckles for bare fist brawling."); break;
                case UnarmedAttackStyle.Claws: Printer.WriteLine("Serrated claws meant for rending."); break;
                default: Printer.WriteLine($"(unknown unarmed attack style {Weilder.UnarmedAttackStyle})"); break;
            }

            Printer.WriteLine();
        }
    }

    public enum UnarmedAttackStyle
    {
        Fist = 1,
        Claws
    }
}
