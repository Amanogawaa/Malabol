namespace newgame;

public class Game
{
    public static List<Player> currentUser = new List<Player>();

    public static void GameStart()
    {
        PlayerCreation.MainMenu();
    }
}