namespace newgame;

public class Skill
{
    public string? skillName = "";
    public int skillId;
    public int skillDamage;
    public int skillLevel; //based on level of the player so all skill will be level 1

    public Skill(string? skillName, int skillId, int skillDamage, int skillLevel)
    {
        this.skillName = skillName;
        this.skillId = skillId;
        this.skillDamage = skillDamage;
    }


}