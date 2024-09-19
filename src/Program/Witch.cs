namespace Program;
public class Witch : Character  //Asignacion de herencia hijo : padre
{
    private MagicStaff magicStaff; //Asignacion de los Atributos
    private Broom broom;  //Asignacion de los Atributos


    public Witch(float hp, float maxHp, float damage, float defense ) : base(hp, maxHp, damage, defense) //Constructor
    {
    
    }

    public void AddMagicStaff(MagicStaff magicStaff)  //Metodos
    {
        this.magicStaff = magicStaff;
        damage *=( magicStaff.DamageBoost +1);
    }

    public void RemoveMagicStaff ()  //Metodo 
    {
        damage /= (magicStaff.DamageBoost + 1);
        magicStaff = null;
    }

    public void AddBroom(Broom broom) //Metodo
    {
        this.broom = broom;
        defense += broom.Protection;
    }

    public void RemoveBroom()  //Metodo 
    {
        defense -= broom.Protection;
        broom = null;
    }
    
}
