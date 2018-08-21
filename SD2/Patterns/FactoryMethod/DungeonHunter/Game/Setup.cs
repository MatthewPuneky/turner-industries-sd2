using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.Patterns.FactoryMethod.DungeonHunter.Characters;
using SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Game
{
    public class Setup
    {
        public static PlayerCharacter CreateYourCharacter()
        {
            Console.WriteLine("CARACTER CREATION");
            Console.WriteLine();

            var selectedClass = ClassSelection();
            SetupAttributes(selectedClass);
            SetCharacterName(selectedClass);

            return selectedClass;
        }

        private static void SetCharacterName(PlayerCharacter selectedClass)
        {
            Console.WriteLine("SET YOUR CHARACTER NAME");

            Console.Write($"Character Name: ");
            var input = Console.ReadLine();

            selectedClass.CharacterName = input;
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

            selectedClass.Strength = currentStrength;
            selectedClass.Inteligence = currentInteligence;
            selectedClass.Dexterity = currentDexterity;
        }

        private static PlayerCharacter ClassSelection()
        {
            var characterFactory = new CharacterFactory();

            while (true)
            {
                Console.WriteLine("SELECT YOUR CLASS");

                var classes = ReflectiveEnumerator.GetEnumerableOfType<PlayerCharacter>();

                foreach (var @class in classes)
                {
                    var classAttributes = @class.GetClass();
                    Console.WriteLine($"{(int)classAttributes.classEnum}: {classAttributes.className}");
                }

                Console.Write("Select an option: ");
                var userInput = Console.ReadLine();
                Console.WriteLine();

                var wasParseable = Enum.TryParse<PlayerCharacterClass>(userInput, out var option);
                if (!wasParseable) continue;

                switch (option)
                {
                    case PlayerCharacterClass.Undecided: continue;
                    case PlayerCharacterClass.Warrior: return characterFactory.GeneratePlayerCharacter(option);
                    default: Console.WriteLine("INVALID OPTION\n"); continue;
                }
            }
        }
    }
}
