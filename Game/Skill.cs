using System.Diagnostics.Contracts;

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

    //giant skills
    public static Skill PolearmMastery = new Skill("Polearm Mastery", 10, 1);
    public static Skill CriminalMind = new Skill("Criminal Mind", 10, 1);
    public static Skill SnareAxe = new Skill("Snare Axe", 10, 1);
    public static Skill Berserk = new Skill("Berserk", 10, 1);
    public static Skill Fortunate = new Skill("Fortunate", 10, 1);
    public static Skill RootingAxe = new Skill("Rooting Axe", 10, 1);
    public static Skill Sweep = new Skill("Sweep", 10, 1);
    public static Skill Vigilance = new Skill("Vigilance", 10, 1);
    public static Skill Precision = new Skill("Precision", 10, 1);
    public static Skill Jolt = new Skill("Jolt", 10, 1);
    public static Skill WildBlood = new Skill("Wild Blood", 10, 1);
    public static Skill LowBlow = new Skill("Low Blow", 10, 1);
    public static Skill Cleave = new Skill("Cleave", 10, 1);
    public static Skill CallToBattle = new Skill("Call to Battle", 10, 1);
    public static Skill PremiumStrike = new Skill("Premium Strike", 10, 1);
    public static Skill MagnitudeSwing = new Skill("Magnitude Swing", 10, 1);
    public static Skill Retaliate = new Skill("Retaliate", 10, 1);
    public static Skill IceWillyWilly = new Skill("Ice Willywilly", 10, 1);
    //-----------------------------------------------------------------------------------------------------

    //half elf skills
    public static Skill Blazing = new Skill("Blazing", 10, 1);
    public static Skill Frozen = new Skill("Frozen", 10, 1);
    public static Skill Darkness = new Skill("Darkness", 10, 1);
    public static Skill Divinity = new Skill("Divinity", 10, 1);
    public static Skill PsychicShot = new Skill("Psychic Shot", 10, 1);
    public static Skill LongShot = new Skill("Long Shot", 10, 1);
    public static Skill EnchantedArrow = new Skill("Enchanted Arrow", 10, 1);
    public static Skill FaintPierce = new Skill("Faint Pierce", 10, 1);
    public static Skill BleedingShot = new Skill("Bleeding Shot", 10, 1);
    public static Skill Agility = new Skill("Agility", 10, 1);
    public static Skill BrandishKick = new Skill("Brandish Kick", 10, 1);
    public static Skill Ensnare = new Skill("Ensnare", 10, 1);
    public static Skill FeebleArrow = new Skill("Feeble Arrow", 10, 1);
    public static Skill Fatal = new Skill("Fatal", 10, 1);
    public static Skill Sprint = new Skill("Sprint", 10, 1);
    public static Skill Evade = new Skill("Evade", 10, 1);
    public static Skill PiercingRoot = new Skill("Piercing Root", 10, 1);
    public static Skill DoubleStrike = new Skill("Double Strike", 10, 1);
    //-----------------------------------------------------------------------------------------------------

    //dhan skills
    public static Skill Awareness = new Skill("Awareness", 10, 1);
    public static Skill SluggsishAttack = new Skill("Sluggish Attack", 10, 1);
    public static Skill KatarMastery = new Skill("Katar Mastery", 10, 1);
    public static Skill HideSpirit = new Skill("Hide Spirit", 10, 1);
    public static Skill Detect = new Skill("Detect", 10, 1);
    public static Skill TrackingTreasure = new Skill("Tracking Treasure", 10, 1);
    public static Skill RuinTrap = new Skill("Ruin Trap", 10, 1);
    public static Skill SealingSquare = new Skill("Sealing Square", 10, 1);
    public static Skill HealingTrap = new Skill("Healing Trap", 10, 1);
    public static Skill HeartTrap = new Skill("Heart Trap", 10, 1);
    public static Skill Scarecrow = new Skill("Scarecrow", 10, 1);
    public static Skill TimerTrap = new Skill("Timer trap", 10, 1);
    public static Skill SecretHide = new Skill("Secret Hide", 10, 1);
    public static Skill Transformation = new Skill("Transformation", 10, 1);
    public static Skill PremiumSlash = new Skill("Preium Slash", 10, 1);
    public static Skill RoyalMask = new Skill("Royal Mask", 10, 1);
    public static Skill ExperienceMambo = new Skill("Experience Mambo", 10, 1);
    public static Skill Demolition = new Skill("Demolition", 10, 1);
    public static Skill BlackMantle = new Skill("Black Mantle", 10, 1);
    //-----------------------------------------------------------------------------------------------------

    //darkelf skills
    public static Skill StaffMastery = new Skill("Staff Mastery", 10, 1);
    public static Skill AddTempter = new Skill("Add Temper", 10, 1);
    public static Skill PsycheShield = new Skill("PsycheShield", 10, 1);
    public static Skill ImperviousShield = new Skill("Impervious Shield", 10, 1);
    public static Skill Reveal = new Skill("Reveal", 10, 1);
    public static Skill MagicPiercing = new Skill("Magic Piercing", 10, 1);
    public static Skill CountBlow = new Skill("Count Blow", 10, 1);
    public static Skill Weakness = new Skill("Weakness", 10, 1);
    public static Skill MultiMagicArrow = new Skill("Multi Magic Arrow", 10, 1);
    public static Skill GroupMortalImmune = new Skill("Group Moral Immune", 10, 1);
    public static Skill AreaSpell = new Skill("Area Spell", 10, 1);
    public static Skill RingBurst = new Skill("Ring Burst", 10, 1);
    public static Skill MirrorBurst = new Skill("Mirror Burst", 10, 1);
    public static Skill StrikeBash = new Skill("Strike Bash", 10, 1);
    public static Skill KillingTime = new Skill("Killing Time", 10, 1);
    public static Skill EternalDarkness = new Skill("Eternal Darkness", 10, 1);
    public static Skill Reraise = new Skill("Reraise", 10, 1);
    public static Skill EraseAbility = new Skill("Erase Ability", 10, 1);
    public static Skill Destroy = new Skill("Destroy", 10, 1);
    //-----------------------------------------------------------------------------------------------------

    //Dekan
    public static Skill Karma = new Skill("Karma", 10, 1);
    public static Skill ZhenMastery = new Skill("Zhen Mastery", 10, 1);
    public static Skill BlueDefense = new Skill("Blue Defense", 10, 1);
    public static Skill CriticalImmunity = new Skill("Critical Immunity", 10, 1);
    public static Skill Extricate = new Skill("Extricate", 10, 1);
    public static Skill Mist = new Skill("Mist", 10, 1);
    public static Skill Evolve = new Skill("Evolvea", 10, 1);
    public static Skill Suction = new Skill("Suction", 10, 1);
    public static Skill ForceLock = new Skill("Force Lock", 10, 1);
    public static Skill FastShadow = new Skill("Fast Shadow", 10, 1);
    public static Skill SuddenDeath = new Skill("Sudden Death", 10, 1);
    public static Skill Penetrate = new Skill("Penetrate", 10, 1);
    public static Skill SoulDivider = new Skill("Soul Divider", 10, 1);
    public static Skill BloodyEffect = new Skill("Bloody Effect", 10, 1);
    public static Skill ToxicPotion = new Skill("Toxic Potion", 10, 1);
    public static Skill DarkSpell = new Skill("Dark Spell", 10, 1);
    public static Skill Lunacy = new Skill("Lunacy", 10, 1);
    public static Skill DragonNail = new Skill("Dragon Nail", 10, 1);
    //-----------------------------------------------------------------------------------------------------

    //Trinity
    public static Skill ArrendalMastery = new Skill("Arrendal Mastery", 10, 1);
    public static Skill WoundOfRestriction = new Skill("Wound of Restriction", 10, 1);
    public static Skill TrinityForce = new Skill("Trinity Force", 10, 1);
    public static Skill ThornsWhip = new Skill("Thorns Whip", 10, 1);
    public static Skill PhantomSpirit = new Skill("Phantom Spirit", 10, 1);
    public static Skill PenetratingDarkness = new Skill("Penetrating Darkness", 10, 1);
    public static Skill DarkAssimilation = new Skill("Dark Assimilation", 10, 1);
    public static Skill DistortionClawDimension = new Skill("Distortion Claw - Dimension", 10, 1);
    public static Skill WindyChain = new Skill("Windy Chain", 10, 1);
    public static Skill SpiritConcentration = new Skill("Spirit Concentration", 10, 1);
    public static Skill DistortionClawReverse = new Skill("Distortion Claw - Reverse", 10, 1);
    public static Skill ThunderStroke = new Skill("Thunderstroke", 10, 1);
    public static Skill RearBlast = new Skill("Rear Blast", 10, 1);
    public static Skill DistortionClawOblivion = new Skill("Distortion Claw - Oblivion", 10, 1);
    public static Skill Airburst = new Skill("Airburst", 10, 1);
    public static Skill DistortionClawGravity = new Skill("Distortion Claw - Gravity", 10, 1);
    public static Skill DimensionalCoat = new Skill("Dimensional Coat", 10, 1);
}