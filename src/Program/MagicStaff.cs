namespace Program;

public class MagicStaff: Attack
{
    public MagicStaff(float damage, AttackSpell attackSpell) : base(damage)
    {
        _attackSpell = attackSpell;
    }

    private AttackSpell _attackSpell;
    
    public float DamageBoost
    {
        get { return _attackSpell.DamageBoost ; }
    }

}