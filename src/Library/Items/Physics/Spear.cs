namespace Program;
public class Spear : PhysicItem, IAttack
{
    public float Damage { get; }

    public Spear(float damage)
    {
        Damage = damage;
    }
}