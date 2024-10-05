namespace Program;

public class MagicBook: IMagicItem
{
    private List<Spell> spells = new();
    private float knowledge = 1;
    
    private float damage { get; set; }
    public float Damage
    {
        get { return damage + knowledge; } 
    }
    
    private float protection { get; set; }
    public float Protection
    {
        get { return protection + knowledge; } 
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
                damage += atSpell.DamageBoost / 100;
            }
            
            DefenseSpell dfSpell = spell as DefenseSpell;
            if (dfSpell != null)
            {
                protection += dfSpell.ProtectionBoost / 100;
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