using System;
using System.Collections.Generic;

namespace TheImpossibleBet
{
    class Game
    {
        private int[] boxes;
        public Game(int boxesCount)
        {
            boxes = new int[boxesCount];
            HashSet<int> leftNumbers = new HashSet<int>();
            Random rand = new Random();
            for(int i = 0; i < boxesCount; i++)
            {
                leftNumbers.Add(i);
            }
        }
    }
}