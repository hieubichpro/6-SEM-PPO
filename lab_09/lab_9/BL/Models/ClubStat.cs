using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_08.DA
{
    public class ClubStat
    {
        private int id;
        private int id_league;
        private string name;
        private int allgames;
        private int matches;
        private int wins;
        private int draws;
        private int loses;
        private int goal1;
        private int goal2;
        private int diff;
        private int points;
        public ClubStat(int id_league, string name, int allgames, int matches, int wins, int draws, int loses, int goal1, int goal2, int diff, int points, int id = 1)
        {
            this.Id = id;
            this.Id_league = id_league;
            this.Name = name;
            this.Matches = matches;
            this.Wins = wins;
            this.Draws = draws;
            this.Loses = loses;
            this.Goal1 = goal1;
            this.Goal2 = goal2;
            this.Diff = diff;
            this.Points = points;
            this.Allgames = allgames;
        }

        public int Id { get => id; set => id = value; }
        public int Matches { get => matches; set => matches = value; }
        public int Wins { get => wins; set => wins = value; }
        public int Draws { get => draws; set => draws = value; }
        public int Loses { get => loses; set => loses = value; }
        public int Goal1 { get => goal1; set => goal1 = value; }
        public int Goal2 { get => goal2; set => goal2 = value; }
        public int Points { get => points; set => points = value; }
        public string Name { get => name; set => name = value; }
        public int Allgames { get => allgames; set => allgames = value; }
        public int Diff { get => diff; set => diff = value; }
        public int Id_league { get => id_league; set => id_league = value; }
    }
}
