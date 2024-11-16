using Library.Characters.Enemies;
using Program;

namespace LibraryTests;

public class KnightTest
{
    private Knight knight;
    private DarkKnight darkKnight;
    [SetUp]
    public void Setup()
    {
        knight = new Knight(100, 20, 30);
        darkKnight = new DarkKnight(150, 15, 30, 2);
    }

    [Test]
    public void Test()
    {
        knight.AddItem(new Knife(50));
        knight.Attack(darkKnight);
        
        Assert.AreEqual(101, darkKnight.Hp); // Al hacer las cuentas a mano da 100.7 al redondear 101
    }

}