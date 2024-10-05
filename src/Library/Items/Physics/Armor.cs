namespace Program;
public class Armor : IPhysicItem, IDefense
{
    public float Protection { get; }

    public Armor(float protection)
    {
        Protection = protection;
    }
}