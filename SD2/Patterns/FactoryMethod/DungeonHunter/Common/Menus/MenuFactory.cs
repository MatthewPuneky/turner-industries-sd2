using SD2.Patterns.FactoryMethod.DungeonHunter.Game;
using SD2.Patterns.Singleton.Menus;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Common.Menus
{
    public static class MenuFactory
    {
        public static PlayerMenuHandler PlayerMenu() => new PlayerMenuHandler();
        public static SelectCrustMenuHandler SelectCrustMenu() => new SelectCrustMenuHandler();
    }
}
