using System;

namespace Shogun
{
    public class Dice
    {
        private Random _random = new Random();
        private static Dice dice = new Dice();

        public static Dice GetInstance()
        {
            return dice;
        }

        private Dice()
        {
            
        }

        public int RollDice()
        {
            return _random.Next(1,12);
        }
    }
}