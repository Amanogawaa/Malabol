namespace newgame;

public class BattleSystem
{
    public static List<Player> playerOnMove = new List<Player>();
    public static List<Mobs> mobOnMove = new List<Mobs>();


    public static void BattleStart()
    {
        //turns 
        playerOnMove.Add(PlayerCreation.createdPlayers[0]);

    }


    public static void SelectRandomMobs()
    {
        Random random = new Random();
        int selectMobs = random.Next(0, Mobs.LevelOne.Count);
        mobOnMove.Add(Mobs.LevelOne[selectMobs]);
        Console.WriteLine($"Selected Mob: {Mobs.LevelOne[selectMobs].mobName}");
    }

    public static void EndTurn()
    {

    }
}