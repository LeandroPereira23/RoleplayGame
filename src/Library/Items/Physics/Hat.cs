namespace Program;
public class Hat : PhysicItem, IDefense
{
    public float Protection { get; }

    public Hat(float protection)
    {
        Protection = protection;
    }
}