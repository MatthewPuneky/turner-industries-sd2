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

            Printer.PrintLine($"A hostile {enemy.CharacterName} has appeard!");
            
            while (Player.IsAlive && enemy.IsAlive)
            {
                var playerTurn = true;
                var playerActions = 2;
                Printer.Print("PLAYER ATTCK PHASE");
                while (playerTurn && Player.IsAlive)
                {
                    Printer.PrintLine();
                    Printer.PrintLine("BATTLE MENU");
                    Printer.PrintLine("1: Attack");
                    //Printer.WriteLine("2: Defend");
                    //Printer.WriteLine("3: Move");
                    //Printer.WriteLine("4: Identify");
                    //Printer.WriteLine("5: Player Menu");
                    //Printer.WriteLine("6: Game Menu");
                    Printer.Print("Select an option: ");

                    var userInput = Printer.ReadLine();
                    Printer.PrintLine();

                    var wasParseable = int.TryParse(userInput, out var option);
                    if (!wasParseable) continue;

                    switch (option)
                    {
                        case 1: (playerTurn, playerActions) = TryAttackPhase(Player, enemy, playerActions); break;
                    }

                }
                Printer.PrintLine();

                var enemyTurn = true;
                var enemyActions = 2;
                if (enemy.IsAlive)
                {
                    Printer.Print("ENEMY ATTCK PHASE");
                }
                else
                {
                    return;
                }

                while (enemyTurn)
                {
                    Printer.PrintLine();
                    (enemyTurn, enemyActions) = TryAttackPhase(enemy, Player, enemyActions);
                }
                Printer.PrintLine();
            }

            Printer.PrintLine("BATTLE COMPLETE");
            Printer.PrintLine();
        }

        private static (bool, int) TryAttackPhase(Character aggressor, Character target, int remainingActions)
        {
            int option;

            while (true)
            {
                if (aggressor.CharacterController == CharacterController.Player)
                {
                    Printer.PrintLine("ATTACK MENU");
                    Printer.PrintLine("0: Return to Battle Menu");
                    Printer.PrintLine("1: Half Attack");
                    Printer.PrintLine("2: Full Attack");
                    Printer.Print("Select an option: ");

                    var userInput = Printer.ReadLine();
                    Printer.PrintLine();

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
                        Printer.PrintLine("Returning to battle menu...");
                        return (true, 0);
                    case 1:
                        Printer.PrintLine("Half attack");
                        if (remainingActions >= 1) target.GetAttacked(aggressor.AttackWithWeapon() / 2);
                        else return (false, remainingActions);
                        return remainingActions - 1 == 0 ? (false, 0) : (true, remainingActions - 1);
                    case 2:
                        Printer.PrintLine("FULL ATTACK!");
                        if (remainingActions >= 2) target.GetAttacked(aggressor.AttackWithWeapon());
                        else return (false, remainingActions);
                        return remainingActions - 2 == 0 ? (false, 0) : (true, remainingActions - 2);
                    default: continue;
                }
            }
        }

        private static void PrintTitle()
        {
            Printer.PrintLine(@" ______            _        _______  _______  _______  _       ");
            Printer.PrintLine(@"(  __  \ |\     /|( (    /|(  ____ \(  ____ \(  ___  )( (    /|");
            Printer.PrintLine(@"| (  \  )| )   ( ||  \  ( || (    \/| (    \/| (   ) ||  \  ( |");
            Printer.PrintLine(@"| |   ) || |   | ||   \ | || |      | (__    | |   | ||   \ | |");
            Printer.PrintLine(@"| |   | || |   | || (\ \) || | ____ |  __)   | |   | || (\ \) |");
            Printer.PrintLine(@"| |   ) || |   | || | \   || | \_  )| (      | |   | || | \   |");
            Printer.PrintLine(@"| (__/  )| (___) || )  \  || (___) || (____/\| (___) || )  \  |");
            Printer.PrintLine(@"(______/ (_______)|/    )_)(_______)(_______/(_______)|/    )_)");
            Printer.PrintLine(@"                       _       _________ _______  _______ ");
            Printer.PrintLine(@"    |\     /||\     /|( (    /|\__   __/(  ____ \(  ____ )");
            Printer.PrintLine(@"    | )   ( || )   ( ||  \  ( |   ) (   | (    \/| (    )|");
            Printer.PrintLine(@"    | (___) || |   | ||   \ | |   | |   | (__    | (____)|");
            Printer.PrintLine(@"    |  ___  || |   | || (\ \) |   | |   |  __)   |     __)");
            Printer.PrintLine(@"    | (   ) || |   | || | \   |   | |   | (      | (\ (   ");
            Printer.PrintLine(@"    | )   ( || (___) || )  \  |   | |   | (____/\| ) \ \__");
            Printer.PrintLine(@"    |/     \|(_______)|/    )_)   )_(   (_______/|/   \__/");
            Printer.PrintLine();
        }
    }
}
