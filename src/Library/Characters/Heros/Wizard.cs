namespace Program;
public class Wizard : Hero<IMagicItem>
{
    public Wizard(float maxHp, float damage, float defense)
        : base(maxHp, damage, defense)
    {
        
    }
}