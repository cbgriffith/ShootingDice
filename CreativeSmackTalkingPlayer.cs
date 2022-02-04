using System;
using System.Collections.Generic;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public override int Roll()
        {
            List<string> insults = new List<string>
            {
                "You stink and I don't like you",
                "Yo momma so fat",
                "Learn from your parents' mistakes - use birth control!",
                "I wasn't born with enough middle fingers to let you know how I feel."
            };

            int index = new Random().Next(insults.Count);

            Console.WriteLine(insults[index]);
            return base.Roll();
        }
    }
}