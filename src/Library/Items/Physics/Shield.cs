namespace Program;

public class Shield: IPhysicItem, IAttack, IDefense
{
    public float Damage { get; }
    public float Protection { get; }

    public Shield(float damage, float protection)
    {
        Damage = damage;
        Protection = protection;
    }
}