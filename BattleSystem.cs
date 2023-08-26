namespace newgame;

public class BattleSystem
{
    public static List<Player> playerOnMove = new List<Player>();
    public static List<Mobs> mobOnMove = new List<Mobs>();


    public static void BattleStart()
    {
        Random random = new Random();

        playerOnMove.Add(PlayerCreation.createdPlayers[0]);

        int selectMobs = random.Next(0, Mobs.LevelOne.Count);
        mobOnMove.Add(Mobs.LevelOne[selectMobs]);
        Console.WriteLine($"Selected Mob: {Mobs.LevelOne[selectMobs].mobName}");

        BattleLoop();
    }

    public static void BattleLoop()
    {
        while (true)
        {
            PlayerTurn();
        }
    }

    public static void PlayerTurn()
    {
        if (mobOnMove[0].mobHp <= 0)
        {
            Console.WriteLine($"{mobOnMove[0].mobName} defeated!");
            mobOnMove.RemoveAt(0);
            if (mobOnMove.Count == 0)
            {
                Console.WriteLine("Congratulations! You have won the battle!");

            }
        }
        else
        {
            MobTurn();
        }
    }

    public static void MobTurn()
    {

        if (playerOnMove[0].playerHp <= 0)
        {
            Console.WriteLine($"{playerOnMove[0].playerName} has been defeated!");
            // Implement game over logic here
        }
        else
        {
            PlayerTurn();
        }
    }
}

