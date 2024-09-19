public class Dwarve : Character
{
    private Knife knife;
    private Hat hat;

    public Dwarve(float maxHp, float damage, float defense):base(maxHp, damage, defense){ }
    
    public void AddKnife(Knife knife)
    {
        this.knife = knife;
        this.damage += knife.Damage;
    }

    public void RemoveKnife()
    {
        if (this.knife != null)
        {
            this.damage -= this.knife.Damage;
            this.knife = null;
        }
    }

    public void AddHat(Hat hat)
    {
        this.hat = hat;
        this.defense += hat.Protection;
    }

    public void RemoveHat()
    {
        if (this.hat != null)
        {
            this.defense -= this.hat.Protection;
            this.hat = null;
        }
    }
}