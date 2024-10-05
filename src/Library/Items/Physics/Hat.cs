namespace Program;
public class Hat : IPhysicItem, IDefense
{
    public float Protection { get; }

    public Hat(float protection)
    {
        Protection = protection;
    }
}