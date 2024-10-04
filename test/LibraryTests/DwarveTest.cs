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
    public void TestAttack()
    {
        dwarve.AddItem(new Knife(40));
        dwarve.Attack(dwarveEnemy);
        
        Assert.AreEqual(175, dwarveEnemy.Hp); // Al hacer las cuentas a mano da 175
    }
}