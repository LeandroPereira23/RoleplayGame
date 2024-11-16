using Program;
using Program.Enemies;

namespace Library.Characters.Enemies;

public class DarkKnight : Enemy
{
    public DarkKnight(float maxHp, float damage, float defense, int vp)
        : base(maxHp, damage, defense, vp)
    {

    }

    public void AddItem(IPhysicItem item)
    {
        inventory.AddItem(item);
    }

}