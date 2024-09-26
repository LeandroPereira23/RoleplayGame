namespace Program;

public class MagicStaff: MagicItem, IAttack
{
    private float damage;
    private AttackSpell attackSpell;
    public float Damage
    {
        get { return  damage * (1 + attackSpell.DamageBoost) ; }
        private set { damage = value; }
    }
    
    public MagicStaff(float damage, AttackSpell attackSpell)
    {
        Damage = damage;
        this.attackSpell = attackSpell;
    }
}