namespace Program;
public class Knife : IPhysicItem, IAttack
{
    public float Damage { get; }

    public Knife(float damage)
    {
        Damage = damage;
    }
}