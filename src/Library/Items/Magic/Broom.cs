namespace Program;
public class Broom : MagicItem, IDefense, IAttack
{
    public float Protection { get; }
    public float Damage { get; }

    public Broom(float protection, float attack)
    {
        Protection = protection;
        Damage = attack;
    }
}