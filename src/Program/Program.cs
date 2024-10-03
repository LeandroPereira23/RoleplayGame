namespace Program;

public class Program
{
    public static void Main()
    {
        Elve elve = new Elve(100, 10, 10);
        Elve elveEnemy = new Elve(200, 5, 5);

        Knife cuchillo = new Knife(18);
        elve.AddItem(cuchillo);
        elve.AddItem(cuchillo);
        Console.WriteLine(elve.Hp);
        elve.Attack(elveEnemy);
        Console.WriteLine(elve.Hp);
        elve.Heal();
        Console.WriteLine(elve.Hp);
    }
} 
