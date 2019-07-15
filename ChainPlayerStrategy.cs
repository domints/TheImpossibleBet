using System;
using System.Collections.Generic;

namespace TheImpossibleBet
{
    class ChainPlayerStrategy : IPlayerStrategy
    {

        public int GetNextBox(HashSet<int> previousMoves, int lastMove, List<int> boxes, int playerId)
        {
            if(previousMoves.Count == 0)
                return playerId;

            return boxes[lastMove];
        }
    }
}