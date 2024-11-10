namespace Program.Enemies;

public class Enemy<TItem> : Character<TItem>
{
    public Enemy(float maxHp, float damage, float defense) 
        : base(maxHp, damage, defense)
    {
        
    }
}