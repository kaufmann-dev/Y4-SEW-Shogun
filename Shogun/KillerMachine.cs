namespace Shogun
{
    // This class only exists to simplify a UnitTest in ArmyTest.cs
    public class KillerMachine : ASamurai
    {
        public KillerMachine() : base(COMBAT_LEVEL_KILLER, COMBAT_LEVEL_KILLER, 20)
        {
            
        }

        public override string ToString()
        {
            return "killermachine";
        }
    }
}