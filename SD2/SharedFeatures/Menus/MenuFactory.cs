using SD2.Patterns;
using SD2.Patterns.ChainOfResponsibility.Menus;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Menus;
using SD2.Patterns.FactoryMethod.DungeonHunter.Menus;
using SD2.Patterns.Singleton.Menus;

namespace SD2.SharedFeatures.Menus
{
    public static class MenuFactory
    {
        public static ApplicationMainMenu ApplicationMainMenu() => new ApplicationMainMenu();

        public static SelectClassMenu SelectClassMenu() => new SelectClassMenu();
        public static PlayerMenu PlayerMenu() => new PlayerMenu();

        public static PatternsMenu PatternsMenu() => new PatternsMenu();
        public static SelectCrustMenu SelectCrustMenu() => new SelectCrustMenu();

        public static FindUserMenu FindUserMenu() => new FindUserMenu();
    }
}