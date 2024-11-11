namespace Program;

public abstract class Hero : Character
{
    protected Hero(float maxHp, float damage, float defense) 
        : base(maxHp, damage, defense)
    {
        Vp = 0;
    }

    public override float Attack(Character character)
    {
        float characterHp = base.Attack(character);
        if (characterHp == 0) Vp += character.Vp;

        return characterHp;
    }
    
    public override float Attack(Character<IMagicItem> character)
    {
        float characterHp = base.Attack(character);
        if (characterHp == 0) Vp += character.Vp;

        return characterHp;
    }
}