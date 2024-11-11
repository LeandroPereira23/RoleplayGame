namespace Program;

public class Knight : Hero
{
    public Knight(float maxHp, float damage, float defense ) 
        : base(maxHp, damage, defense)
    {
    
    }
    
    public void AddItem(IPhysicItem item)
    {
        inventory.AddItem(item);
    }
}