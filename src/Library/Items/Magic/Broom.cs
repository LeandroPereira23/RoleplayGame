namespace Program;
public class Broom : Defense
{
    public Broom(float protection) : base(protection)
    {
        
    }

    public float Protection
    {
        get { return protection; }
    }
}