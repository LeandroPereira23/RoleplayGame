namespace Program;

public class Dwarve : Hero
{
    public Dwarve(float maxHp, float damage, float defense) 
        : base(maxHp, damage, defense)
    {
        
    }
    
    
    public void AddItem(IPhysicItem item)
    {
        inventory.AddItem(item);
    }
}