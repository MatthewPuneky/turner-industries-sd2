using System.Collections.Generic;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers
{
    public static class IEnumerableHelpers
    {
        public static IEnumerable<int> Series
            (int startingValue = 0, 
            int addtionIncrementor = 1, 
            int multiplicativeIncrementor = 1)
        {
            var nextValue = startingValue;

            while(true)
            {
                yield return nextValue;
                nextValue = (multiplicativeIncrementor * nextValue) + addtionIncrementor;
            }
        }
    }
}
