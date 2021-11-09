namespace Shogun
{
    public abstract class ASamurai : AUnit
    {
        protected ASamurai(int meleeAttackvalue, int rangedAttakValue, int upkeep) : base(meleeAttackvalue, rangedAttakValue, upkeep)
        {
            
        }

        public override bool JoinArmy(Army army)
        {
            if (army.SamuraiUnits.Count < /*army.SAMURAI_LIMIT*/ 5 && army.Upkeep + this.Upkeep < /*army.UPKEEP_LIMIT*/ 30 && army.SamuraiUnits.Count + army.AshigaruUnits.Count < /*army.UNIT_LIMIT*/ 15)
            {
                army.SamuraiUnits.Add(this);
                army.Upkeep += this.Upkeep;
                System.Diagnostics.Debug.WriteLine("Unit joined army");
                return true;
            }

            return false;
        }
    }
}