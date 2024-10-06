using Program;

namespace LibraryTests;

public class WizardTest
{
    private Wizard wizzard;
    private Wizard evilWizard;
    private MagicBook book;
    private MagicStaff magicStaff;
    private Spell fuego2;
    [SetUp]
    public void Setup()
    {
        wizzard = new Wizard(100, 10, 10);
        evilWizard = new Wizard(200, 5, 50);
        book = new MagicBook();
        
        fuego2 = new AttackSpell(200, "Fuego2");
        Spell rayo = new AttackSpell(100, "Rayo");
        Spell fuego = new AttackSpell(50, "Fuego");
        Spell fuego3 = new AttackSpell(150, "Fuego3");
        Spell fuego4 = new AttackSpell(20, "Fuego4");
        book.AddSpell(rayo, fuego, fuego2, fuego3, fuego4);
        magicStaff = new MagicStaff(10, 10, fuego2);
    }

    [Test]
    public void TestAttack()
    {
        wizzard.inventory.AddItem(book);
        wizzard.Attack(evilWizard);
        
        Assert.AreEqual(166, Math.Round(evilWizard.Hp));   // Al hacer las cuentas a mano da 166
    }
    
    [Test]
    public void TestAttack2()
    {
        wizzard.inventory.AddItem(magicStaff);
        wizzard.Attack(evilWizard);
        
        Assert.AreEqual(50, Math.Round(evilWizard.Hp));   // Al hacer las cuentas a mano da 166
    }
    
    [Test]
    public void TestHeal()
    {
        wizzard.inventory.AddItem(magicStaff);
        wizzard.Attack(evilWizard);
        
        evilWizard.Heal();
        
        Assert.AreEqual(200, evilWizard.Hp);
    }
    
    [Test]
    public void TestHealDead()
    {
        MagicStaff DeadlyStaff = new MagicStaff(100, 100, fuego2);
        wizzard.inventory.AddItem(DeadlyStaff);
        wizzard.Attack(evilWizard);
        
        evilWizard.Heal();
        
        Assert.AreEqual(0, evilWizard.Hp);
    }
}