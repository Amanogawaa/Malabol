using System.Text;

namespace newgame;
public class AdventurerClass
{
    public string? adventurerClass;
    public int playerHp;
    public int playerMp;
    public int physicalAttack;
    public int magicAttack;
    public int defense;
    public static List<AdventurerClass> AdventurClass = new List<AdventurerClass>();

    public AdventurerClass(string adventurerClass, int playerHp, int playerMp, int physicalAttack, int magicAttack, int defense)
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
    public static AdventurerClass Hero = new AdventurerClass("Hero", 10, 10, 5, 0, 10);
    public static AdventurerClass Bandit = new AdventurerClass("Bandit", 10, 5, 5, 0, 5);
    public static AdventurerClass Astrologer = new AdventurerClass("Astrologer", 10, 15, 4, 10, 9);
    public static AdventurerClass Warrior = new AdventurerClass("Warrior", 10, 5, 5, 0, 10);
    public static AdventurerClass Prisoner = new AdventurerClass("Prisoner", 8, 8, 5, 0, 9);
    public static AdventurerClass Confessor = new AdventurerClass("Confessor", 10, 10, 5, 10, 9);
    public static AdventurerClass Wretch = new AdventurerClass("Wretch", 10, 5, 5, 0, 9);
    public static AdventurerClass Vagabond = new AdventurerClass("Vagabond", 10, 5, 6, 0, 10);
    public static AdventurerClass Prophet = new AdventurerClass("Prophet", 10, 10, 5, 5, 10);
    public static AdventurerClass Samurai = new AdventurerClass("Samurai", 10, 10, 10, 0, 10);

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