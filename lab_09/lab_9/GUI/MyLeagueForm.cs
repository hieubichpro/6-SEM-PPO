﻿using lab_03.BL.Models;
using lab_03.BL.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FootballLeague.WindowFormViews
{
    public partial class MyLeagueForm : Form
    {
        private User user;
        private UserService userService;
        private LeagueService leagueService;
        private ClubService clubService;
        private FeedbackService feedbackService;
        private MatchService matchService;
        public MyLeagueForm(User user, UserService userService, LeagueService leagueService, ClubService clubService, FeedbackService feedbackService, MatchService matchService)
        {
            InitializeComponent();
            this.user = user;
            this.userService = userService;
            this.leagueService = leagueService;
            this.clubService = clubService;
            this.feedbackService = feedbackService;
            this.matchService = matchService;
        }
        private void showAllMyLeague()
        {
            dgvMyLeague.Rows.Clear();
            List<League> leagues = leagueService.getByIdUser(user.Id);
            foreach (var l in leagues)
            {
                dgvMyLeague.Rows.Add(l.Id, l.Name, l.Rating.ToString());
            }
        }

        private void MyLeagueForm_Load(object sender, EventArgs e)
        {
            showAllMyLeague();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id_league = (int)dgvMyLeague.CurrentRow.Cells[0].Value;
            leagueService.deleteLeague(id_league);
            MessageBox.Show("League was deleted");
            showAllMyLeague();
        }



        private void dgvMyLeague_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idLeague = (int)dgvMyLeague.CurrentRow.Cells[0].Value;
            MatchForm m = new MatchForm(matchService, idLeague);
            m.ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbName.Text != null && tbRating.Text != null)
            {
                string name = tbName.Text;
                double rating = Convert.ToDouble(tbRating.Text);
                leagueService.insertLeague(name, rating, user.Id);
            }
        }

        private void dgvMyLeague_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMyLeague.CurrentRow.Cells[0].Value != null)
            {
                int id = (int)dgvMyLeague.CurrentRow.Cells[0].Value;
                var l = leagueService.getById(id);
                tbName.Text = l.Name;
                tbRating.Text = l.Rating.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button was clicked");
            int id = (int)dgvMyLeague.CurrentRow.Cells[0].Value;
            Console.WriteLine(id);
            leagueService.Schedule(id);
        }
    }
}