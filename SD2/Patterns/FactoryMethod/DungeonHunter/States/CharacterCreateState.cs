using SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.States
{
    public sealed class CharacterCreateState
    {
        private CharacterCreateState() { }
        private static CharacterCreateState _instance;
        public static CharacterCreateState Instance => _instance ?? (_instance = new CharacterCreateState());

        public PlayerCharacter ChosenCharacter { get; set; }
    }
}
