namespace Program;

public class Elve : Hero
{
    public Elve(float maxHp, float damage, float defense)
        : base(maxHp, damage, defense)
    {
        
    }
    
    public void AddItem(IPhysicItem item)
    {
        inventory.AddItem(item);
    }
}