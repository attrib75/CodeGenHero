using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeGenHero.BingoBuzz.WebUI.Models;
using CodeGenHero.BingoBuzz.GameState.Models;
using CodeGenHero.BingoBuzz.GameState.APIClientProvider;
using CodeGenHero.BingoBuzz.GameState.BusinessInterfaces;

namespace CodeGenHero.BingoBuzz.WebUI.Controllers
{
    public class HomeController : Controller
    {



        //Later of course dependency injection and some base context should be providing these:
        IGameStateCommands commands = new GameState.MockProvider.BusinessProviders.GameStateCommands();
        IGameStateQueries queries = new GameState.MockProvider.BusinessProviders.GameStateQueries();

        public IActionResult Index()
        {




            //Lets load up some fake data to get the UI moving...

            ClientStateData clientStateData = new ClientStateData()
            {
                //This should be established through authentication, or left null for anonymous users.
                UserId = "{00000000-0000-0000-AABB-000000000001}",
                ActiveMeetingId = "{00000000-0000-0000-DD01-000000000001}"
            };

            GameContext currentGameContext = queries.GetGameContext(clientStateData);

            //currentGameContext.Username = "The Test User";

            //currentGameContext.UserStats_Bingos = 3;
            //currentGameContext.UserStats_Games = 7;
            //currentGameContext.UserStats_Clicks = 81;

            //currentGameContext.Company = "ACME Piano Company";

            //currentGameContext.CurrentBingoCard = new BingoCard(5);
            //currentGameContext.CurrentBingoCard.GameName = "Beer City Code lecture /w batman (paul) and robin";



            return View(currentGameContext);

        }

        public IActionResult MyProfile()
        {
            return View();
        }

        public IActionResult MyStats()
        {
            return View();
        }

        public IActionResult Sysconfig()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
