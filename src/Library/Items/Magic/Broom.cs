namespace Program;
public class Broom : IMagicItem, IDefense, IAttack
{
    public float Protection { get; }
    public float Damage { get; }

    public Broom(float protection, float attack)
    {
        Protection = protection;
        Damage = attack;
    }
}