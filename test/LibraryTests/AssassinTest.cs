using Library.Characters.Enemies;
using Program;
namespace LibraryTests;

public class AssassinTest
{
    private Elve elve;
    private Assassin assassin;

    [SetUp]
    public void Setup()
    {
        elve = new Elve(100, 15, 40);
        assassin = new Assassin(160, 50, 50,1);
    }

    [Test]
    public void AttackTest()
    {
        elve.AddItem(new Armor(35));
        elve.Attack(assassin);
        
        Assert.AreEqual(152.5f,assassin.Hp);
    }
}