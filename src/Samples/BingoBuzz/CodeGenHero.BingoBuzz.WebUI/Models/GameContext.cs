using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenHero.BingoBuzz.WebUI.Models
{
    public class GameContext
    {
        public string Username { get; set; }

        public int UserStats_Games { get; set; }

        public int UserStats_Bingos { get; set; }

        public int UserStats_Clicks { get; set; }

        public string Company { get; set; }

        public BingoCard CurrentBingoCard { get; set; }


    }
}
