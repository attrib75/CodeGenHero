using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenHero.BingoBuzz.GameState.Models
{
    public class GameContext
    {

        public GameStateEnum GameState { get; set; }

        public User User { get; set; }

        public Meeting ActiveMeeting { get; set; }

        public List<Meeting> MeetingList { get; set; }



    }
}
