using System;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Common
{
    public static class GlobalRandomizer
    {
        private static readonly Random _random = new Random();

        public static int Next(int minValueInclusive, int maxValueExclusive)
        {
            return _random.Next(minValueInclusive, maxValueExclusive);
        }
    }
}
