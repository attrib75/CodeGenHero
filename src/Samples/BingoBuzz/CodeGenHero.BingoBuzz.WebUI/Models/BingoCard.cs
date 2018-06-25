using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenHero.BingoBuzz.WebUI.Models
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
