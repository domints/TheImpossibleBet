using System.Collections.Generic;

namespace TheImpossibleBet
{
    class Player
    {
        private readonly IPlayerStrategy strategy;
        private readonly int id;
        public Player(IPlayerStrategy strategy, int playerId)
        {
            this.strategy = strategy;
            id = playerId;
        }

        public bool Play(Game game)
        {
            HashSet<int> moves = new HashSet<int>();
            int lastMove = -1;
            for(int i = 0; i < game.MaxMoves; i++)
            {
                var move = strategy.GetNextBox(moves, lastMove, game.Boxes, id);
                moves.Add(move);
                lastMove = move;
                if(game.Boxes[move] == id)
                    return true;
            }

            return false;
        }
    }
}