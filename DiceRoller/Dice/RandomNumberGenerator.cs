using System;

namespace DiceRoller.Dice
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        private static readonly Random rnd = new Random(DateTime.Now.Millisecond);

        public int Next(int maxValue)
        {
            return rnd.Next(maxValue);
        }
    }
}
