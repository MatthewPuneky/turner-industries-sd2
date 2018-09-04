namespace SD2.SharedFeatures.Helpers
{
    public static class IntHelpers
    {
        private static int _nextId = 1;
        public static int NextId()
        {
            return _nextId++;
        }
    }
}
