using lab_03.BL.IRepositories;
using lab_03.BL.Services;
using lab_04.DA;
using lab_05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using NLog;
namespace lab_06
{
    public class Program
    {
        public static string connectionString;
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("dbsettings.json");
            var config = configuration.Build();
            connectionString = config.GetConnectionString("DefaultConnection");

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
