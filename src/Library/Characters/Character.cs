using Library.Items;

namespace Program;

public abstract class Character<TItem>
{
    protected float hp;
    protected float maxHp;
    protected float damage;
    protected float defense;
    public Inventory<TItem> inventory { get; }

    public Character(float maxHp, float damage, float defense)
    {
        inventory = new Inventory<TItem>(2);
        hp = maxHp;
        this.maxHp = maxHp;
        this.defense = defense;
        this.damage = damage;
    }

    public float Hp
    {
        get { return hp; }
    }

    public float Attack(Character<TItem> character)
    {
        float dmg = AttackValue * (1 - character.DefenseValue / 100);

        character.hp = character.hp > dmg 
            ? character.hp - dmg 
            : 0;
        
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
            MagicBook magicBook = null;
            float magicBookDamage = 0;
            float attackValue = damage;
            
            for (int i = 0; i < inventory.InventoryLength; i++)
            {
                IAttack item = inventory.Items[i] as IAttack;
                if (item != null)
                {
                    attackValue += item.Damage;
                }
                
                MagicBook book = inventory.Items[i] as MagicBook;
                if (book != null && book.Damage > magicBookDamage)
                {
                    magicBookDamage = book.Damage;
                    magicBook = book;
                }
            }
            
            if (magicBook != null)
            {
                attackValue *= magicBook.Damage;
            }

            return attackValue;
        }
    }

    public float DefenseValue
    {
        get
        {
            MagicBook magicBook = null;
            float magicBookProtection = 0;
            float defenseValue = defense;
            
            for (int i = 0; i < inventory.InventoryLength; i++)
            {
                IDefense item = inventory.Items[i] as IDefense;
                if (item != null)
                {
                    defenseValue += item.Protection;
                }

                MagicBook book = inventory.Items[i] as MagicBook;
                if (book != null && book.Protection > magicBookProtection)
                {
                    magicBookProtection = book.Protection;
                    magicBook = book;
                }
            }
            
            if (magicBook != null)
            {
                defenseValue *= magicBookProtection;
            }

            return defenseValue;
        }
    }
}