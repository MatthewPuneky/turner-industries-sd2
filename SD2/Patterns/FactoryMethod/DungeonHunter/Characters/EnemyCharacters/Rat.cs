using SD2.SharedFeatures.Printers;
using SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters.EnemyCharacters
{
    public class Rat : EnemyCharacter
    {
        public override UnarmedAttackStyle UnarmedAttackStyle => UnarmedAttackStyle.Claws;
        public override EnemyCharacterType EnemyCharacterType => EnemyCharacterType.Rat;
        public override string CharacterName { get; set; } = "Large Rat";
        public override int TotalAttributePoints { get; set; } = 3;

        public override void PrintDescription()
        {
            Printer.WriteLine("A frothing rat, larger than normal.");
        }
    }
}
