namespace Shogun
{
    public class Horseman : ASamurai
    {
        public Horseman() : base(COMBAT_LEVEL_KILLER, COMBAT_LEVEL_KILLER, 4)
        {
            
        }

        public override string ToString()
        {
            return "horseman";
        }
    }
}