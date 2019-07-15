using System;
using System.Collections.Generic;

namespace TheImpossibleBet
{
    class Game
    {
        private List<int> boxes;
        private int maxMoves;
        public Game(int boxesCount, int? maxMoves = null)
        {
            boxes = new List<int>();
            Random rand = new Random();
            for(int i = 0; i < boxesCount; i++)
            {
                boxes.Add(i);
            }

            boxes.Shuffle();

            this.maxMoves = maxMoves ?? boxesCount / 2;
        }

        public List<int> Boxes => boxes;
        public int MaxMoves => maxMoves;
    }
}