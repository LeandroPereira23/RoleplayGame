using Program;

namespace LibraryTests;

public class DwarveTest
{
    private Dwarve dwarve;
    private Dwarve dwarveEnemy;
    [SetUp]
    public void Setup()
    {
        dwarve = new Dwarve(100, 10, 10);
        dwarveEnemy = new Dwarve(200, 5, 50);
    }

    [Test]
    public void TestAttackKnife()
    {
        dwarve.inventory.AddItem(new Knife(40));
        dwarve.Attack(dwarveEnemy);
        
        Assert.AreEqual(175, dwarveEnemy.Hp); // Al hacer las cuentas a mano da 175
    }
    
    [Test]
    public void TestAttackSpear()
    {
        dwarve.inventory.AddItem(new Spear(30));
        dwarve.Attack(dwarveEnemy);
        
        Assert.AreEqual(180, dwarveEnemy.Hp); // Al hacer las cuentas a mano da 180
    }
    
    [Test]
    public void TestAttackShield()
    {
        dwarveEnemy.inventory.AddItem(new Shield(45,30));
        dwarveEnemy.Attack(dwarve);
        
        Assert.AreEqual(55, dwarve.Hp); // Al hacer las cuentas a mano da 55
    }
    
    [Test]
    public void TestDefenseArmor()
    {
        dwarveEnemy.inventory.AddItem(new Armor(50));
      
        Assert.AreEqual(100, dwarveEnemy.DefenseValue); // Al hacer las cuentas a mano da 100
    }
    
    [Test]
    public void TestDefenseHat()
    {
        dwarveEnemy.inventory.AddItem(new Hat(20));
        
        Assert.AreEqual(70, dwarveEnemy.DefenseValue); // Al hacer las cuentas a mano da 70
    }
    
   
    
    [Test]
    public void TestHeal() //sanar
    {
        dwarveEnemy.inventory.AddItem(new Shield(40,30));
        dwarveEnemy.Attack(dwarve);
        dwarve.Heal();
        Assert.AreEqual(100,dwarve.Hp);
        dwarveEnemy.inventory.AddItem(new Shield(4000,30));
        dwarveEnemy.Attack(dwarve);
        dwarve.Heal();
        Assert.AreEqual(0,dwarve.Hp);
    }
}