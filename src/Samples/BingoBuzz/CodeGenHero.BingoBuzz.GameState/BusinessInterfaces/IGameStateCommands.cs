using System;
using System.Collections.Generic;
using System.Text;
using CodeGenHero.BingoBuzz.GameState.Model;


namespace CodeGenHero.BingoBuzz.GameState.BusinessInterfaces
{
    public interface IGameStateCommands
    {
        /// <summary>
        /// Create a new meeting with a name and list of attendees.
        /// </summary>
        /// <param name="name">The text name of the new meeting.</param>
        /// <param name="attendeeUserIds">A list of UserId (guids) of attendees.</param>
        /// <returns>The MeetingId of the newly created meeting.</returns>
        string CreateMeeting(string name, List<string> attendeeUserIds);

        /// <summary>
        /// This will be used to check or uncheck a square.
        /// </summary>
        /// <param name="MeetingId"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="newValue"></param>
        /// <returns></returns>
        void CheckSquare(string MeetingId, int x, int y, bool newValue);
        
    }
}
