namespace Program;

public abstract class Hero<TItem> : Character<TItem>
{
    public Hero(float maxHp, float damage, float defense) 
        : base(maxHp, damage, defense)
    {
        
    }
}