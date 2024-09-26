namespace Program;
public class Knife : PhysicItem, IAttack
{
    public float Damage { get; }

    public Knife(float damage)
    {
        Damage = damage;
    }
}