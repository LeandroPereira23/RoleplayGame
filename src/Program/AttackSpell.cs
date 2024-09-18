public class AttackSpell : Spell
{
    private float damageBoost;

    public float DamageBoost
    {
        get { return damageBoost; }
    }

    public AttackSpell(float damageBoost, string name) : base(name)
    {
        this.damageBoost = damageBoost;
    }
}