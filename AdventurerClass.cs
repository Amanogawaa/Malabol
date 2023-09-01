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
    public List<Skill> skills = new List<Skill>();
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

    public static AdventurerClass Human = new AdventurerClass("Human", 498, 197, 24, 10, 15)
    {
        skills =
        {
            Skill.AimedBlow, Skill.BlueDrain, Skill.CrazyStrength, Skill.CrazySwing, Skill.CriticalAura, Skill.HeavyWeapon, Skill.KnightSymbol,
            Skill.OrderSwing, Skill.OrderSwing, Skill.PhysicalBlow, Skill.RohasBlessing, Skill.Rush, Skill.StoneSkin, Skill.StraightRepulse,
            Skill.StraightRepulse, Skill.SwordandDaggerMastery, Skill.TauntRoar, Skill.WarCry
        }
    };
    public static AdventurerClass Elf = new AdventurerClass("Elf", 498, 197, 24, 20, 10)
    {
        skills =
        {
            Skill.BluntMastery, Skill.BlueFountain, Skill.Erase, Skill.Euphoria, Skill.FinalAttempt, Skill.GrayMask, Skill.GroupEuphoria,
            Skill.Incarnation, Skill.MagicalBlow, Skill.ManaShield, Skill.MareasAnger, Skill.MareasHammer, Skill.Reflection, Skill.Vanishment,
            Skill.WhiteCurse
        }
    };
    public static AdventurerClass HalfElf = new AdventurerClass("Half Elf", 498, 197, 24, 18, 12);
    public static AdventurerClass Dhan = new AdventurerClass("Dhan", 498, 197, 25, 5, 20);
    public static AdventurerClass Giant = new AdventurerClass("Giant", 498, 197, 25, 2, 25);
    public static AdventurerClass DarkElf = new AdventurerClass("Dark Elf", 498, 197, 23, 22, 8);
    public static AdventurerClass Dekan = new AdventurerClass("Dekan", 498, 197, 22, 8, 18);
    public static AdventurerClass Trinity = new AdventurerClass("Trinity", 498, 197, 24, 19, 14);
    public static AdventurerClass Aesir = new AdventurerClass("Aesir", 498, 197, 25, 20, 15);


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