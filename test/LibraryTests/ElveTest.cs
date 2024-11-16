using Program;

namespace LibraryTests;

public class ElveTest
{
    private Elve elve;
    private Elve elveEnemy;
    [SetUp]
    public void Setup()
    {
        elve = new Elve(100, 10, 10);
        elveEnemy = new Elve(200, 5, 50);
    }

    [Test]
    public void TestAttackKnife()
    { 
        elve.AddItem(new Knife(40));
        elve.Attack(elveEnemy);
        
        Assert.AreEqual(175, elveEnemy.Hp); // Al hacer las cuentas a mano da 175
    }
    
    [Test]
    public void TestAttackSpear()
    {
        elve.AddItem(new Spear(30));
        elve.Attack(elveEnemy);
        
        Assert.AreEqual(180, elveEnemy.Hp); // Al hacer las cuentas a mano da 180
    }
    
    [Test]
    public void TestAttackShield()
    {
        elveEnemy.AddItem(new Shield(45,30));
        elveEnemy.Attack(elve);
        
        Assert.AreEqual(55, elve.Hp); // Al hacer las cuentas a mano da 55
    }
    
    [Test]
    public void TestDefenseArmor()
    {
        elveEnemy.AddItem(new Armor(50));
      
        Assert.AreEqual(100, elveEnemy.DefenseValue); // Al hacer las cuentas a mano da 100
    }
    
    [Test]
    public void TestDefenseHat()
    {
        elveEnemy.AddItem(new Hat(20));
        
        Assert.AreEqual(70, elveEnemy.DefenseValue); // Al hacer las cuentas a mano da 70
    }
    
    [Test]
    public void TestHeal() //sanar
    {
        elveEnemy.AddItem(new Shield(40,30));
        elveEnemy.Attack(elve);
        elve.Heal();
        Assert.AreEqual(100,elve.Hp);
        elveEnemy.AddItem(new Shield(4000,30));
        elveEnemy.Attack(elve);
        elve.Heal();
        Assert.AreEqual(0,elve.Hp);
    }
}