using lab_03.BL.Models;
using lab_03.BL.Services;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FootballLeague.WindowFormViews
{
    public partial class MatchForm : Form
    {
        private int idleague;
        private MatchService matchService;

        public MatchForm(MatchService mService, int idleague)
        {
            InitializeComponent();
            this.idleague = idleague;
            matchService = mService;
            Loadd();
        }

        public void Loadd()
        {
            List<Match> matches = matchService.getMatchByIdLeague(idleague);
            foreach (Match match in matches)
            {
                int id = match.Id;
                string homeName = matchService.getNameClubById(match.IdHomeTeam);
                string guestName = matchService.getNameClubById(match.IdGuestTeam);
                string homeGoal = "--";
                if (match.GoalHomeTeam != -1)
                    homeGoal = match.GoalHomeTeam.ToString();
                string guestGoal = "--";
                if (match.GoalGuestTeam != -1)
                    guestGoal = match.GoalGuestTeam.ToString();
                dgv.Rows.Add(id, homeName, homeGoal, guestGoal, guestName);
            }
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idMatch = (int)dgv.CurrentRow.Cells[0].Value;
            ScoreMatchForm smf = new ScoreMatchForm(matchService, idMatch);
            smf.ShowDialog();
        }
    }
}
