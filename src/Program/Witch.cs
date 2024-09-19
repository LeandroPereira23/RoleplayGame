namespace Program;
public class Witch : Character
{
    private MagicStaff magicStaff;
    private Broom broom;


    public Witch(float maxHp, float damage, float defense ) : base(maxHp, damage, defense)
    {
    
    }

    public void AddMagicStaff(MagicStaff magicStaff)
    {
        this.magicStaff = magicStaff;
        damage *=( magicStaff.DamageBoost +1);
    }

    public void RemoveMagicStaff ()
    {
        damage /= (magicStaff.DamageBoost + 1);
        magicStaff = null;
    }

    public void AddBroom(Broom broom)
    {
        this.broom = broom;
        defense += broom.Protection;
    }

    public void RemoveBroom()
    {
        defense -= broom.Protection;
        broom = null;
    }
    
}
