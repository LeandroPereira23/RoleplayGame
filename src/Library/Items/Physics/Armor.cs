namespace Program;
public class Armor : PhysicItem, IDefense
{
    public float Protection { get; }

    public Armor(float protection)
    {
        Protection = protection;
    }
}