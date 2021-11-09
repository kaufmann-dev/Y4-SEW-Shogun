namespace Shogun
{
    public class Swordsman : ASamurai
    {
        public Swordsman() : base(COMBAT_LEVEL_EXPERIENCED, COMBAT_LEVEL_UNTRAINED, 2)
        {
            
        }

        public override string ToString()
        {
            return "swordsman";
        }
    }
}