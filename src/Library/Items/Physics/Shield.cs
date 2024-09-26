namespace Program;

public class Shield: PhysicItem, IAttack, IDefense
{
    public float Damage { get; }
    public float Protection { get; }

    public Shield(float damage, float protection)
    {
        Damage = damage;
        Protection = protection;
    }
}