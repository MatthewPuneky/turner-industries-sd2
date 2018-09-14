using System.Collections.Generic;

namespace SD2.SharedFeatures.Helpers
{
    public static class EnumeratorHelpers
    {
        public static T GetNext<T>(this IEnumerator<T> enumerator)
        {
            enumerator.MoveNext();
            return enumerator.Current;
        }
    }
}