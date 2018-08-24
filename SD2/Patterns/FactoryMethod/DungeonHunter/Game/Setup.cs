using System;
using SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters;
using SD2.Patterns.FactoryMethod.DungeonHunter.States;
using SD2.SharedFeatures.Menus;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Game
{
    public class Setup
    {
        public static PlayerCharacter CreateYourCharacter()
        {
            Console.WriteLine("CHARACTER CREATION");
            Console.WriteLine();

            MenuFactory.SelectClassMenu().Display();
            MenuFactory.ManageAttributesMenu().Display();
            MenuFactory.NamePlayerCharacterMenu().Display();

            CharacterCreateState.Instance.ChosenCharacter.Initialize();

            return CharacterCreateState.Instance.ChosenCharacter;
        }
    }
}
