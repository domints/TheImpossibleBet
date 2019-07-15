using System.Collections.Generic;

namespace TheImpossibleBet
{
    interface IPlayerStrategy
    {
        int GetNextBox(HashSet<int> previousMoves, int lastMove, List<int> boxes, int playerId);
    }
}