using Library.Characters.Enemies;
using Program;

namespace LibraryTests;

public class KnightTest
{
    private Knight knight;
    private DarKnight darKnight;
    [SetUp]
    public void Setup()
    {
        knight = new Knight(100, 20, 30);
        darKnight = new DarKnight(150, 15, 30, 2);
    }

    [Test]
    public void Test()
    {
        knight.AddItem(new Knife(50));
        knight.Attack(darKnight);
        
        Assert.AreEqual(101, darKnight.Hp); // Al hacer las cuentas a mano da 100.7 al redondear 101
    }

}