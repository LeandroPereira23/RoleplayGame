namespace Program;
public class Cape : MagicItem, IDefense
{
    public float Protection { get; }

    public Cape(float protection)
    {
        Protection = protection;
    }
}