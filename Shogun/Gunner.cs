namespace Shogun
{
    public class Gunner : AAshigaru
    {
        public Gunner() : base(COMBAT_LEVEL_UNTRAINED, COMBAT_LEVEL_TRAINED, 2)
        {
            
        }

        public override string ToString()
        {
            return "gunner";
        }
    }
}