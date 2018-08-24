using SD2.SharedFeatures.Menus;

namespace SD2.Patterns.Adapter.LegacyBankAdapter
{
    public static class Run
    {
        public static void Operation()
        {
            MenuFactory.LegacyBankAdapterMenu().Display();
        }
    }
}
