namespace Program;

public class Program
{
    public static void Main()
    {
        Elve elve = new Elve(100, 10, 10);
        Elve elveEnemy = new Elve(200, 5, 5);

        Knife cuchillo1 = new Knife(18);
        Spear cuchillo2 = new Spear(18);
        elve.AddItem(cuchillo1);
        elve.AddItem(cuchillo2);
        
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
