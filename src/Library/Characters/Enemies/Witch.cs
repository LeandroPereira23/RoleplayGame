using Program;
using Program.Enemies;

namespace Library.Characters.Enemies;
public class Witch : Enemy<IMagicItem>
{
    public Witch(float maxHp, float damage, float defense ) 
        : base(maxHp, damage, defense)
    {
    
    }
}
