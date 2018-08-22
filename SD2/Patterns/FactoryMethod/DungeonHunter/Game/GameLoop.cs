using SD2.Patterns.FactoryMethod.DungeonHunter.Characters.EnemyCharacters;
using SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters;
using System;
using SD2.Patterns.FactoryMethod.DungeonHunter.Characters;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Menus;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Game
{
    public class GameLoop
    {
        public static PlayerCharacter Player;

        public static void Start()
        {
            PrintTitle();

            Player = Setup.CreateYourCharacter();
            Loop();
        }

        public static void Loop()
        {
            while (Player.IsAlive)
            {
                WalkingPhase();
                EncounterPhase();
            }
        }

        public static void WalkingPhase()
        {
            var playerMenu = MenuFactory<PlayerMenu>.GenerateConstructorless();
            playerMenu.HandleMenu();
        }

        public static void EncounterPhase()
        {
            var enemy = EnemyCharacterFactory.Generate();

            Console.WriteLine($"A hostile {enemy.CharacterName} has appeard!");
            
            while (Player.IsAlive && enemy.IsAlive)
            {
                var playerTurn = true;
                var playerActions = 2;
                Console.Write("PLAYER ATTCK PHASE");
                while (playerTurn && Player.IsAlive)
                {
                    Console.WriteLine();
                    Console.WriteLine("BATTLE MENU");
                    Console.WriteLine("1: Attack");
                    //Console.WriteLine("2: Defend");
                    //Console.WriteLine("3: Move");
                    //Console.WriteLine("4: Identify");
                    //Console.WriteLine("5: Player Menu");
                    //Console.WriteLine("6: Game Menu");
                    Console.Write("Select an option: ");

                    var userInput = Console.ReadLine();
                    Console.WriteLine();

                    var wasParseable = int.TryParse(userInput, out var option);
                    if (!wasParseable) continue;

                    switch (option)
                    {
                        case 1: (playerTurn, playerActions) = TryAttackPhase(Player, enemy, playerActions); break;
                    }

                }
                Console.WriteLine();

                var enemyTurn = true;
                var enemyActions = 2;
                if (enemy.IsAlive)
                {
                    Console.Write("ENEMY ATTCK PHASE");
                }
                else
                {
                    return;
                }

                while (enemyTurn)
                {
                    Console.WriteLine();
                    (enemyTurn, enemyActions) = TryAttackPhase(enemy, Player, enemyActions);
                }
                Console.WriteLine();
            }

            Console.WriteLine("BATTLE COMPLETE");
            Console.WriteLine();
        }

        private static (bool, int) TryAttackPhase(Character aggressor, Character target, int remainingActions)
        {
            int option;

            while (true)
            {
                if (aggressor.CharacterController == CharacterController.Player)
                {
                    Console.WriteLine("ATTACK MENU");
                    Console.WriteLine("0: Return to Battle Menu");
                    Console.WriteLine("1: Half Attack");
                    Console.WriteLine("2: Full Attack");
                    Console.Write("Select an option: ");

                    var userInput = Console.ReadLine();
                    Console.WriteLine();

                    var wasParseable = int.TryParse(userInput, out option);
                    if (!wasParseable) continue;
                }
                else if (aggressor.CharacterController == CharacterController.NPC)
                {
                    option = 2;
                }
                else
                {
                    throw new Exception($"Unknown character controller {aggressor.CharacterController}");
                }

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Returning to battle menu...");
                        return (true, 0);
                    case 1:
                        Console.WriteLine("Half attack");
                        if (remainingActions >= 1) target.GetAttacked(aggressor.AttackWithWeapon() / 2);
                        else return (false, remainingActions);
                        return remainingActions - 1 == 0 ? (false, 0) : (true, remainingActions - 1);
                    case 2:
                        Console.WriteLine("FULL ATTACK!");
                        if (remainingActions >= 2) target.GetAttacked(aggressor.AttackWithWeapon());
                        else return (false, remainingActions);
                        return remainingActions - 2 == 0 ? (false, 0) : (true, remainingActions - 2);
                    default: continue;
                }
            }
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
