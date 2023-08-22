using System.Text;

namespace newgame;
public class AdClass
{
    public string? adventurerClass;
    public int playerHp;
    public int playerMp;
    public int physicalAttack;
    public int magicAttack;
    public int defense;
    public static List<AdClass> AdventurClass = new List<AdClass>();

    public AdClass(string adventurerClass, int playerHp, int playerMp, int physicalAttack, int magicAttack, int defense)
    {
        this.adventurerClass = adventurerClass;
        this.playerHp = playerHp;
        this.playerMp = playerMp;
        this.physicalAttack = physicalAttack;
        this.magicAttack = magicAttack;
        this.defense = defense;
        AdventurClass.Add(this);
    }
    //hero, bandit, astrologer, warrior, prisoner, confessor, wretch, vagabond, prophet, samurai (elden ring character classes)
    public static AdClass Hero = new AdClass("Hero", 10, 10, 5, 0, 10);
    public static AdClass Bandit = new AdClass("Bandit", 10, 5, 5, 0, 5);
    public static AdClass Astrologer = new AdClass("Astrologer", 10, 15, 4, 10, 9);
    public static AdClass Warrior = new AdClass("Warrior", 10, 5, 5, 0, 10);
    public static AdClass Prisoner = new AdClass("Prisoner", 8, 8, 5, 0, 9);
    public static AdClass Confessor = new AdClass("Confessor", 10, 10, 5, 10, 9);
    public static AdClass Wretch = new AdClass("Wretch", 10, 5, 5, 0, 9);
    public static AdClass Vagabond = new AdClass("Vagabond", 10, 5, 6, 0, 10);
    public static AdClass Prophet = new AdClass("Prophet", 10, 10, 5, 5, 10);
    public static AdClass Samurai = new AdClass("Samurai", 10, 10, 10, 0, 10);

    public static void PrintStats()
    {
        StringBuilder str = new StringBuilder();
        str.AppendLine("-----------------------------------------------------");

        for (int i = 0; i < AdventurClass.Count; i++)
        {
            str.AppendLine($"\n[1] {AdventurClass[i].adventurerClass}")
            .AppendLine($"Hp: {AdventurClass[i].playerHp}")
            .AppendLine($"Mp: {AdventurClass[i].playerMp}")
            .AppendLine($"Physical Attack: {AdventurClass[i].physicalAttack}")
            .AppendLine($"Magic Attack: {AdventurClass[i].magicAttack}")
            .AppendLine($"Defense: {AdventurClass[i].defense}");
        }
        Console.WriteLine(str.ToString());
    }
}