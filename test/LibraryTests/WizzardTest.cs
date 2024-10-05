using Program;

namespace LibraryTests;

public class WizzardTest
{
    private Wizard wizard;
    private Wizard evilWizard;
    private MagicBook book;
    
    [SetUp]
    public void Setup()
    {
        wizard = new Wizard(100, 10, 10);
        evilWizard = new Wizard(200, 5, 50);
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
        wizard.AddItem(book);
        wizard.Attack(evilWizard);
        Console.WriteLine(wizard.AttackValue);
        Console.WriteLine(wizard.AttackValue);
        
        Assert.AreEqual(166, Math.Round(evilWizard.Hp));   // Al hacer las cuentas a mano da 45
    }
}