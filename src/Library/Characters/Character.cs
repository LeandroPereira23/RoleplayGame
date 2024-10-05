namespace Program;

public abstract class Character<TItem>
{
    protected TItem[] items;
    protected float hp;
    protected float maxHp;
    protected float damage;
    protected float defense;
    private int inventoryLength = 2;

    public Character(float maxHp, float damage, float defense)
    {
        items = new TItem[inventoryLength];
        hp = maxHp;
        this.maxHp = maxHp;
        this.defense = defense;
        this.damage = damage;
    }

    public float Hp
    {
        get { return hp; }
    }

    private int SearchItemInItems(TItem item)
    {
        return Array.IndexOf(items, item);
    }

    public void AddItem(TItem item)
    {
        if (ItemAlreadyExists(item)) return;

        int indexSlotAvailable = GetIndexSlotAvailable();
        if (indexSlotAvailable != -1)
        {
            AssignItemToSlot(indexSlotAvailable, item);
        }
        else
        {
            // Reemplazar el peor item
        }
    }

    private bool ItemAlreadyExists(TItem item)
    {
        return Array.IndexOf(items, item) != -1;
    }

    private int GetIndexSlotAvailable()
    {
        for (int i = 0; i < inventoryLength; i++)
        {
            if (IsSlotAvailable(i)) return i;
        }
        
        return -1;
    }

    private bool IsSlotAvailable(int index)
    {
        return items[index] == null;
    }
    
    private void AssignItemToSlot(int index, TItem item)
    {
        items[index] = item;
    }
    
    public void RemoveItem(TItem item)
    {
        items[SearchItemInItems(item)] = default(TItem);
    }

    public float Attack(Character<TItem> character)
    {
        float dmg = AttackValue * (1 - character.DefenseValue / 100);
        if (character.hp > dmg)
        {
            character.hp -= dmg;
        }
        else
        {
            character.hp = 0;
        }
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
        get 
        { 
            IAttack item = items[0] as IAttack;
            if (item != null)
            {
                return item.Damage + damage;
            }

            return damage;
        }
    }

    public float DefenseValue
    {
        get
        {
            float defensa = defense;
            IDefense item = items[0] as IDefense;
            if (item != null)
            {
                defensa += item.Protection ;
            }
            IDefense item2 = items[1] as IDefense;
            if (item2 != null)
            {
                defensa += item2.Protection ;
            }

            return defensa;
        }
    }
}