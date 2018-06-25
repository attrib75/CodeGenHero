using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeGenHero.BingoBuzz.WebUI.Models;

namespace CodeGenHero.BingoBuzz.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            //Eventually this should come from a layer outside of the API but also not a part of the UI - 
            //for now make it here to start making some progress in the UI

            GameContext currentGameContext = new GameContext();

            currentGameContext.Username = "The Test User";

            currentGameContext.UserStats_Bingos = 3;
            currentGameContext.UserStats_Games = 7;
            currentGameContext.UserStats_Clicks = 81;

            currentGameContext.Company = "ACME Piano Company";

            currentGameContext.CurrentBingoCard = new BingoCard(5);
            currentGameContext.CurrentBingoCard.GameName = "Beer City Code lecture /w batman (paul) and robin";

            bool shouldSelectItemsForTest = true;

            currentGameContext.CurrentBingoCard.Squares[0, 0] = new CardSquare(0, 0, "a card", shouldSelectItemsForTest);
            currentGameContext.CurrentBingoCard.Squares[0, 1] = new CardSquare(0, 1, "two cards");
            currentGameContext.CurrentBingoCard.Squares[0, 2] = new CardSquare(0, 2, "a third card");
            currentGameContext.CurrentBingoCard.Squares[0, 3] = new CardSquare(0, 3, "the fouth card");
            currentGameContext.CurrentBingoCard.Squares[0, 4] = new CardSquare(0, 4, "this is the fifth card");

            currentGameContext.CurrentBingoCard.Squares[1, 0] = new CardSquare(1, 0, "a card");
            currentGameContext.CurrentBingoCard.Squares[1, 1] = new CardSquare(1, 1, "two cards", shouldSelectItemsForTest);
            currentGameContext.CurrentBingoCard.Squares[1, 2] = new CardSquare(1, 2, "a third card");
            currentGameContext.CurrentBingoCard.Squares[1, 3] = new CardSquare(1, 3, "the fouth card");
            currentGameContext.CurrentBingoCard.Squares[1, 4] = new CardSquare(1, 4, "this is the fifth card", shouldSelectItemsForTest);

            currentGameContext.CurrentBingoCard.Squares[2, 0] = new CardSquare(2, 0, "a card");
            currentGameContext.CurrentBingoCard.Squares[2, 1] = new CardSquare(2, 1, "two cards");
            currentGameContext.CurrentBingoCard.Squares[2, 2] = new CardSquare(2, 2, "FREE", shouldSelectItemsForTest);
            currentGameContext.CurrentBingoCard.Squares[2, 3] = new CardSquare(2, 3, "the fouth card");
            currentGameContext.CurrentBingoCard.Squares[2, 4] = new CardSquare(2, 4, "this is the fifth card");

            currentGameContext.CurrentBingoCard.Squares[3, 0] = new CardSquare(3, 0, "a card");
            currentGameContext.CurrentBingoCard.Squares[3, 1] = new CardSquare(3, 1, "two cards");
            currentGameContext.CurrentBingoCard.Squares[3, 2] = new CardSquare(3, 2, "a third card");
            currentGameContext.CurrentBingoCard.Squares[3, 3] = new CardSquare(3, 3, "the fouth card", shouldSelectItemsForTest);
            currentGameContext.CurrentBingoCard.Squares[3, 4] = new CardSquare(3, 4, "this is the fifth card");

            currentGameContext.CurrentBingoCard.Squares[4, 0] = new CardSquare(4, 0, "a card");
            currentGameContext.CurrentBingoCard.Squares[4, 1] = new CardSquare(4, 1, "two cards");
            currentGameContext.CurrentBingoCard.Squares[4, 2] = new CardSquare(4, 2, "a third card");
            currentGameContext.CurrentBingoCard.Squares[4, 3] = new CardSquare(4, 3, "the fouth card");
            currentGameContext.CurrentBingoCard.Squares[4, 4] = new CardSquare(4, 4, "this is the fifth card");


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
