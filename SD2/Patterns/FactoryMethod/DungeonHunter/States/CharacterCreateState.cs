using SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.States
{
    public sealed class CharacterCreateState
    {
        private CharacterCreateState() { }
        private static CharacterCreateState _instance;
        public static CharacterCreateState Instance => _instance ?? (_instance = new CharacterCreateState());

        private const int _totalAttributesAllowedToSpend = 10;

        public PlayerCharacter ChosenCharacter { get; set; }

        public int RemainingStatsToDistribute
        {
            get
            {
                var remainingPoints = _totalAttributesAllowedToSpend;
                remainingPoints -= ChosenCharacter.Strength.Value;
                remainingPoints -= ChosenCharacter.Intelligence.Value;
                remainingPoints -= ChosenCharacter.Dexterity.Value;

                return remainingPoints;
            }
        }
    }
}
