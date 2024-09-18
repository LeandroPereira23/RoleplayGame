namespace Program;

public class Knife : Attack
{
    public float Damage
    {
        get { return this.damage; }
    }

    public Knife(float damage):base(damage){ }
}