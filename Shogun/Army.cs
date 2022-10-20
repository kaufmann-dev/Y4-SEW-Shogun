using System;
using System.Collections.Generic;
using System.Linq;

namespace Shogun
{
    public class Army
    {
        public static int UPKEEP_LIMIT = 30;
        public static int UNIT_LIMIT = 15;
        public static int SAMURAI_LIMIT = 5;
        public static int ASHIGARU_LIMIT = 10;

        private List<ASamurai> _samuraiUnits;
        private List<AAshigaru> _ashigaruUnits;
        private Random _random;
        private int _upkeep = 0;
        
        public int Upkeep { get; set; }
        public List<ASamurai> SamuraiUnits { get; set; }
        public List<AAshigaru> AshigaruUnits { get; set; }

        public Army()
        {
            
        }

        public bool Add(AUnit aUnit)
        {
            if (aUnit.JoinArmy(this))
            {
                this.Upkeep += aUnit.Upkeep;
                return true;
            }

            return false;
        }

        public void ResolveCasualties(int amount)
        {
            int a = _samuraiUnits.Count + _ashigaruUnits.Count;
            int b = 0;
            for (int i = 0; i < a; i++)
            {
                b = _random.Next(1, a);
                if (b < _ashigaruUnits.Count)
                {
                    _samuraiUnits.RemoveAt(b);
                    this.Upkeep -= _samuraiUnits.ElementAt(b).Upkeep;
                }
                else
                {
                    _ashigaruUnits.RemoveAt(b);
                    this.Upkeep -= _ashigaruUnits.ElementAt(b).Upkeep;
                }
            }
        }

        public int DeterminateRangedHits()
        {
            int count = 0;
            foreach (var c in _ashigaruUnits)
            {
                if (c.IsRangedAttackSuccessful())
                {
                    count++;
                    System.Diagnostics.Debug.WriteLine("Successful range hit");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Unsuccessful range hit");
                }
            }

            foreach (var c in _samuraiUnits)
            {
                if (c.IsRangedAttackSuccessful())
                {
                    count++;
                    
                    System.Diagnostics.Debug.WriteLine("Successful range hit");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Unsuccessful range hit");
                }
            }

            return count;
        }

        public int DeterminateMeleeHits()
        {
            int count = 0;
            foreach (var c in _ashigaruUnits)
            {
                if (c.IsMeleeAttackSuccessful())
                {
                    count++;
                    System.Diagnostics.Debug.WriteLine("Successful close range hit");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Unsuccessful close range hit");
                }
            }

            foreach (var c in _samuraiUnits)
            {
                if (c.IsMeleeAttackSuccessful())
                {
                    count++;
                    
                    System.Diagnostics.Debug.WriteLine("Successful close range hit");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Unsuccessful close range hit");
                }
            }

            return count;
        }

        public int UnitCount()
        {
            return _samuraiUnits.Count + _ashigaruUnits.Count;
        }
    }
}