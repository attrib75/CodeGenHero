using System;
using System.Collections.Generic;
using System.Text;
using CodeGenHero.BingoBuzz.GameState.BusinessInterfaces;
using CodeGenHero.BingoBuzz.GameState.Models;


namespace CodeGenHero.BingoBuzz.GameState.MockProvider.BusinessProviders
{
    public class GameStateCommands : IGameStateCommands
    {
        public void CheckSquare(string MeetingId, int x, int y, bool newValue)
        {
            throw new NotImplementedException();
        }

        public string CreateMeeting(string name, List<string> attendeeUserIds)
        {
            throw new NotImplementedException();
        }
    }
}
