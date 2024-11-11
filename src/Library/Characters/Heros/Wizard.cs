namespace Program;
public class Wizard : Hero
{
    public Wizard(float maxHp, float damage, float defense)
        : base(maxHp, damage, defense)
    {
        
    }
    
    public void AddItem(IMagicItem item)
    {
        inventory.AddItem(item);
    }
}