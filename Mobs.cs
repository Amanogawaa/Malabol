namespace newgame;

public class Mobs
{
    private string mobName = "";
    private int mobHp;
    private int mobAttackDamage;

    public Mobs(string mobName, int mobHp, int mobAttackDamage)
    {
        this.mobName = mobName;
        this.mobHp = mobHp;
        this.mobAttackDamage = mobAttackDamage;
    }

    public static List<Mobs> levelOne = new List<Mobs>
    {
        new Mobs("Varg", 250, 50),
        new Mobs("Akepion", 250, 50),
        new Mobs("Imp", 250, 50),
        new Mobs("Fungalbloom", 250, 50),
        new Mobs("Lycan", 250, 50),
        new Mobs("Pixie", 250, 50),
        new Mobs("Rigal", 250, 50),
        new Mobs("Mezard Chaos Elf", 250, 50),
        new Mobs("Sandeep", 250, 50),
        new Mobs("Waste Pillager", 250, 50),
    };

    public static void PrintEnemy()
    {
        Console.WriteLine("Enemy List");
        foreach (var enemy in levelOne)
        {
            Console.WriteLine(enemy.mobName);
        }
    }
}