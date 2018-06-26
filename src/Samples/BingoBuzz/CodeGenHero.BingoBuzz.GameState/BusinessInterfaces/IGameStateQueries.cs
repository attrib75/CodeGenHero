using System;
using System.Collections.Generic;
using System.Text;
using CodeGenHero.BingoBuzz.GameState.Models;

namespace CodeGenHero.BingoBuzz.GameState.BusinessInterfaces
{
    public interface IGameStateQueries
    {
        GameContext GetGameContext(ClientStateData clientStateData);

        GameContext GetGameContextUpdateOnly(ClientStateData clientStateData, DateTime serverTimeOfLastUpdate);


    }
}
