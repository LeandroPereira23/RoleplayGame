using Program;

namespace LibraryTests;

public class WitchTest
{
    private Witch witch;
    private Witch evilWitch;
    private MagicBook book;
    
    [SetUp]
    public void Setup()
    {
        witch = new Witch(100, 10, 10);
        evilWitch = new Witch(200, 5, 50);
        book = new MagicBook();
        Spell rayo = new AttackSpell(100, "Rayo");
        Spell fuego = new AttackSpell(50, "Fuego");
        Spell fuego2 = new AttackSpell(200, "Fuego2");
        Spell fuego3 = new AttackSpell(150, "Fuego3");
        Spell fuego4 = new AttackSpell(20, "Fuego4");
        book.AddSpell(rayo, fuego, fuego2, fuego3, fuego4);
    }

    [Test]
    public void TestAttack()
    {
        
        witch.inventory.AddItem(book);
        witch.Attack(evilWitch);
        
        Assert.AreEqual(45, Math.Round(evilWitch.Hp));   // Al hacer las cuentas a mano da 45
    }
}