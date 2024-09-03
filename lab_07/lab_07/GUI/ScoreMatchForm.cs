using lab_03.BL.Services;
using System;
using System.Windows.Forms;

namespace FootballLeague.WindowFormViews
{
    public partial class ScoreMatchForm : Form
    {
        private int id;
        private MatchService matchService;
        public ScoreMatchForm(MatchService matchService, int id)
        {
            InitializeComponent();
            this.matchService = matchService;
            this.id = id;
        }
        private void ScoreMatchForm_Load(object sender, EventArgs e)
        {
            LoadMatch();
        }

        private void LoadMatch()
        {
            var m = matchService.getById(id);
            labelHomeName.Text = matchService.getNameClubById(m.IdHomeTeam);
            labelNameGuest.Text = matchService.getNameClubById(m.IdGuestTeam);
            textBoxHomeGoal.Text = m.GoalHomeTeam != -1 ? m.GoalHomeTeam.ToString() : "-";
            textBoxGuestGoal.Text = m.GoalGuestTeam != -1 ? m.GoalGuestTeam.ToString() : "-";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            matchService.EnterScore(id, Int32.Parse(textBoxHomeGoal.Text), Int32.Parse(textBoxGuestGoal.Text));
            this.Close();
        }

    }
}
