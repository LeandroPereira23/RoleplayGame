namespace Program.Enemies;

public abstract class Enemy : Character
{
    public Enemy(float maxHp, float damage, float defense, int vp) 
        : base(maxHp, damage, defense)
    {
        Vp = vp;
    }
}