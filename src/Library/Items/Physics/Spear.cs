namespace Program;
public class Spear : IPhysicItem, IAttack
{
    public float Damage { get; }

    public Spear(float damage)
    {
        Damage = damage;
    }
}