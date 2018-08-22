using System;

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
                case UnarmedAttackStyle.Fist: Console.WriteLine("Fists fly violently through the air!"); break;
                case UnarmedAttackStyle.Claws: Console.WriteLine("Claws slice towards their enemy!"); break;
                default: Console.WriteLine($"(unknown unarmed attack style {Weilder.UnarmedAttackStyle})"); break;
            }
        }

        public override void PrintDescription()
        {
            switch (Weilder.UnarmedAttackStyle)
            {
                case UnarmedAttackStyle.Fist: Console.WriteLine("Only knuckles for bare fist brawling."); break;
                case UnarmedAttackStyle.Claws: Console.WriteLine("Serrated claws meant for rending."); break;
                default: Console.WriteLine($"(unknown unarmed attack style {Weilder.UnarmedAttackStyle})"); break;
            }

            Console.WriteLine();
        }
    }

    public enum UnarmedAttackStyle
    {
        Fist = 1,
        Claws
    }
}
