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
    public void TestAttack()
    {
        elve.inventory.AddItem(new Knife(40));
        elve.Attack(elveEnemy);
        
        Assert.AreEqual(175, elveEnemy.Hp); // Al hacer las cuentas a mano da 175
    }
}