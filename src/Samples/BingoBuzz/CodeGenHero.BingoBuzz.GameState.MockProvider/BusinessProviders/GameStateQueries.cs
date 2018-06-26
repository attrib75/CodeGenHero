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
                if (clientStateData.ActiveMeetingId != "")
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

            result.MeetingList = new List<Meeting>
            {
                new Meeting
                {
                    MeetingId = "",
                    Name = "Weekly stakeholders update.",
                    Winner = null,
                    CreatedDate = new DateTime(2018,3,2)


                }
            };



            result.ActiveMeeting = new Meeting
            {
                MeetingId = "",
                Name = "test active meeting",
                CreatedDate = new DateTime(2018, 3, 12);

            }
        }


        public GameContext GetGameContextUpdateOnly(ClientStateData clientStateData, DateTime serverTimeOfLastUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
