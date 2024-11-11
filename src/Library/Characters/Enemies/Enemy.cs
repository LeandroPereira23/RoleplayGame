namespace Program.Enemies;

public abstract class Enemy : Character
{
    protected Enemy(float maxHp, float damage, float defense, int vp) 
        : base(maxHp, damage, defense)
    {
        Vp = vp;
    }
}