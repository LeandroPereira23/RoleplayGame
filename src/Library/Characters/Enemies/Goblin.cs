using Program;
using Program.Enemies;

namespace Library.Characters.Enemies;

public class Goblin : Enemy<IPhysicItem>
{
    public Goblin(float maxHp, float damage, float defense, int vp) 
        : base(maxHp, damage, defense, vp)
    {
        
    }
}