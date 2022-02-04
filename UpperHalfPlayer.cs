using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose roll will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()
        {
            // int diceSize = base.Roll();
            // int upperHalf = new Random().Next(DiceSize / 2, DiceSize);
            // return upperHalf;
            return new Random().Next(DiceSize / 2, DiceSize) + 1;
        }
    }
}