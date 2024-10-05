namespace Program;

public class DefenseSpell : Spell
{
    private float protectionBoost;

    public float ProtectionBoost
    {
        get { return protectionBoost; }
    }

    public DefenseSpell(float protectionBoost, string name) : base(name)
    {
        this.protectionBoost = protectionBoost;
    }
}