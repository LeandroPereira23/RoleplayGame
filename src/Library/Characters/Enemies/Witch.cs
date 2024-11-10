using Program.Enemies;

namespace Program;

public class Witch : Enemy<IMagicItem>
{
    public Witch(float maxHp, float damage, float defense ) 
        : base(maxHp, damage, defense)
    {
    
    }
}
