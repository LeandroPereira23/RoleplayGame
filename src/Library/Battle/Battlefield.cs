using System.Collections;
using Program;
using Program.Enemies;

namespace Library.Battle;

public class Battlefield
{
    public List<Enemy> Enemies { get; private set; } = new();
    public List<Hero> Heroes { get; private set; } = new();
    
    public void DoEncounter()
    {
        
    }

    public void AddFightersToBattle(List<Hero> heroes, List<Enemy> enemies)
    {
        Heroes = heroes;
        Enemies = enemies;
    }
}