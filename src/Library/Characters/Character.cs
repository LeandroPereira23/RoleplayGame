using Library.Items;

namespace Program;

public abstract class Character<TItem>
{
    protected float hp;
    protected float maxHp;
    protected float damage;
    protected float defense;
    public int Vp { get; protected set; }
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
    
    public float AttackValue
    {
        get
        {
            IHasSpell auxHasSpell = null;
            float magicBookDamage = 0;
            float attackValue = damage;
            
            for (int i = 0; i < inventory.InventoryLength; i++)
            {
                IAttack item = inventory.Items[i] as IAttack;
                if (item != null)
                {
                    attackValue += item.Damage;
                }
                
                IHasSpell hasSpell = inventory.Items[i] as IHasSpell;
                if (hasSpell != null && hasSpell.Damage > magicBookDamage)
                {
                    magicBookDamage = hasSpell.Damage;
                    auxHasSpell = hasSpell;
                }
            }
            
            if (auxHasSpell != null)
            {
                attackValue *= auxHasSpell.Damage;
            }

            return attackValue;
        }
    }

    public float DefenseValue
    {
        get
        {
            IHasSpell auxHasSpell = null;
            float magicBookProtection = 0;
            float defenseValue = defense;
            
            for (int i = 0; i < inventory.InventoryLength; i++)
            {
                IDefense item = inventory.Items[i] as IDefense;
                if (item != null)
                {
                    defenseValue += item.Protection;
                }

                IHasSpell hasSpell = inventory.Items[i] as IHasSpell;
                if (hasSpell != null && hasSpell.Protection > magicBookProtection)
                {
                    magicBookProtection = hasSpell.Protection;
                    auxHasSpell = hasSpell;
                }
            }
            
            if (auxHasSpell != null)
            {
                defenseValue *= magicBookProtection;
            }

            return defenseValue;
        }
    }
    
    private bool IsDead()
    {
        return hp <= 0;
    }
    
    public virtual float Attack(Character<TItem> character)
    {
        float dmg = AttackValue * (1 - character.DefenseValue / 100);

        character.hp = character.hp > dmg 
            ? character.hp - dmg 
            : 0;
        
        return character.hp;
    }
    
    public void Heal()
    {
        if (IsDead()) return;

        hp = maxHp;
    }
}