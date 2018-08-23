using SD2.Patterns;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Menus;
using SD2.Patterns.Singleton.Menus;

namespace SD2.SharedFeatures.Menus
{
    public static class MenuHandlerFactory
    {
        public static ApplicationMainMenuHandler ApplicationMainMenu() => new ApplicationMainMenuHandler();
        public static PatternsMenuHandler PatternsMenu() => new PatternsMenuHandler();
        public static PlayerMenuHandler PlayerMenu() => new PlayerMenuHandler();
        public static SelectCrustMenuHandler SelectCrustMenu() => new SelectCrustMenuHandler();
    }
}
