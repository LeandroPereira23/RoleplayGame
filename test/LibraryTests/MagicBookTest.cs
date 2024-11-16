using Program;
namespace LibraryTests;


public class MagicBookTest
{
    private MagicBook magicBook;
    private Spell attackSpell;
    private Spell defenseSpell;
    
    [SetUp] 
    public void Setup()
    {
        magicBook = new MagicBook();
        attackSpell = new AttackSpell(100, "AttackSpell");
        defenseSpell = new DefenseSpell(100, "DefenseSpell");
    }

    [Test]
    public void TestAddSpell()
    {
        magicBook.AddSpell(attackSpell, defenseSpell);
        Assert.AreEqual(2, magicBook.Spells.Count);
    }
    
    [Test]
    public void TestAddSpellDamage()
    {
        magicBook.AddSpell(attackSpell, defenseSpell);
        Assert.AreEqual(2.2f, magicBook.Damage);
    }
    
    [Test]
    public void TestAddSpellProtection()
    {
        magicBook.AddSpell(attackSpell, defenseSpell);
        Assert.AreEqual(2.2f, magicBook.Protection);
    }
    
    [Test]
    public void TestRemoveSpell()
    {
        magicBook.AddSpell(attackSpell, defenseSpell);
        magicBook.RemoveSpell(defenseSpell);
        Assert.AreEqual(1, magicBook.Spells.Count);
    }
    
    [Test]
    public void TestRemoveSpellDamage()
    {
        magicBook.AddSpell(attackSpell, defenseSpell);
        magicBook.RemoveSpell(defenseSpell);
        Assert.AreEqual(2.1f, magicBook.Damage);
    }
    
    [Test]
    public void TestRemoveSpellProtection()
    {
        magicBook.AddSpell(attackSpell, defenseSpell);
        magicBook.RemoveSpell(defenseSpell);
        Assert.AreEqual(2.1f, magicBook.Protection);
    }
}