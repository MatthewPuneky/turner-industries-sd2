using System;
using System.Linq;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters.EnemyCharacters
{
    public static class EnemyCharacterFactory
    {
        public static EnemyCharacter Generate()
        {
            var randomizer = new Random();

            var enumValues = Enum.GetValues(typeof(EnemyCharacterType)).Cast<int>();
            var minValueInclusive = enumValues.Min();
            var maxValueInclusive = enumValues.Max();

            var maxValueExclusive = maxValueInclusive + 1;

            var creatureToCreate = (EnemyCharacterType) randomizer.Next(minValueInclusive, maxValueExclusive);

            return Generate(creatureToCreate);
        }

        public static EnemyCharacter Generate(EnemyCharacterType enemyCharacterType)
        {
            switch(enemyCharacterType)
            {
                case EnemyCharacterType.Rat: return new Rat();
                case EnemyCharacterType.Goblin: return new Goblin();
                default: throw new Exception($"Failure to find enemy of type {enemyCharacterType}");
            }
        }
    }
}
