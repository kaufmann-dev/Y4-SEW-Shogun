namespace Shogun
{
    public class Bowman : ASamurai
    {
        public Bowman() : base(COMBAT_LEVEL_UNTRAINED, COMBAT_LEVEL_SUPERIOR, 3)
        {
            
        }

        public override string ToString()
        {
            return "bowman";
        }
    }
}