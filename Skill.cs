namespace newgame;

public class Skill
{
    public string? skillName = "";
    public int skillDamage;
    public int skillLevel; //based on level of the player so all skill will be level 1

    public Skill(string? skillName, int skillDamage, int skillLevel)
    {
        this.skillName = skillName;
        this.skillDamage = skillDamage;
        this.skillLevel = skillLevel;
    }

    //-----------------------------------------------------------------------------------------------------
    //human skills
    public static Skill SwordandDaggerMastery = new Skill("Sword and Dagger Mastery", 10, 1);
    public static Skill AimedBlow = new Skill("Aimed Blow", 10, 1);
    public static Skill PhysicalBlow = new Skill("Physical Blow", 10, 1);
    public static Skill TauntRoar = new Skill("Taunt Roar", 10, 1);
    public static Skill Rush = new Skill("Rush", 10, 1);
    public static Skill WarCry = new Skill("War Cry", 10, 1);
    public static Skill CrazyStrength = new Skill("Crazy Strength", 10, 1);
    public static Skill CrazySwing = new Skill("Crazy Swing", 10, 1);
    public static Skill BlueDrain = new Skill("Blue Drain", 10, 1);
    public static Skill OrderSwing = new Skill("Order Swing", 10, 1);
    public static Skill HeavyWeapon = new Skill("Heavy Weapon", 10, 1);
    public static Skill CriticalAura = new Skill("Critical Aura", 10, 1);
    public static Skill StraightRepulse = new Skill("Straight Repulse", 10, 1);
    public static Skill RohasBlessing = new Skill("Rohas Blessing", 10, 1);
    public static Skill KnightSymbol = new Skill("Knight Symbol", 10, 1);
    public static Skill StoneSkin = new Skill("Stone Skin", 10, 1);
    //-----------------------------------------------------------------------------------------------------

    //-----------------------------------------------------------------------------------------------------
    //elf skills
    public static Skill BlueFountain = new Skill("Blue Fountain", 10, 1);
    public static Skill Incarnation = new Skill("Incarnation", 10, 1);
    public static Skill MagicalBlow = new Skill("Magical Blow", 10, 1);
    public static Skill GrayMask = new Skill("Gray Mask", 10, 1);
    public static Skill Euphoria = new Skill("Euphoria", 10, 1);
    public static Skill Erase = new Skill("Erase", 10, 1);
    public static Skill BluntMastery = new Skill("Blunt Mastery", 10, 1);
    public static Skill GroupEuphoria = new Skill("Group Euphoria", 10, 1);
    public static Skill Reflection = new Skill("Reflection", 10, 1);
    public static Skill MareasHammer = new Skill("Mareas Hammer", 10, 1);
    public static Skill ManaShield = new Skill("Mana Shield", 10, 1);
    public static Skill Vanishment = new Skill("Vanishment", 10, 1);
    public static Skill WhiteCurse = new Skill("White Curse", 10, 1);
    public static Skill FinalAttempt = new Skill("Final Attempt", 10, 1);
    public static Skill MareasAnger = new Skill("Mareas Anger", 10, 1);
    //-----------------------------------------------------------------------------------------------------

}