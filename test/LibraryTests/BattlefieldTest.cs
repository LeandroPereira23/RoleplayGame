using Library.Battle;
using Library.Characters.Enemies;
using Program;
using Program.Enemies;

namespace LibraryTests;

public class BattlefieldTest
{
    [Test]
    public void DoEncounterTest()
    {
        
    }
    
    
    
    [Test]
    public void RecieveHealPostEncounterTest()
    {
        Battlefield battlefield = new Battlefield();
        List<Hero> heroes = new List<Hero>() { new Dwarve(1000,100,20), new Dwarve(1000,100,20), new Knight(1000,100,20)};
        List<Enemy> enemies = new List<Enemy>() { new Goblin(10,1,2,5), new Goblin(10,1,2,5), new Goblin(10,1,2,5)};
        
        battlefield.AddFightersToBattle(heroes, enemies);
        
        battlefield.DoEncounter();

        if (battlefield.Heroes.Any(hero => hero.Vp >= 5 && hero.Hp != 1000)) Assert.Fail();
    }
}