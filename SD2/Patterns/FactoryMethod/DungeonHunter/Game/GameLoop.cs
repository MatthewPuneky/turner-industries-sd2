using SD2.Patterns.FactoryMethod.DungeonHunter.Characters.EnemyCharacters;
using SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters;
using System;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Game
{
    public class GameLoop
    {
        public static PlayerCharacter player;

        public static void Start()
        {
            PrintTitle();

            player = Setup.CreateYourCharacter();
        }

        public static void Loop(PlayerCharacter player)
        {
            WalkingPhase();
            EncounterPhase();
        }

        public static void WalkingPhase()
        {

        }

        public static void EncounterPhase()
        {
            var enemy = EnemyCharacterFactory.Generate();
            Console.WriteLine($"A hostile {enemy.Name} has appeard!");
        }

        private static void PrintTitle()
        {
            Console.WriteLine(@" ______            _        _______  _______  _______  _       ");
            Console.WriteLine(@"(  __  \ |\     /|( (    /|(  ____ \(  ____ \(  ___  )( (    /|");
            Console.WriteLine(@"| (  \  )| )   ( ||  \  ( || (    \/| (    \/| (   ) ||  \  ( |");
            Console.WriteLine(@"| |   ) || |   | ||   \ | || |      | (__    | |   | ||   \ | |");
            Console.WriteLine(@"| |   | || |   | || (\ \) || | ____ |  __)   | |   | || (\ \) |");
            Console.WriteLine(@"| |   ) || |   | || | \   || | \_  )| (      | |   | || | \   |");
            Console.WriteLine(@"| (__/  )| (___) || )  \  || (___) || (____/\| (___) || )  \  |");
            Console.WriteLine(@"(______/ (_______)|/    )_)(_______)(_______/(_______)|/    )_)");
            Console.WriteLine(@"                       _       _________ _______  _______ ");
            Console.WriteLine(@"    |\     /||\     /|( (    /|\__   __/(  ____ \(  ____ )");
            Console.WriteLine(@"    | )   ( || )   ( ||  \  ( |   ) (   | (    \/| (    )|");
            Console.WriteLine(@"    | (___) || |   | ||   \ | |   | |   | (__    | (____)|");
            Console.WriteLine(@"    |  ___  || |   | || (\ \) |   | |   |  __)   |     __)");
            Console.WriteLine(@"    | (   ) || |   | || | \   |   | |   | (      | (\ (   ");
            Console.WriteLine(@"    | )   ( || (___) || )  \  |   | |   | (____/\| ) \ \__");
            Console.WriteLine(@"    |/     \|(_______)|/    )_)   )_(   (_______/|/   \__/");
            Console.WriteLine();
        }
    }
}
