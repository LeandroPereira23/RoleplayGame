using Program;
namespace LibraryTests;


public class MagicBookTest
{
    private MagicBook magicBook;
    private Spell spell;
    private Spell spell2;
    private Spell spell3;
    private Spell spell4;
    private Spell spell5;
    
    [SetUp] 
    public void Setup()
    {
        magicBook = new MagicBook();
        spell = new AttackSpell(100, "AtSpell");
        spell2 = new DefenseSpell(100, "DefSpell");
        spell3 = new AttackSpell(100, "spell3");
        spell4 = new AttackSpell(100, "spell4");
        spell5 = new AttackSpell(100, "spell5");
    }

    [Test]
    public void TestAddSpell()
    {
        magicBook.AddSpell(spell, spell2);
        Assert.AreEqual(2, magicBook.Spells.Count);
    }
    
    [Test]
    public void TestAddSpellDamage()
    {
        magicBook.AddSpell(spell, spell2);
        Assert.AreEqual(2.2f, magicBook.Damage);
    }
    [Test]
    public void TestAddSpellProtection()
    {
        magicBook.AddSpell(spell, spell2);
        Assert.AreEqual(2.2f, magicBook.Protection);
    }
    
    [Test]
    public void TestRemoveSpell()
    {
        magicBook.AddSpell(spell, spell2);
        magicBook.RemoveSpell(spell2);
        Assert.AreEqual(1, magicBook.Spells.Count);
    }
    
    [Test]
    public void TestRemoveSpellDamage()
    {
        magicBook.AddSpell(spell, spell2);
        magicBook.RemoveSpell(spell2);
        Assert.AreEqual(2.1f, magicBook.Damage);
    }
    
    [Test]
    public void TestRemoveSpellProtection()
    {
        magicBook.AddSpell(spell, spell2);
        magicBook.RemoveSpell(spell2);
        Assert.AreEqual(2.1f, magicBook.Protection);
        
    }
}