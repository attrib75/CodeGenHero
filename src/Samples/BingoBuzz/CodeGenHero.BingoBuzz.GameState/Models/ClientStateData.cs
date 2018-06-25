using System;
using System.Collections.Generic;
using System.Text;

namespace CodeGenHero.BingoBuzz.GameState.Models
{

    /// <summary>
    /// This class defines all of the data that needs to be passed by a client to obtain a valid GameContext object.
    /// </summary>
    public class ClientStateData
    {
        // This either contains the UserId (GUID) of the User who has already logged in (security responsibility of caller) or NULL if the user has not logged in yet.
        public string UserId { get; set; }

        /// <summary>
        /// This either contains the Meeting that is currently in the UI view, or it contains NULL, where NULL indicates that the user does not currently have an active Meeting.
        /// </summary>
        public string ActiveMeetingId { get; set; }

    }
}
