using lab_03.BL.Models;
using lab_03.BL.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FootballLeague.WindowFormViews
{
    public partial class LeagueForm : Form
    {
        private UserService userService;
        private LeagueService leagueService;
        private ClubService clubService;
        private FeedbackService feedbackService;
        private MatchService matchService;
        public LeagueForm(UserService userService, LeagueService leagueService, ClubService clubService, FeedbackService feedbackService, MatchService matchService)
        {
            InitializeComponent();
            this.userService = userService;
            this.leagueService = leagueService;
            this.clubService = clubService;
            this.feedbackService = feedbackService;
            this.matchService = matchService;
        }

        private void LeagueForm_Load(object sender, EventArgs e)
        {
            showAllLeagueInfo();
        }

        private void showAllLeagueInfo()
        {
            dgvLeague.Rows.Clear();
            List<League> leagues = leagueService.getAll();
            foreach (var l in leagues)
            {
                dgvLeague.Rows.Add(l.Id, l.Name, l.Rating.ToString());
            }
            //dgvLeague.DataSource = leagueService.getAllLeagueInfo();
        }

        private void dgvLeague_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLeague.CurrentRow.Cells[0].Value == null || dgvLeague.CurrentRow.Cells[0].Value == DBNull.Value)
                return;
            int id_league = (int)dgvLeague.CurrentRow.Cells[0].Value;
            dgvTable.DataSource = leagueService.getTableLeague(id_league);
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            int id_league = (int)dgvLeague.CurrentRow.Cells[0].Value;
            int grade = Int32.Parse(cbbRating.Text);
            feedbackService.insertFeedback(grade, id_league);
            showAllLeagueInfo();
        }
    }
}
