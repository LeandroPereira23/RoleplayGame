public class Wizard
{
    private MagicBook magicBook;
    private Cape cape;

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