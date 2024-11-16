using System.Collections;
using Program;
using Program.Enemies;

namespace Library.Battle;

public class Battlefield
{
    public List<Character> Enemies { get; private set; } = new();
    public List<Character> Heroes { get; private set; } = new();

    private int[] initialHeroVPs;

    public void DoEncounter()
    {
        SetInitialHeroVPs();
        while (Enemies.Any(enemy => !enemy.IsDead()) && Heroes.Any(hero => !hero.IsDead()))
        {
            TeamAttack(Enemies, Heroes);
            TeamAttack(Heroes, Enemies);
        }
        TryToHealHeros();
    }

    private void TryToHealHeros()
    {
        for (int i = 0; i < Heroes.Count; i++)
        {
            if (!Heroes[i].IsDead() && Heroes[i].Vp - initialHeroVPs[i] > 4) 
            {
                Heroes[i].Heal();
            }
        }
    }
    private void SetInitialHeroVPs()
    {
        for (int i = 0; i < Heroes.Count; i++)
        {
            initialHeroVPs[i] = Heroes[0].Vp;
        }
    }
    private void TeamAttack(List<Character> attacants, List<Character> recievers)
    {
        int aux = 0;
        foreach (var attacant in attacants)
        {
            while (recievers.Any(reciever => !reciever.IsDead()))
            {
                if (recievers[aux].IsDead())
                {
                    if (aux == recievers.Count - 1) aux = 0;
                    else
                    {
                        aux++;
                    }
                }
            }
            attacant.Attack(recievers[aux]);
            aux++;
        }
    }

    public void AddFightersToBattle(List<Hero> heroes, List<Enemy> enemies)
    {
        Heroes.AddRange(heroes);
        Enemies.AddRange(enemies);
        initialHeroVPs = new int[Heroes.Count];
    }
    
}