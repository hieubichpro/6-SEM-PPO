
using lab_03.BL.Services;
using lab_03.BL.Models;
using System;
using System.Windows.Forms;
using lab_07.GUI;
using WindowFormViews;

namespace WindowFormViews
{
    public partial class LoginForm : Form
    {
        private UserService userService;
        private LeagueService leagueService;
        private ClubService clubService;
        private FeedbackService feedbackService;
        private MatchService matchService;
        public LoginForm(UserService userService, LeagueService leagueService, ClubService clubService, FeedbackService feedbackService, MatchService matchService)
        {
            InitializeComponent();
            this.userService = userService;
            this.leagueService = leagueService;
            this.clubService = clubService;
            this.feedbackService = feedbackService;
            this.matchService = matchService;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registration r = new Registration(userService);
            r.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = textboxUsername.Text;
            string password = textboxPassword.Text;
            User user = userService.Login(login, password);
            if (user != null)
            {
                switch (user.Role)
                {
                    case "Referee":
                        RefereeForm f = new RefereeForm(user, userService, matchService, leagueService, clubService, feedbackService);
                        f.ShowDialog();
                        break;
                    case "Admin":
                        MainForm a = new MainForm(user, userService, leagueService, clubService, feedbackService, matchService);
                        a.ShowDialog();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (textboxPassword.PasswordChar == '*')
            {
                btnHide.BringToFront();
                textboxPassword.PasswordChar = '\0';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (textboxPassword.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                textboxPassword.PasswordChar = '*';
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            GuestForm g = new GuestForm(userService, leagueService, clubService, feedbackService, matchService);
            g.ShowDialog();

        }
    }
}
