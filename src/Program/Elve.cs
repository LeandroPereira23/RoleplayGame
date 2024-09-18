namespace Program;

public class Elve : Character
{
    private Spear spear;
    private Armor armor;
    public Elve(float hp, float maxHp, float damage, float defense)
        : base(hp, maxHp, damage, defense) {}

    public void AddSpear(Spear spear)
    {
        this.spear = spear;
    }

    public void RemoveSpear()
    {
        spear = null;
    }

    public void AddArmor(Armor armor)
    {
        this.armor = armor;
    }

    public void RemoveArmor()
    {
        armor = null;
    }
}