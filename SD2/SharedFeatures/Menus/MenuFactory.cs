using SD2.Patterns;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Menus;
using SD2.Patterns.Singleton.Menus;

namespace SD2.SharedFeatures.Menus
{
    public static class MenuFactory
    {
        public static ApplicationMainMenu ApplicationMainMenu() => new ApplicationMainMenu();
        public static PatternsMenu PatternsMenu() => new PatternsMenu();
        public static PlayerMenu PlayerMenu() => new PlayerMenu();
        public static SelectCrustMenu SelectCrustMenu() => new SelectCrustMenu();
    }
}