
using Program;
using Program.Enemies;

namespace Library.Characters.Enemies;

public class Witch : Enemy
{
    public Witch(float maxHp, float damage, float defense, int vp) 
        : base(maxHp, damage, defense, vp)
    {
    
    }
    
    public void AddItem(IMagicItem item)
    {
        inventory.AddItem(item);
    }
}
