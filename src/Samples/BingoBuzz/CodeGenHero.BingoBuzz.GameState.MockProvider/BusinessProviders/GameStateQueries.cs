using System;
using System.Collections.Generic;
using System.Text;
using CodeGenHero.BingoBuzz.GameState.BusinessInterfaces;
using CodeGenHero.BingoBuzz.GameState.Models;


namespace CodeGenHero.BingoBuzz.GameState.MockProvider.BusinessProviders
{
    public class GameStateQueries : IGameStateQueries
    {
        public GameContext GetGameContext(ClientStateData clientStateData)
        {

            if(clientStateData.UserId == null)
            {
                return this.getGameContextFor_NOT_LOGGED_IN(clientStateData);
            }

            if(clientStateData.UserId != "{00000000-0000-0000-AABB-000000000001}")
            {
                throw new Exception("UserId not found in MOCK DATA");
            }

            if(clientStateData.ActiveMeetingId != null)
            {
                if (clientStateData.ActiveMeetingId != "{00000000-0000-0000-DD01-000000000001}")
                {
                    throw new Exception("Active MeetingId not found in MOCK DATA");
                }

                return this.getGameContextFor_LOGGED_IN_ACTIVE_GAME(clientStateData);

            }



            throw new Exception("Mock data provider is not built out to handle this kind of request");

        }


        private GameContext getGameContextFor_NOT_LOGGED_IN(ClientStateData clientStateData)
        {
            GameContext result = new GameContext();
            result.GameState = GameStateEnum.NOT_LOGGED_IN;
            return result;
        }

        private GameContext getGameContextFor_LOGGED_IN_ACTIVE_GAME(ClientStateData clientStateData)
        {

            GameContext result = new GameContext();

            result.GameState = GameStateEnum.LOGGED_IN_ACTIVE_GAME;

            result.User = new User()
            {
                UserId = "{00000000-0000-0000-AABB-000000000001}",
                Fullname = "James Bond",
                Stats_Bingos = 3,
                Stats_Games = 12,
                Stats_Clicks = 120,
                Company = new Company
                {
                    CompanyId = "{00000000-0000-0000-CCDD-100000000001}",
                    Name = "MI6",
                    CompanyDirectory = new List<User>()
                    {
                        new User
                        {
                            UserId = "{00000000-0000-0000-AABB-000000000002}",
                            Fullname = "M"
                        },
                        new User
                        {
                            UserId = "{00000000-0000-0000-AABB-000000000003}",
                            Fullname = "Miss Moneypenny"
                        },
                        new User
                        {
                            UserId = "{00000000-0000-0000-AABB-000000000004}",
                            Fullname = "Q"
                        },
                        new User
                        {
                            UserId = "{00000000-0000-0000-AABB-000000000005}",
                            Fullname = "Felix Leiter"
                        }
                    }
                }
            };


            // result.MeetingList = new List<Meeting>
            //{
            //    new Meeting
            //    {
            //        MeetingId = "{00000000-0000-0000-DD01-000000000001}",
            //        Name = "Weekly stakeholders update.",
            //        Winner = null,
            //        CreatedDate = new DateTime(2018,3,2)


            //    }
            //};



            result.ActiveMeeting = new Meeting
            {
                MeetingId = "{00000000-0000-0000-DD01-000000000001}",
                Name = "test active meeting",
                CreatedDate = new DateTime(2018, 3, 12),
                BingoCard = new BingoCard(5)

            

            };

            bool shouldSelectItemsForTest = true;

            result.ActiveMeeting.BingoCard.Squares[0, 0] = new CardSquare(0, 0, "a card", shouldSelectItemsForTest);
            result.ActiveMeeting.BingoCard.Squares[0, 1] = new CardSquare(0, 1, "two cards");
            result.ActiveMeeting.BingoCard.Squares[0, 2] = new CardSquare(0, 2, "a third card");
            result.ActiveMeeting.BingoCard.Squares[0, 3] = new CardSquare(0, 3, "the fouth card");
            result.ActiveMeeting.BingoCard.Squares[0, 4] = new CardSquare(0, 4, "this is the fifth card");
            
            result.ActiveMeeting.BingoCard.Squares[1, 0] = new CardSquare(1, 0, "a card");
            result.ActiveMeeting.BingoCard.Squares[1, 1] = new CardSquare(1, 1, "two cards", shouldSelectItemsForTest);
            result.ActiveMeeting.BingoCard.Squares[1, 2] = new CardSquare(1, 2, "a third card");
            result.ActiveMeeting.BingoCard.Squares[1, 3] = new CardSquare(1, 3, "the fouth card");
            result.ActiveMeeting.BingoCard.Squares[1, 4] = new CardSquare(1, 4, "this is the fifth card", shouldSelectItemsForTest);
            
            result.ActiveMeeting.BingoCard.Squares[2, 0] = new CardSquare(2, 0, "a card");
            result.ActiveMeeting.BingoCard.Squares[2, 1] = new CardSquare(2, 1, "two cards");
            result.ActiveMeeting.BingoCard.Squares[2, 2] = new CardSquare(2, 2, "FREE", shouldSelectItemsForTest);
            result.ActiveMeeting.BingoCard.Squares[2, 3] = new CardSquare(2, 3, "the fouth card");
            result.ActiveMeeting.BingoCard.Squares[2, 4] = new CardSquare(2, 4, "this is the fifth card");
            
            result.ActiveMeeting.BingoCard.Squares[3, 0] = new CardSquare(3, 0, "a card");
            result.ActiveMeeting.BingoCard.Squares[3, 1] = new CardSquare(3, 1, "two cards");
            result.ActiveMeeting.BingoCard.Squares[3, 2] = new CardSquare(3, 2, "a third card");
            result.ActiveMeeting.BingoCard.Squares[3, 3] = new CardSquare(3, 3, "the fouth card", shouldSelectItemsForTest);
            result.ActiveMeeting.BingoCard.Squares[3, 4] = new CardSquare(3, 4, "this is the fifth card");
            
            result.ActiveMeeting.BingoCard.Squares[4, 0] = new CardSquare(4, 0, "a card");
            result.ActiveMeeting.BingoCard.Squares[4, 1] = new CardSquare(4, 1, "two cards");
            result.ActiveMeeting.BingoCard.Squares[4, 2] = new CardSquare(4, 2, "a third card");
            result.ActiveMeeting.BingoCard.Squares[4, 3] = new CardSquare(4, 3, "the fouth card");
            result.ActiveMeeting.BingoCard.Squares[4, 4] = new CardSquare(4, 4, "this is the fifth card");


            return result;
        
        }


        public GameContext GetGameContextUpdateOnly(ClientStateData clientStateData, DateTime serverTimeOfLastUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
