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
            var minValue = enumValues.Min();
            var maxValue = enumValues.Max();

            var creatureToCreate = (EnemyCharacterType) randomizer.Next(minValue, maxValue);

            return Generate(creatureToCreate);
        }

        public static EnemyCharacter Generate(EnemyCharacterType enemyCharacterType)
        {
            switch(enemyCharacterType)
            {
                case EnemyCharacterType.Rat: return new Rat();
                default: throw new Exception($"Failure to find enemy of type {enemyCharacterType}");
            }
        }
    }
}
