namespace Program;

public class Program
{
    public static void Main()
    {
        Elve elve = new Elve(100, 10, 10);
        Elve elveEnemy = new Elve(200, 5, 5);

        Knife cuchillo = new Knife(18);
        Spear spear = new Spear(18);
        elve.inventory.AddItem(cuchillo);
        elve.inventory.AddItem(spear);

        Console.WriteLine(string.Join(" ", elve.inventory.GetItemNames()));
        
        Console.WriteLine(elveEnemy.Hp);
        elve.Attack(elveEnemy);
        Console.WriteLine(elveEnemy.Hp);
        elve.Attack(elveEnemy);
        Console.WriteLine(elveEnemy.Hp);
        elve.Attack(elveEnemy);
        Console.WriteLine(elveEnemy.Hp);
        elveEnemy.Heal();
        Console.WriteLine(elveEnemy.Hp);
    }
} 
