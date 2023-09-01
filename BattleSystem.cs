namespace newgame;

public class BattleSystem
{
    public static List<Player> playerOnMove = new List<Player>();
    public static List<Mobs> mobOnMove = new List<Mobs>();


    public static void BattleStart()
    {
        Random random = new Random();

        playerOnMove.Add(PlayerCreation.createdPlayers[0]);

        int selectMobs = random.Next(0, Mobs.LevelOne.Count - 1);
        mobOnMove.Add(Mobs.LevelOne[selectMobs]);
        Console.WriteLine($"Selected Mob: {Mobs.LevelOne[selectMobs].mobName}");
        Console.WriteLine("Battle Start!");
        Console.ReadLine();

        bool onGoing = true;
        while (onGoing)
        {
            Console.WriteLine($"A wild {mobOnMove[0].mobName} has appear");
            Console.WriteLine("What will you do?");
            Console.WriteLine("[1] Attack");
            Console.WriteLine("[2] Run");
            int user = Convert.ToInt32(Console.ReadLine());

            switch (user)
            {
                case 1:
                    playerOnMove[0].PlayerAttack(mobOnMove[0]);
                    break;
                case 2:
                    // Implement player's defend action
                    Console.WriteLine("You chose to defend.");
                    break;
                case 3:
                    // Implement player's run action
                    Console.WriteLine("You chose to run.");
                    onGoing = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Choose again.");
                    break;
            }

            if (mobOnMove[0].mobHp <= 0)
            {
                Console.WriteLine($"Congratulations! You defeated {mobOnMove[0].mobName}");
                onGoing = false;
            }

            if (onGoing)
            {
                mobOnMove[0].MobAttack(playerOnMove[0]);

                if (playerOnMove[0].playerHp <= 0)
                {
                    Console.WriteLine("Oh no! You have been defeated.");
                    onGoing = false;
                }
            }
        }
        Console.WriteLine("Battle is over.");
    }
}




