public class Witch : Character
{
    private MagicStaff magicStaff;
    private Broom broom;
    
    public void AddMagicStaff(MagicStaff magicStaff)
    {
        this.magicStaff = magicStaff;
    }

    public void RemoveMagicStaff ()
    {
        magicStaff = null;
    }

    public void AddBroom(Broom broom)
    {
        this.broom = broom;
    }

    public void RemoveBroom()
    {
        broom = null;
    }
}
