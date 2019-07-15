using System;
using System.Linq;

namespace TheImpossibleBet
{
    class Program
    {
        const int PLAYERS = 100;
        const long GAMES = 1000000;
        static void Main(string[] args)
        {
            var wonRandom = 0;
            var wonChain = 0;

            var randomStrategy = new RandomPlayerStrategy();
            var randomPlayers = Enumerable.Range(0, PLAYERS).Select(i => new Player(randomStrategy, i)).ToList();
            var chainStrategy = new ChainPlayerStrategy();
            var chainPlayers = Enumerable.Range(0, PLAYERS).Select(i => new Player(chainStrategy, i)).ToList();
            for(int i = 0; i < GAMES; i++)
            {
                if((i * 100 / GAMES) > ((i - 1) * 100 / GAMES))
                    Console.WriteLine($"{(i * 100 / GAMES)}%");
                var game = new Game(PLAYERS);
                if(randomPlayers.All(p => p.Play(game)))
                    wonRandom++;
                if(chainPlayers.All(p => p.Play(game)))
                    wonChain++;
            }

            Console.WriteLine($"Random winning: {wonRandom}/{GAMES} ({((decimal)wonRandom * 100)/GAMES}%)");
            Console.WriteLine($"Chain winning: {wonChain}/{GAMES} ({((decimal)wonChain * 100)/GAMES}%)");
        }
    }
}
