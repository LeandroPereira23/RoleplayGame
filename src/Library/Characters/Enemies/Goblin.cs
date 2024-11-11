using Program;
using Program.Enemies;

namespace Library.Characters.Enemies;

public class Goblin : Enemy
{
    public Goblin(float maxHp, float damage, float defense, int vp) 
        : base(maxHp, damage, defense, vp)
    {
        
    }
    
    public void AddItem(IPhysicItem item)
    {
        inventory.AddItem(item);
    }
}