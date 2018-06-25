using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenHero.BingoBuzz.GameState.Models
{
    public enum GameStateEnum
    {
        Unknown = -1,
        NOT_LOGGED_IN = 1,
        LOGGED_IN_LISTING_GAMES,
        LOGGED_IN_NO_GAMES,
        LOGGED_IN_ACTIVE_GAME
    }
}
