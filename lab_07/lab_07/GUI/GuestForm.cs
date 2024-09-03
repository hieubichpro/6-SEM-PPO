using FootballLeague.WindowFormViews;
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
    public partial class GuestForm : Form
    {
        private UserService userService;
        private LeagueService leagueService;
        private ClubService clubService;
        private FeedbackService feedbackService;
        private MatchService matchService;
        public GuestForm(UserService userService, LeagueService leagueService, ClubService clubService, FeedbackService feedbackService, MatchService matchService)
        {
            InitializeComponent();
            this.userService = userService;
            this.leagueService = leagueService;
            this.clubService = clubService;
            this.feedbackService = feedbackService;
            this.matchService = matchService;
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
            panel6.Controls.Add(childForm);
            panel6.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnLeague_Click(object sender, EventArgs e)
        {
            openChildForm(new LeagueForm(userService, leagueService, clubService, feedbackService, matchService));
        }

        private void btnClub_Click(object sender, EventArgs e)
        {
            openChildForm(new ClubForm(clubService, "Guest"));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
