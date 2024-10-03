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
        elveEnemy = new Elve(200, 5, 5);
    }

    [Test]
    public void TestAttack()
    {
        elve.AddItem(new Knife(12));
        Console.WriteLine(elve.Hp);
        elve.Attack(elveEnemy);
        Console.WriteLine(elve.Hp);
        elve.Heal();
        Console.WriteLine(elve.Hp);
        
        
    }
}