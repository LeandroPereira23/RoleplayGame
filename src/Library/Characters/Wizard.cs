namespace Program;
public class Wizard : Character
{
    private MagicBook magicBook;
    private Cape cape;

    public Wizard(float hp, float maxHp, float damage, float defense)
        : base(hp, maxHp, damage, defense) { }

    public void AddMagicBook(MagicBook magicBook)
    {
        this.magicBook = magicBook;
    }

    public void RemoveMagicBook()
    {
        magicBook = null;
    }

    public void AddCape(Cape cape)
    {
        this.cape = cape;
    }

    public void RemoveCape()
    {
        cape = null;
    }
    
}