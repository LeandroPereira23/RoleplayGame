namespace Program;
public abstract class Character<TItem>
{
    protected TItem[] items;
    protected float hp;
    protected float maxHp;
    protected float damage;
    protected float defense;
    
    public Character(float maxHp, float damage, float defense)
    {
        items = new TItem[2];
        hp = maxHp;
        this.maxHp = maxHp;
        this.defense = defense;
        this.damage = damage;
    }

    public float Hp
    {
        get { return hp; }
    }
    
    private int searchItemInItems(TItem item)
    {
        return Array.IndexOf(items, item);
    }

    public void AddItem(TItem item)
    {
        int itemIndex = searchItemInItems(item);
        if (itemIndex != -1)
        {
            items[itemIndex] = item;
            return;
        }
        
        Type[] itemType = item.GetType().GetInterfaces();
        Console.WriteLine("ITEM");
        foreach (var type in itemType)
        {
            Console.WriteLine(type);
        }
        Console.WriteLine(itemType);
        if (items[0] != null)
        {
            Type[] inventoryTipes1 = items[0].GetType().GetInterfaces();
            Console.WriteLine("INVENTORY 1");
            foreach (var type in inventoryTipes1)
            {
                Console.WriteLine(type);
            }

            if (itemType == inventoryTipes1)
            {
                items[0] = item;
            }
        }
        else if (items[1] != null)
        {
            Type[] inventoryTipes2 = items[1].GetType().GetInterfaces();
            if (itemType == inventoryTipes2)
            {
                items[1] = item;
            }
            else
            {
                items[0] = item; //FALTA CAMBIAR
            }
        }
        else
        {
            items[0] = item;
        }
    }
    
    public void RemoveItem(TItem item)
    {
        items[searchItemInItems(item)] = default(TItem);
    }

    public float Attack(Character<TItem> character)
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