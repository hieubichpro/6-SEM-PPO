using lab_03.BL.IRepositories;
using lab_03.BL.Services;
using lab_04.DA;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowFormViews;

namespace lab_07
{
    public static class Program
    {
        public static string connectionString;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm(userService, leagueService, clubService, feedbackService, matchService));
        }
    }
}
