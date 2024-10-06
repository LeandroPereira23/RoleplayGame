namespace Program;

public class MagicStaff : IMagicItem, IHasSpell
{
    private Spell spell;
    
    private float damage;
    public float Damage
    {
        get
        {
            AttackSpell attackSpell = spell as AttackSpell;

            return attackSpell != null 
                ?  damage * (1 + attackSpell.DamageBoost / 100) 
                : 1;
        }
        private set { damage = value; }
    }
    
    private float protection;
    public float Protection
    {

        get
        {
            DefenseSpell defenseSpell = spell as DefenseSpell;

            return defenseSpell != null 
                ?  protection * (1 + defenseSpell.ProtectionBoost / 100) 
                : 1;
        }
        private set { protection = value; }
    }

    public MagicStaff(float damage, float protection, Spell spell)
    {
        this.damage = damage;
        this.protection = protection;
        this.spell = spell;
    }
}