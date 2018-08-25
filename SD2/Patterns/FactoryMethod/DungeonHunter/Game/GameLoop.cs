using SD2.Patterns.FactoryMethod.DungeonHunter.Characters.EnemyCharacters;
using SD2.Patterns.FactoryMethod.DungeonHunter.Characters.PlayerCharacters;
using SD2.SharedFeatures.Printers;
using SD2.Patterns.FactoryMethod.DungeonHunter.Characters;
using SD2.SharedFeatures.Menus;
using System;

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
            MenuFactory.PlayerMenu().Display();
        }

        public static void EncounterPhase()
        {
            var enemy = EnemyCharacterFactory.Generate();

            Printer.WriteLine($"A hostile {enemy.CharacterName} has appeard!");
            
            while (Player.IsAlive && enemy.IsAlive)
            {
                var playerTurn = true;
                var playerActions = 2;
                Printer.Write("PLAYER ATTCK PHASE");
                while (playerTurn && Player.IsAlive)
                {
                    Printer.WriteLine();
                    Printer.WriteLine("BATTLE MENU");
                    Printer.WriteLine("1: Attack");
                    //Printer.WriteLine("2: Defend");
                    //Printer.WriteLine("3: Move");
                    //Printer.WriteLine("4: Identify");
                    //Printer.WriteLine("5: Player Menu");
                    //Printer.WriteLine("6: Game Menu");
                    Printer.Write("Select an option: ");

                    var userInput = Printer.ReadLine();
                    Printer.WriteLine();

                    var wasParseable = int.TryParse(userInput, out var option);
                    if (!wasParseable) continue;

                    switch (option)
                    {
                        case 1: (playerTurn, playerActions) = TryAttackPhase(Player, enemy, playerActions); break;
                    }

                }
                Printer.WriteLine();

                var enemyTurn = true;
                var enemyActions = 2;
                if (enemy.IsAlive)
                {
                    Printer.Write("ENEMY ATTCK PHASE");
                }
                else
                {
                    return;
                }

                while (enemyTurn)
                {
                    Printer.WriteLine();
                    (enemyTurn, enemyActions) = TryAttackPhase(enemy, Player, enemyActions);
                }
                Printer.WriteLine();
            }

            Printer.WriteLine("BATTLE COMPLETE");
            Printer.WriteLine();
        }

        private static (bool, int) TryAttackPhase(Character aggressor, Character target, int remainingActions)
        {
            int option;

            while (true)
            {
                if (aggressor.CharacterController == CharacterController.Player)
                {
                    Printer.WriteLine("ATTACK MENU");
                    Printer.WriteLine("0: Return to Battle Menu");
                    Printer.WriteLine("1: Half Attack");
                    Printer.WriteLine("2: Full Attack");
                    Printer.Write("Select an option: ");

                    var userInput = Printer.ReadLine();
                    Printer.WriteLine();

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
                        Printer.WriteLine("Returning to battle menu...");
                        return (true, 0);
                    case 1:
                        Printer.WriteLine("Half attack");
                        if (remainingActions >= 1) target.GetAttacked(aggressor.AttackWithWeapon() / 2);
                        else return (false, remainingActions);
                        return remainingActions - 1 == 0 ? (false, 0) : (true, remainingActions - 1);
                    case 2:
                        Printer.WriteLine("FULL ATTACK!");
                        if (remainingActions >= 2) target.GetAttacked(aggressor.AttackWithWeapon());
                        else return (false, remainingActions);
                        return remainingActions - 2 == 0 ? (false, 0) : (true, remainingActions - 2);
                    default: continue;
                }
            }
        }

        private static void PrintTitle()
        {
            Printer.WriteLine(@" ______            _        _______  _______  _______  _       ");
            Printer.WriteLine(@"(  __  \ |\     /|( (    /|(  ____ \(  ____ \(  ___  )( (    /|");
            Printer.WriteLine(@"| (  \  )| )   ( ||  \  ( || (    \/| (    \/| (   ) ||  \  ( |");
            Printer.WriteLine(@"| |   ) || |   | ||   \ | || |      | (__    | |   | ||   \ | |");
            Printer.WriteLine(@"| |   | || |   | || (\ \) || | ____ |  __)   | |   | || (\ \) |");
            Printer.WriteLine(@"| |   ) || |   | || | \   || | \_  )| (      | |   | || | \   |");
            Printer.WriteLine(@"| (__/  )| (___) || )  \  || (___) || (____/\| (___) || )  \  |");
            Printer.WriteLine(@"(______/ (_______)|/    )_)(_______)(_______/(_______)|/    )_)");
            Printer.WriteLine(@"                       _       _________ _______  _______ ");
            Printer.WriteLine(@"    |\     /||\     /|( (    /|\__   __/(  ____ \(  ____ )");
            Printer.WriteLine(@"    | )   ( || )   ( ||  \  ( |   ) (   | (    \/| (    )|");
            Printer.WriteLine(@"    | (___) || |   | ||   \ | |   | |   | (__    | (____)|");
            Printer.WriteLine(@"    |  ___  || |   | || (\ \) |   | |   |  __)   |     __)");
            Printer.WriteLine(@"    | (   ) || |   | || | \   |   | |   | (      | (\ (   ");
            Printer.WriteLine(@"    | )   ( || (___) || )  \  |   | |   | (____/\| ) \ \__");
            Printer.WriteLine(@"    |/     \|(_______)|/    )_)   )_(   (_______/|/   \__/");
            Printer.WriteLine();
        }
    }
}
