namespace newgame;

public class Mobs
{
    public string mobName = "";
    public int mobHp;
    public int mobAttackDamage;

    public static List<Mobs> LevelOne = new List<Mobs>();
    public Mobs(string mobName, int mobHp, int mobAttackDamage)
    {
        this.mobName = mobName;
        this.mobHp = mobHp;
        this.mobAttackDamage = mobAttackDamage;
        LevelOne.Add(this);
    }

    public static Mobs Varg = new Mobs("Varg", 250, 50);
    public static Mobs Akepion = new Mobs("Akepion", 250, 50);
    public static Mobs Imp = new Mobs("Imp", 250, 50);
    public static Mobs Fungalbloom = new Mobs("Fungalbloom", 250, 50);
    public static Mobs Lycan = new Mobs("Lycan", 250, 50);
    public static Mobs Pixie = new Mobs("Pixie", 250, 50);
    public static Mobs Rigal = new Mobs("Rigal", 250, 50);
    public static Mobs Mezard = new Mobs("Mezard Chaos Elf", 250, 50);
    public static Mobs Sandeep = new Mobs("Sandeep", 250, 50);
    public static Mobs Pillager = new Mobs("Waste Pillager", 250, 50);


    public void MobAttack(Player player)
    {
        player.playerHp -= mobAttackDamage;
        Console.WriteLine($"{this.mobName} attacked {player.playerName}! and dealt {mobAttackDamage} damage!");
    }
}