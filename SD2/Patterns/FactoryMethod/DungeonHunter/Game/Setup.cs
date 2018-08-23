using System;
using SD2.Patterns.FactoryMethod.DungeonHunter.Characters;
using SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters;
using SD2.Patterns.FactoryMethod.DungeonHunter.States;
using SD2.SharedFeatures.Menus;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Game
{
    public class Setup
    {
        public static PlayerCharacter CreateYourCharacter()
        {
            Console.WriteLine("CARACTER CREATION");
            Console.WriteLine();

            MenuFactory.SelectClassMenu().Display();
            SetupAttributes(CharacterCreateState.Instance.ChosenCharacter);
            SetCharacterName(CharacterCreateState.Instance.ChosenCharacter);

            CharacterCreateState.Instance.ChosenCharacter.Initialize();

            return CharacterCreateState.Instance.ChosenCharacter;
        }

        private static void SetCharacterName(PlayerCharacter selectedClass)
        {
            Console.WriteLine("SET YOUR CHARACTER NAME");

            Console.Write($"Character Name: ");
            var input = Console.ReadLine();

            selectedClass.CharacterName = input;

            Console.WriteLine();
        }

        private static void SetupAttributes(PlayerCharacter selectedClass)
        {

            var availableAttributePoints = 10;

            var currentStrength = 0;
            var currentInteligence = 0;
            var currentDexterity = 0;

            Console.WriteLine("SELECT YOUR ATTRIBUTES");

            string GetNewStats(string attributeToEdit)
            {
                Console.WriteLine($"Current Strength : {currentStrength}");
                Console.WriteLine($"Current Intellect: {currentInteligence}");
                Console.WriteLine($"Current Dexterity: {currentDexterity}");
                Console.WriteLine($"Remaining Points : {availableAttributePoints}");
                Console.Write($"How much {attributeToEdit} would you like to add: ");
                var input = Console.ReadLine();
                Console.WriteLine();

                return input;
            }

            while (availableAttributePoints != 0)
            {
                while(availableAttributePoints != 0)
                {
                    var userInput = GetNewStats("Strength");

                    var wasParseable = int.TryParse(userInput, out var amount);

                    if (!wasParseable || amount > availableAttributePoints)
                    {
                        Console.WriteLine("You cannot do that action.");
                        Console.WriteLine();
                        continue;
                    }

                    currentStrength += amount;
                    availableAttributePoints -= amount;

                    break;
                }

                while (availableAttributePoints != 0)
                {
                    var userInput = GetNewStats("Inteligence");

                    var wasParseable = int.TryParse(userInput, out var amount);

                    if (!wasParseable || amount > availableAttributePoints)
                    {
                        Console.WriteLine("You cannot do that action.");
                        Console.WriteLine();
                        continue;
                    }

                    currentInteligence += amount;
                    availableAttributePoints -= amount;

                    break;
                }

                while (availableAttributePoints != 0)
                {
                    var userInput = GetNewStats("Dexterity");

                    var wasParseable = int.TryParse(userInput, out var amount);

                    if (!wasParseable || amount > availableAttributePoints)
                    {
                        Console.WriteLine("You cannot do that action.");
                        Console.WriteLine();
                        continue;
                    }

                    currentDexterity += amount;
                    availableAttributePoints -= amount;

                    break;
                }
            }

            selectedClass.Strength.Value = currentStrength;
            selectedClass.Intelligence.Value = currentInteligence;
            selectedClass.Dexterity.Value = currentDexterity;
        }
    }
}
