using FootballLeague.WindowFormViews;
using lab_03.BL.Models;
using lab_03.BL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_07.GUI
{
    public partial class RefereeForm : Form
    {
        private User user;
        private UserService userService;
        private MatchService matchService;
        private LeagueService leagueService;
        private ClubService clubService;
        private FeedbackService feedbackService;
        public RefereeForm(User user, UserService userService, MatchService matchService, LeagueService leagueService, ClubService clubService, FeedbackService feedbackService)
        {
            InitializeComponent();
            this.user = user;
            this.userService = userService;
            this.matchService = matchService;
            this.leagueService = leagueService;
            this.clubService = clubService;
            this.feedbackService = feedbackService;
            labelName.Text = user.Name;
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
            childForm.AutoScaleMode = AutoScaleMode.None;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnLeague_Click(object sender, EventArgs e)
        {
            openChildForm(new LeagueForm(userService, leagueService, clubService, feedbackService, matchService));
        }

        private void btnClub_Click(object sender, EventArgs e)
        {
            openChildForm(new ClubForm(clubService));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMyLeague_Click(object sender, EventArgs e)
        {
            openChildForm(new MyLeagueForm(user, userService, leagueService, clubService, feedbackService, matchService));
        }
    }
}
