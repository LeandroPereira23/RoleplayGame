using Library.Characters.Enemies;
using Program;

namespace LibraryTests;

public class WitchTest
{
    private Witch witch;
    private Character evilWitch;
    private MagicBook book;
    private MagicStaff magicStaff;
    private Spell fuego2;
    [SetUp]
    public void Setup()
    {
        witch = new Witch(100, 10, 10, 1);
        evilWitch = new Witch(200, 5, 50, 2);
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
        witch.AddItem(book);
        witch.Attack(evilWitch);
        
        Assert.AreEqual(166, Math.Round(evilWitch.Hp));   // Al hacer las cuentas a mano da 166
    }
    
    [Test]
    public void TestAttack2()
    {
        witch.AddItem(magicStaff);
        witch.Attack(evilWitch);
        
        Assert.AreEqual(50, Math.Round(evilWitch.Hp));   // Al hacer las cuentas a mano da 166
    }
    
    [Test]
    public void TestHeal()
    {
        witch.AddItem(magicStaff);
        witch.Attack(evilWitch);
        
        evilWitch.Heal();
        
        Assert.AreEqual(200, evilWitch.Hp);
    }
    
    [Test]
    public void TestHealDead()
    {
        MagicStaff DeadlyStaff = new MagicStaff(10000, 100, fuego2);
        witch.AddItem(DeadlyStaff);
        witch.Attack(evilWitch);
        
        evilWitch.Heal();
        
        Assert.AreEqual(0, evilWitch.Hp);
    }
}