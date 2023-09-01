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
        int damage = 0;

        if (target.mobHp > 0)
        {
            damage = this.physicalAttack - target.mobHp;
            target.mobHp -= damage;
            Console.WriteLine($"{this.playerName} attacked {target.mobName} for {damage} damage!");
        }
        else
        {
            Console.WriteLine($"{target.mobName} is already dead!");
        }
    }
}