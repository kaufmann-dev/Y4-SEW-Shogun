using System;

namespace Shogun
{
    class Program
    {
        static void Main(string[] args)
        {
            Army army1 = new Army();
            army1.Add(new Bowman());
            army1.Add(new Gunner());
            army1.Add(new Horseman());
            
            Army army2 = new Army();
            army2.Add(new Spearman());
            army2.Add(new Swordsman());
            army2.Add(new Horseman());

            int count1 = army1.DeterminateRangedHits();
            army2.ResolveCasualties(count1);

            int count2 = army2.DeterminateRangedHits();
            army1.ResolveCasualties(count2);
            
            int count3 = army1.DeterminateMeleeHits();
            army2.ResolveCasualties(count3);

            int count4 = army2.DeterminateMeleeHits();
            army1.ResolveCasualties(count4);
        }
    }
}