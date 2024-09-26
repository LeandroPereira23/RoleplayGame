namespace Program;
public class Character<TItem>
{
    protected TItem[] items;
    protected float hp;
    protected float maxHp;
    protected float damage;
    protected float defense;
    
    public Character(float hp, float maxHp, float damage, float defense)
    {
        items = new TItem[2];
        this.hp = hp;
        this.maxHp = maxHp;
        this.defense = defense;
        this.damage = damage;
    }

    private int searchItemInItems(IItem item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] != null && items[i].Equals(item))
            {
                return i;
            }
        }

        return -1;
    }

    public void AddItem(IItem item)
    {
        int itemIndex = searchItemInItems(item);
        if (itemIndex == -1)
        {
            // -----------------> FALTA IMPLEMENTAR
        }
        
    }
    
    public void RemoveItem(TItem item)
    {
        // -----------------> FALTA IMPLEMENTAR
    }

    public float Attack(Character<IItem> character)
    {
        character.hp -= damage * (1 - character.defense / 100);
        return character.hp;
    }
    
    public bool isDead()
    {
        return hp <= 0;
    }

    public void Heal()
    {
        if (isDead()) return;

        hp = maxHp;
    }
    
    public float AttackValue
    {
        get { return damage; }
    }

    public float DefenseValue
    {
        get { return defense; }
    }
}