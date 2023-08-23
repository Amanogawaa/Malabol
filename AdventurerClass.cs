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

    public AdventurerClass(string adventurerClass, int playerHp, int playerMp, int physicalAttack, int magicAttack, int defense)
    {
        this.adventurerClass = adventurerClass;
        this.playerHp = playerHp;
        this.playerMp = playerMp;
        this.physicalAttack = physicalAttack;
        this.magicAttack = magicAttack;
        this.defense = defense;
    }

    //Human, Elf, Half Elf, Dhan, Giant, Dark Elf, Dekan, Trinity
    public static List<AdventurerClass> AdventurerClassName = new List<AdventurerClass>
    {
        new AdventurerClass("Human", 100, 50, 20, 10, 15),
        new AdventurerClass("Elf", 80, 100, 15, 20, 10),
        new AdventurerClass("Half Elf", 90, 80, 18, 18, 12),
        new AdventurerClass("Dhan", 110, 40, 25, 5, 20),
        new AdventurerClass("Giant", 150, 20, 30, 2, 25),
        new AdventurerClass("Dark Elf", 85, 110, 17, 22, 8),
        new AdventurerClass("Dekan", 120, 60, 22, 8, 18),
        new AdventurerClass("Trinity", 95, 95, 19, 19, 14)
    };

    public static void PrintStats()
    {
        StringBuilder str = new StringBuilder();
        str.AppendLine("-----------------------------------------------------");

        for (int i = 0; i < AdventurerClassName.Count; i++)
        {
            str.AppendLine($"\n[1] {AdventurerClassName[i].adventurerClass}")
            .AppendLine($"Hp: {AdventurerClassName[i].playerHp}")
            .AppendLine($"Mp: {AdventurerClassName[i].playerMp}")
            .AppendLine($"Physical Attack: {AdventurerClassName[i].physicalAttack}")
            .AppendLine($"Magic Attack: {AdventurerClassName[i].magicAttack}")
            .AppendLine($"Defense: {AdventurerClassName[i].defense}");
        }
        Console.WriteLine(str.ToString());
    }
}