namespace Program;

public abstract class Hero : Character
{
    protected Hero(float maxHp, float damage, float defense) 
        : base(maxHp, damage, defense)
    {
        Vp = 0;
    }
    
}