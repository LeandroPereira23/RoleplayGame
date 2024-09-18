namespace Program;

public class Hat : Defense
{
    
    public float Protection
    {
        get { return this.protection; }
    }

    public Hat(float protection):base(protection) { }
    
}