using System;

namespace Shogun
{
    public class AUnit
    {
        private Random raar = new Random();
        
        protected static int COMBAT_LEVEL_KILLER = 8;
        protected static int COMBAT_LEVEL_SUPERIOR = 6;
        protected static int COMBAT_LEVEL_EXPERIENCED = 5;
        protected static int COMBAT_LEVEL_TRAINED = 4;
        protected static int COMBAT_LEVEL_UNTRAINED = 0;

        private int _meleeAttackValue;
        private int _rangedAttackValue;
        private int _upkeep;

        public int MeleeAttackValue { get; set; }
        public int Upkeep { get; set; }
        public int RangedAttackValue { get; set; }

        protected AUnit(int meleeAttackValue, int rangedAttackValue, int upkeep)
        {
            this.MeleeAttackValue = meleeAttackValue;
            this.Upkeep = upkeep;
            this.RangedAttackValue = rangedAttackValue;
        }

        public bool IsMeleeAttackSuccessful()
        {
            if (raar.Next(1, 12) <= this.MeleeAttackValue)
            {
                return true;
            }

            return false;
        }

        public bool IsRangedAttackSuccessful()
        {
            if (raar.Next(1,12) <= this.RangedAttackValue)
            {
                return true;
            }

            return false;
        }

        public virtual bool JoinArmy(Army army)
        {
            return false;
        }

        public /*override*/ bool Equals(AUnit aUnit)
        {
            if (this.MeleeAttackValue == aUnit.MeleeAttackValue && this.Upkeep == aUnit.Upkeep && this.RangedAttackValue == aUnit.RangedAttackValue)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"Melle attack value: {this.MeleeAttackValue}, Ranged attack value: {this.RangedAttackValue}, Upkeep: {this.Upkeep}";
        }
    }
}