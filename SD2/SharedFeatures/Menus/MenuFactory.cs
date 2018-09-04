using SD2.Patterns;
using SD2.Patterns.Adapter.LegacyBankAdapter.Menus;
using SD2.Patterns.Builder.Menus;
using SD2.Patterns.ChainOfResponsibility.Menus;
using SD2.Patterns.Command.Menus;
using SD2.Patterns.FactoryMethod.DungeonHunter.Menus;
using SD2.Patterns.Singleton.Menus;

namespace SD2.SharedFeatures.Menus
{
    public static class MenuFactory
    {
        public static ApplicationMainMenu ApplicationMainMenu() => new ApplicationMainMenu();

        public static SelectClassMenu SelectClassMenu() => new SelectClassMenu();
        public static ManageStrengthMenu ManageStrengthMenu() => new ManageStrengthMenu();
        public static ManageDexterityMenu ManageDexterityMenu() => new ManageDexterityMenu();
        public static ManageIntelligenceMenu ManageIntelligenceMenu() => new ManageIntelligenceMenu();
        public static ManageAttributesMenu ManageAttributesMenu() => new ManageAttributesMenu();
        public static NamePlayerCharacterMenu NamePlayerCharacterMenu() => new NamePlayerCharacterMenu();

        public static PlayerMenu PlayerMenu() => new PlayerMenu();

        public static PatternsMenu PatternsMenu() => new PatternsMenu();
        public static SelectCrustMenu SelectCrustMenu() => new SelectCrustMenu();

        public static FindUserMenu FindUserMenu() => new FindUserMenu();

        public static SelectClassToBuildMenu SelectClassToBuildMenu() => new SelectClassToBuildMenu();

        public static LegacyBankAdapterMenu LegacyBankAdapterMenu() => new LegacyBankAdapterMenu();

        public static TakeoffCommandMainMenu TakeoffCommandMainMenu() => new TakeoffCommandMainMenu();
    }
}