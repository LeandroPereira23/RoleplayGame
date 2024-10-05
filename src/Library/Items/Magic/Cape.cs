namespace Program;
public class Cape : IMagicItem, IDefense
{
    public float Protection { get; }

    public Cape(float protection)
    {
        Protection = protection;
    }
}