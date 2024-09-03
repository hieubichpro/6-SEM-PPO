
using FootballLeague.WindowFormViews;
using lab_03.BL.Models;
using lab_03.BL.Services;
using System;
using System.Windows.Forms;
using lab_07.GUI;

namespace WindowFormViews
{
    public partial class MainForm : Form
    {
        private User user;
        private UserService userService;
        private LeagueService leagueService;
        private ClubService clubService;
        private FeedbackService feedbackService;
        private MatchService matchService;
        public MainForm(User user, UserService userService, LeagueService leagueService, ClubService clubService, FeedbackService feedbackService, MatchService matchService)
        {
            InitializeComponent();
            this.user = user;
            this.userService = userService;
            this.leagueService = leagueService;
            this.clubService = clubService;
            this.feedbackService = feedbackService;
            this.matchService = matchService;
            lbName.Text = user.Name;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLeague_Click(object sender, EventArgs e)
        {
            openChildForm(new LeagueForm(userService, leagueService, clubService, feedbackService, matchService));
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnClub_Click(object sender, EventArgs e)
        {
            openChildForm(new ClubForm(clubService));
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm(userService));
        }

        //private void btnMyClub_Click(object sender, EventArgs e)
        //{
        //    user = userService.getUserById(user.Id);
        //    if (user.Role == "Coach" && user.IdClub == -1)
        //    {
        //        MessageBox.Show("You don't have any club. \nLet create your club first");
        //        NewClub nc = new NewClub(ref user, userService, clubService, countryService, feedbackService);
        //        nc.ShowDialog();

        //    }
        //    else if (user.Role == "Coach" && user.IdClub != -1)
        //    {
        //        openChildForm(new MyClubForm(ref user, userService, clubService, countryService, RequestService));
        //    }
        //}

        //private void btnMyLeague_Click(object sender, EventArgs e)
        //{
        //    if (user.Role == "Referee" && !leagueService.haveLeague(user.Id))
        //    {
        //        MessageBox.Show("You don't have any league. \nLet create your league first");
        //        NewLeague nl = new NewLeague(ref user, userService, leagueService, countryService, feedbackService);
        //        nl.ShowDialog();
        //    }
        //    else if (user.Role == "Referee" && leagueService.haveLeague(user.Id))
        //    {
        //        openChildForm(new MyLeagueForm(ref user, userService, leagueService, countryService, requestService, clubService, feedbackService, matchService));
        //    }
        //}
    }
}
