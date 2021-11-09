namespace Shogun
{
    public abstract class AAshigaru : AUnit
    {
        protected AAshigaru(int meleeAttackValue, int rangedAttackValue, int upkeep) : base(meleeAttackValue, rangedAttackValue, upkeep)
        {
            
        }

        public override bool JoinArmy(Army army)
        {
            if (army.AshigaruUnits.Count < /*army.ASHIGARU_LIMIT*/ 10 && army.Upkeep + this.Upkeep < /*army.UPKEEP_LIMIT*/ 30 && army.SamuraiUnits.Count + army.AshigaruUnits.Count < /*army.UNIT_LIMIT*/ 15)
            {
                army.AshigaruUnits.Add(this);
                army.Upkeep += this.Upkeep;
                System.Diagnostics.Debug.WriteLine("Unit joined army");
                return true;
            }

            return false;
        }
    }
}