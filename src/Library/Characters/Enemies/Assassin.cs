using Program;
using Program.Enemies;

namespace Library.Characters.Enemies;

public class Assassin : Enemy
{
    public Assassin(float maxHp, float damage, float defense, int vp) : base(maxHp, damage, defense, vp)
    {
        
    }

    public void AddItem(IPhysicItem item)
    {
        inventory.AddItem(item);
    }
}