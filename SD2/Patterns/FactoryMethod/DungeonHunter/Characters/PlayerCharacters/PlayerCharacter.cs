namespace SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters
{
    public abstract class PlayerCharacter : Character
    {
        public abstract (string className, PlayerCharacterClass classEnum) GetClass();
    }

    public enum PlayerCharacterClass
    {
        Undecided = 0,
        Warrior = 1
    }
}
