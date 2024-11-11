namespace Program;

public abstract class Hero : Character
{
    public Hero(float maxHp, float damage, float defense) 
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

 
}