using lab_03.BL.Models;
using lab_03.BL.Services;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05
{
    public class TechUI
    {
        private Logger log;
        private UserService userService;
        private LeagueService leagueService;
        private ClubService clubService;
        private FeedbackService feedbackService;
        private MatchService matchService;

        public TechUI(UserService user, LeagueService league, ClubService club, FeedbackService feedback, MatchService match)
        {
            log = LogManager.GetLogger("LoggerMatchService");
            this.userService = user;
            this.leagueService = league;
            this.clubService = club;
            this.feedbackService = feedback;
            this.matchService = match;
        }

        public void openMainView()
        {
            int choice;
            do
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Guest");
                Console.WriteLine("2. Sign in");
                Console.WriteLine("3. Sign up");
                Console.WriteLine("Command: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        forGuest();
                        break;
                    case 2:
                        signIn();
                        break;
                    case 3:
                        signUp();
                        break;
                    case 0:
                        //exit();
                        break;
                    default:
                        Console.WriteLine("don't exists");
                        break;
                }
            } while (choice != 0);
        }

        public void forGuest()
        {
            log.Info("A guest was login");
            int choice;
            do
            {
                Console.WriteLine("0. Close");
                Console.WriteLine("1. Print schedule of a league");
                Console.WriteLine("2. Print all clubs");
                Console.WriteLine("3. Print all leagues");
                Console.WriteLine("4. Rating a league");
                Console.WriteLine("Command: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        printSchedule();
                        break;
                    case 2:
                        printAllClubs();
                        break;
                    case 3:
                        printAllLeagues();
                        break;
                    case 4:
                        ratingLeague();
                        break;
                    default:
                        break;
                }
            } while (choice != 0);
            log.Info("A guest was log out");
        }

        void printSchedule()
        {
            log.Info("print schedule started");
            Console.WriteLine("Enter id league: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var matches = matchService.getMatchByIdLeague(id);
            foreach (var m in matches)
            {
                Console.WriteLine($"{m.Id}, {clubService.getNameClubById(m.IdHomeTeam)} vs {clubService.getNameClubById(m.IdGuestTeam)}");
            }
            log.Info("print schedule ended");
        }

        public void printAllClubs()
        {
            log.Info("print clubs started");

            var clubs = clubService.getAll();
            foreach (var club in clubs)
            {
                Console.WriteLine($"{club.Id}, {club.Name}");
            }
            log.Info("print clubs ended");
        }

        public void printAllLeagues()
        {
            log.Info("print leagues started");
            var leagues = leagueService.getAll();
            foreach (var league in leagues)
            {
                Console.WriteLine($"{league.Id}, {league.Name}, {league.Rating}");
            }
            log.Info("print leagues ended");

        }
        public void ratingLeague()
        {
            log.Info("rating started");
            int idLeague;
            int rate;
            Console.WriteLine("Enter id league: ");
            idLeague = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate: ");
            rate = Convert.ToInt32(Console.ReadLine());
            feedbackService.insertFeedback(rate, idLeague);
            log.Info("rating ended");
        }

        public void signIn()
        {
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            User user = userService.Login(username, password);
            if (user != null)
            {
                switch (user.Role)
                {
                    case "Referee":
                        forReferee(user);
                        break;
                    case "Admin":
                        forAdmin(user);
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
            else
            {
                Console.WriteLine("username or password invalid");
            }
        }
        public void signUp()
        {
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Reenter password: ");
            string repassword = Console.ReadLine();
            Console.WriteLine("Enter role: ");
            string role = Console.ReadLine();
            User user = userService.Register(username, password, role);
            if (user != null)
            {
                Console.WriteLine("Registration successfully");
            }
        }
        public void createClub(User user)
        {
            Console.WriteLine("Enter name club: ");
            string name = Console.ReadLine();
            clubService.insertClub(name);
        }

        public void forReferee(User user)
        {
            log.Info("A refeeree was log in");
            int choice;
            do
            {
                Console.WriteLine("1. Log out");
                Console.WriteLine("2. Print schedule of a league");
                Console.WriteLine("3. Rating a league");
                Console.WriteLine("4. Enter score of the match");
                Console.WriteLine("5. Show/Create/Delete/Modify club");
                Console.WriteLine("6. Show/Create/Delete/Modify league");
                Console.WriteLine("Enter command: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 2:
                        printSchedule();
                        break;
                    case 3:
                        ratingLeague();
                        break;
                    case 4:
                        enterScore();
                        break;
                    case 5:
                        workWithClub();
                        break;
                    case 6:
                        workWithLeague(user);
                        break;
                }
            } while (choice != 1);
            log.Info("A referee was log out");
        }

        public void createLeague(User user)
        {
            Console.WriteLine("Enter name League: ");
            string name = Console.ReadLine();
            leagueService.insertLeague(name, 5, user.Id);
        }

        public void forAdmin(User user)
        {
            log.Info("A admin was log in");
            int choice;
            do
            {
                Console.WriteLine("1. Log out");
                Console.WriteLine("2. Print schedule of a league");
                Console.WriteLine("3. Rating a league");
                Console.WriteLine("4. Enter score of the match");
                Console.WriteLine("5. Show/Create/Delete/Modify a club");
                Console.WriteLine("6. Show/Create/Delete/Modify a league");
                Console.WriteLine("7. Show/Create/Delete/Modify users");
                Console.WriteLine("Enter command: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 2:
                        printSchedule();
                        break;
                    case 3:
                        ratingLeague();
                        break;
                    case 4:
                        enterScore();
                        break;
                    case 5:
                        workWithClub();
                        break;
                    case 6:
                        workWithLeague(user);
                        break;
                    case 7:
                        workWithUsers();
                        break;
                }
            } while (choice != 1);
            log.Info("A admin was log out");
        }

        public void enterScore()
        {
            Console.WriteLine("Enter id match: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter home goals: ");
            int homeGoal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter guest goals: ");
            int guestGoal = Convert.ToInt32(Console.ReadLine());
            matchService.EnterScore(id, homeGoal, guestGoal);
        }

        public void workWithClub()
        {
            int choice;
            do
            {
                Console.WriteLine("0. Back");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Modify");
                Console.WriteLine("3. Delete");
                Console.WriteLine("4. Show all");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addClub();
                        break;
                    case 2:
                        modifyClub();
                        break;
                    case 3:
                        deleteClub();
                        break;
                    case 4:
                        printAllClubs();
                        break;
                }
            } while (choice != 0);
        }
        public void addClub()
        {
            Console.WriteLine("Enter name of club");
            string name = Console.ReadLine();
            clubService.insertClub(name);
        }
        public void modifyClub()
        {
            Console.WriteLine("Enter id club: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new name: ");
            string name = Console.ReadLine();
            clubService.modifyClub(id, name);
        }
        public void deleteClub()
        {
            Console.WriteLine("Enter id club: ");
            int id = Convert.ToInt32(Console.ReadLine());
            clubService.deleteClub(id);
        }
        public void workWithLeague(User user)
        {
            int choice;
            do
            {
                Console.WriteLine("0. Back");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Modify");
                Console.WriteLine("3. Delete");
                Console.WriteLine("4. Show all");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addLeague(user);
                        break;
                    case 2:
                        modifyLeague();
                        break;
                    case 3:
                        deleteLeague();
                        break;
                    case 4:
                        printAllLeagues();
                        break;
                }
            } while (choice != 0);
        }
        public void addLeague(User user)
        {
            Console.WriteLine("Enter name of league");
            string name = Console.ReadLine();
            leagueService.insertLeague(name, 5, user.Id);
        }
        public void modifyLeague()
        {
            Console.WriteLine("Enter id league: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter new rating: ");
            double rating = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter new id_user: ");
            int idUser = Convert.ToInt32(Console.ReadLine());
            leagueService.modifyLeague(id, name, rating, idUser);
        }
        public void deleteLeague()
        {
            Console.WriteLine("Enter id league: ");
            int id = Convert.ToInt32(Console.ReadLine());
            leagueService.deleteLeague(id);
        }
        public void workWithUsers()
        {
            int choice;
            do
            {
                Console.WriteLine("0. Back");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Modify");
                Console.WriteLine("3. Delete");
                Console.WriteLine("4. Show all");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addUser();
                        break;
                    case 2:
                        modifyUser();
                        break;
                    case 3:
                        deleteUser();
                        break;
                    case 4:
                        printAllUsers();
                        break;
                }
            } while (choice != 0);
        }
        public void addUser()
        {
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            Console.WriteLine("Enter password again");
            string rePassword = Console.ReadLine();
            Console.WriteLine("Enter role");
            string role = Console.ReadLine();
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            userService.Register(username, password, role, name);
        }
        public void modifyUser()
        {
            Console.WriteLine("Enter id user to modify");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            Console.WriteLine("Enter password again");
            string rePassword = Console.ReadLine();
            Console.WriteLine("Enter role");
            string role = Console.ReadLine();
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            userService.ChangeInfo(id, username, password, role, name);
        }

        public void deleteUser()
        {
            Console.WriteLine("Enter id user to delete");
            int id = Convert.ToInt32(Console.ReadLine());
            userService.deleteUser(id);
        }
        public void printAllUsers()
        {
            var users = userService.getAll();
        }
    }
}
