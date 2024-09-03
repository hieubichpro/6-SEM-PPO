using lab_03.BL.IRepositories;
using lab_03.BL.Services;
using lab_04.DA;
using lab_08.BL.IRepositories;
using lab_08.BL.Services;
using lab_08.DA;
using lab_09.DAMongo;
using lab_9.BL.IRepositories;
using lab_9.DA;
using lab_9.DAMongo;
using Microsoft.Extensions.Configuration;
using System;
using System.Windows.Forms;
using WindowFormViews;

namespace lab_9
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
            var useDB = config.GetSection("App").GetSection("UseDB").Value;
            connectionString = config.GetSection("MongoDB").GetSection("ConnectionString").Value;

            IUserRepository userRepo = new UserMongo();
            ILeagueRepository leagueRepo = new LeagueMongo();
            IClubRepository clubRepo = new ClubMongo();
            IFeedbackRepository feedbackRepo = new FeedbackMongo();
            IMatchRepository matchRepo = new MatchMongo();
            IClubStatRepository clubStatRepo = new ClubStatMongo();
            IClubLeagueRepository clubleagueRepo = new ClubLeagueMongo();

            if (useDB == "PostgreSQL")
            {
                connectionString = config.GetSection("PostgreSQL").GetSection("ConnectionString").Value; ;
                userRepo = new UserRepository();
                leagueRepo = new LeagueRepository();
                clubRepo = new ClubRepository();
                feedbackRepo = new FeedbackRepository();
                matchRepo = new MatchRepository();
                clubStatRepo = new ClubStatRepository();
                clubleagueRepo = new ClubLeagueRepository();
            }

            UserService userService = new UserService(userRepo);
            LeagueService leagueService = new LeagueService(leagueRepo, matchRepo, clubRepo, clubleagueRepo);
            ClubService clubService = new ClubService(clubRepo);
            FeedbackService feedbackService = new FeedbackService(feedbackRepo);
            MatchService matchService = new MatchService(matchRepo, clubRepo);
            ClubStatService clubStatService = new ClubStatService(clubStatRepo, matchRepo, clubRepo);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm(userService, leagueService, clubService, feedbackService, matchService, clubStatService));
        }
    }
}
