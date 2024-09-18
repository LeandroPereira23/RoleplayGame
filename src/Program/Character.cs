public class Character
{
    protected float hp;
    protected float maxHp;
    protected float damage;
    protected float defense;

    public float Attack(Character character)
    {
        character.hp -= damage * (1 - character.defense / 100);
        return character.hp;
    }
    
    public bool isDead()
    {
        return hp <= 0;
    }

    public void Heal()
    {
        if (isDead()) return;

        hp = maxHp;
    }
}