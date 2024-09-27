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

    private int searchItemInItems(TItem item)
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

    public void AddItem(TItem item)
    {
        int itemIndex = searchItemInItems(item);
        if (itemIndex == -1)
        {
            Type[] InventoryTipes1 = items[0].GetType().GetInterfaces();
            Type[] InventoryTipes2 = items[1].GetType().GetInterfaces();
            Type[] itemType = item.GetType().GetInterfaces();

            if (itemType == InventoryTipes1)
            {
                items[0] = item;
            }
            else
            {
                if (itemType == InventoryTipes2)
                {
                    items[1] = item;
                }
                else
                {
                    items[0] = item; //FALTA CAMBIAR
                }
            }
        }

    }
    
    public void RemoveItem(TItem item)
    {
        items[searchItemInItems(item)] = default(TItem);
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