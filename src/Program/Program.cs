using Library.Characters.Enemies;
using Program.Enemies;


namespace Program;

public class Program
{
    public static void Main()
    {
        var elve = new Dwarve(100, 10, 10);

        var cuchillo = new Knife(18);
        elve.AddItem(cuchillo);
        
        Goblin goblin = new Goblin(200, 5, 5, 3);
        goblin.AddItem(new Knife(180));

        Character<IPhysicItem> elve = new Elve(100, 10, 10);
        Character<IPhysicItem> elveEnemy = new Elve(200, 5, 5);


        Enemy enemy = goblin;
        enemy.Attack(elve);
        
        Console.WriteLine(elve.Hp);
       
        
    }
} 
