using System.Text;

namespace newgame;
public class AdventurerClass
{
    public string? className;
    public int classHp;
    public int classMp;
    public int physicalAttack;
    public int magicAttack;
    public int defense;

    public static List<AdventurerClass> AdventurerClassList = new List<AdventurerClass>();
    public AdventurerClass(string classname, int classhp, int classmp, int physicalAttack, int magicAttack, int defense)
    {
        this.className = classname;
        this.classHp = classhp;
        this.classMp = classmp;
        this.physicalAttack = physicalAttack;
        this.magicAttack = magicAttack;
        this.defense = defense;
        AdventurerClassList.Add(this);
    }

    //Human, Elf, Half Elf, Dhan, Giant, Dark Elf, Dekan, Trinity

    public static AdventurerClass Human = new AdventurerClass("Human", 100, 50, 20, 10, 15);
    public static AdventurerClass Elf = new AdventurerClass("Elf", 80, 100, 15, 20, 10);
    public static AdventurerClass HalfElf = new AdventurerClass("Half Elf", 90, 80, 18, 18, 12);
    public static AdventurerClass Dhan = new AdventurerClass("Dhan", 110, 40, 25, 5, 20);
    public static AdventurerClass Giant = new AdventurerClass("Giant", 150, 20, 30, 2, 25);
    public static AdventurerClass DarkElf = new AdventurerClass("Dark Elf", 85, 110, 17, 22, 8);
    public static AdventurerClass Dekan = new AdventurerClass("Dekan", 120, 60, 22, 8, 18);
    public static AdventurerClass Trinity = new AdventurerClass("Trinity", 95, 95, 19, 19, 14);


    public static void PrintClass()
    {
        foreach (var item in AdventurerClassList)
        {
            Console.WriteLine(item.className);
        }
    }
    public static void PrintStats()
    {
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < AdventurerClassList.Count; i++)
        {
            str.Append("-----------------------------------------------------")
            .AppendLine($"\n[{i + 1}] {AdventurerClassList[i].className}")
            .AppendLine($"Hp: {AdventurerClassList[i].classHp}")
            .AppendLine($"Mp: {AdventurerClassList[i].classMp}")
            .AppendLine($"Physical Attack: {AdventurerClassList[i].physicalAttack}")
            .AppendLine($"Magic Attack: {AdventurerClassList[i].magicAttack}")
            .AppendLine($"Defense: {AdventurerClassList[i].defense}");
        }
        Console.WriteLine(str.ToString());
    }
}