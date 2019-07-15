using System;
using System.Collections.Generic;

namespace TheImpossibleBet
{
    class RandomPlayerStrategy : IPlayerStrategy
    {
        private readonly Random rnd;
        public RandomPlayerStrategy()
        {
            rnd = new Random();
        }

        public int GetNextBox(HashSet<int> previousMoves, int lastMove, List<int> boxes, int playerId)
        {
            var needMore = true;
            var box = 0;
            while(needMore || previousMoves.Count >= boxes.Count)
            {
                box = rnd.Next(boxes.Count);
                needMore = previousMoves.Contains(box);
            }

            return box;
        }
    }
}