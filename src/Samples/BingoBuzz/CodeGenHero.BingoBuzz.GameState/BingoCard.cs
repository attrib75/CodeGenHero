using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenHero.BingoBuzz.GameState
{
    public class BingoCard
    {
        public int Size { get; set; }

        public CardSquare[,] Squares;
       
        
        public BingoCard(int size)
        {
            this.Size = size;
            this.Squares = new CardSquare[size, size];

        }
    }
}
