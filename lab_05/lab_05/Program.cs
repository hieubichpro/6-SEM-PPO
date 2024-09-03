using lab_03.BL.IRepositories;
using lab_03.BL.Services;
using lab_04.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserRepository userRepo = new UserRepository();
            ILeagueRepository leagueRepo = new LeagueRepository();
            IClubRepository clubRepo = new ClubRepository();
            IFeedbackRepository feedbackRepo = new FeedbackRepository();
            IMatchRepository matchRepo = new MatchRepository();

            UserService userService = new UserService(userRepo);
            LeagueService leagueService = new LeagueService(leagueRepo, matchRepo, clubRepo);
            ClubService clubService = new ClubService(clubRepo);
            FeedbackService feedbackService = new FeedbackService(feedbackRepo);
            MatchService matchService = new MatchService(matchRepo, clubRepo);
            TechUI techUI = new TechUI(userService, leagueService, clubService, feedbackService, matchService);
            techUI.openMainView();
        }
    }
}
