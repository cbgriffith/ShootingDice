using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";

            player3.Play(player2);

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            Console.WriteLine("-------------------");

            SmackTalkingPlayer smacker = new SmackTalkingPlayer();
            smacker.Name = "Asshole";
            smacker.Taunt = "Losers lose, and you're a loser!";

            large.Play(smacker);

            Console.WriteLine("-------------------");

            OneHigherPlayer higher = new OneHigherPlayer();
            higher.Name = "OneUp";

            smacker.Play(higher);

            Console.WriteLine("-------------------");

            Player cheater = new HumanPlayer();
            cheater.Name = "Cheater";

            higher.Play(cheater);

            Console.WriteLine("-------------------");

            CreativeSmackTalkingPlayer randomSmacker = new CreativeSmackTalkingPlayer();
            randomSmacker.Name = "Random Insult Asshole";

            cheater.Play(randomSmacker);

            Console.WriteLine("-------------------");

            SoreLoserPlayer soreLoser = new SoreLoserPlayer();
            soreLoser.Name = "Crybaby";

            randomSmacker.Play(soreLoser);
            soreLoser.Play(player1);
            soreLoser.Play(player2);
            soreLoser.Play(player3);

            Console.WriteLine("-------------------");

            Player upperHalf = new UpperHalfPlayer();
            upperHalf.Name = "Upper Halfer";

            soreLoser.Play(upperHalf);
        

            Console.WriteLine("-------------------");

            List<Player> players = new List<Player>() {
                player1, player2, player3, large, smacker, higher, cheater, randomSmacker, soreLoser, upperHalf
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play one another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}