namespace Program;

public abstract class Hero<TItem> : Character<TItem>
{
    public Hero(float maxHp, float damage, float defense) 
        : base(maxHp, damage, defense)
    {
        Vp = 0;
    }

    public override float Attack(Character<TItem> character)
    {
        float characterHp = base.Attack(character);
        if (characterHp == 0) Vp += character.Vp;

        return characterHp;
    }

 
}