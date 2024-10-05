namespace Program;

public class MagicBook: MagicItem , IAttack , IDefense
{
    private List<Spell> spells = new List<Spell>();
    private float knowledge = 1;
    private float damage { get; set; } = 0;
    public float Damage
    {
        get { return damage * knowledge; } 
    }
    public float Protection { get; } = 0;
    
    public MagicBook()
    {
    }

    public void AddSpell(Spell spell)
    {
        if (!spells.Contains(spell))
        {
            spells.Add(spell);
            knowledge += 0.1f;
            
            AttackSpell atSpell = spell as AttackSpell;
            if (atSpell != null)
            {
                if (atSpell.DamageBoost > damage)
                {
                    damage = atSpell.DamageBoost;
                }
            }
        }
    }
    public void AddSpell(params Spell[] spells)
    {
        foreach (var spell in spells)
        {
            AddSpell(spell);
        }
    }
    public void RemoveSpell(Spell spell)
    {
        if (spells.Contains(spell))
        {
            spells.Remove(spell);
            knowledge -= 0.1f;
        }
    }
    
    
}