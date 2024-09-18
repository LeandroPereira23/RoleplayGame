public class MagicBook
{
    private List<Spell> spells;
    private float knowledge;

    public MagicBook()
    {
        spells = new List<Spell>();
        knowledge = 0;
    }

    public void AddSpell(Spell spell)
    {
        if (!spells.Contains(spell))
        {
            spells.Add(spell);
            knowledge += 0.1f;
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