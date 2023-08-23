namespace newgame;
public class Player
{
    public string? playerName = "";
    public string? playerGender = "";
    public bool isPlayer = false;
    public bool isBad = false;
    public static List<Player> players = new List<Player>();
    public static List<Player> randomNames = new List<Player>();

    public Player(string? playerName, string? playerGender, bool isPlayer)
    {
        this.playerName = playerName;
        this.playerGender = playerGender;
        this.isPlayer = isPlayer;
        randomNames.Add(this);

        if (isPlayer == true)
        {
            players.Add(this);
            Console.WriteLine("Player Added!");
        }
    }

    //randomnames for user to choose if they want to have random preset of character
    //thanks denz for the idea!
    //to be implemented after im done with something
    public static Player Alex = new Player("Alex", "Male", false);
    public static Player Katrina = new Player("Katrina", "Female", false);
    public static Player Sean = new Player("Sean", "Female", false);
    public static Player Estella = new Player("Estella", "Female", false);
    public static Player Denzel = new Player("Denzel", "Male", false);
    public static Player Supido = new Player("Supido", "Male", false);
}