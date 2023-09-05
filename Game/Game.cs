namespace newgame;

public class Game
{
    // public static List<Player> CurrentPlayer = new List<Player>();
    public static void GameStart()
    {
        PlayerCreation.MainMenu();
        Menu.UI(PlayerCreation.createdPlayers[0]);
        BattleSystem.BattleStart();
    }
}