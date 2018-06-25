using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenHero.BingoBuzz.GameState.Models
{
    public class Meeting
    {
        public string MeetingId { get; set; }
        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime CreatedUserId { get; set; }

        public DateTime CreatedUsername { get; set; }

        public BingoCard BingoCard { get; set; }

        public User Winner { get; set; }

    }
}
