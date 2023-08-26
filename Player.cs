namespace newgame;
public class Player
{
    public AdventurerClass? playerClass;
    public string? playerName { get; set; }
    public string? playerGender { get; set; }
    public bool isPlayer = false;
    public int? playerHp;
    public int playerMp;
    public int physicalAttack;
    public int magicAttack;
    public int defense;
    public List<Skill> Skills = new List<Skill>();


    public static List<Player> players = new List<Player>();

    public Player(string? playerName, string? playerGender, bool isPlayer, int? hp, int mp, int phatk, int matk, int def)
    {
        this.playerName = playerName;
        this.playerGender = playerGender;
        this.isPlayer = isPlayer;
        this.playerHp = hp;
        this.playerMp = mp;
        this.physicalAttack = phatk;
        this.magicAttack = matk;
        this.defense = def;

        if (isPlayer == true)
        {
            players.Add(this);
            Console.WriteLine("Player Added!");
        }
    }


    public void PlayerAttack(Mobs target)
    {
        int damageDealt = BattleSystem.playerOnMove[0].physicalAttack;
        target.mobHp -= damageDealt;
        Console.Write($"{BattleSystem.playerOnMove[0].playerName} damage the enemy!");
    }
}