using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04.DA
{
    public class MatchRepository : IMatchRepository
    {
        public void create(Match match)
        {
            string query = "insert into matches(id_league, id_home_club, id_guest_club) values (" + match.IdLeague + ", " + match.IdHomeTeam + ", " + match.IdGuestTeam + ");";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void update(Match match)
        {
            string query = "update matches set goal_home_club = " + match.GoalHomeTeam + ", goal_guest_club = " + match.GoalGuestTeam + " where id = " + match.Id + ";";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public List<Match> readByIdLeague(int id_league)
        {
            string query = "select * from matches where id_league = " + id_league + ";";
            NpgsqlDataReader reader = DataProvider.Instance.ExecuteQuery(query);
            List<Match> matches = new List<Match>();
            while (reader.Read())
            {
                int homeGoal = -1;
                int guestGoal = -1;
                if (!reader.IsDBNull(1))
                    homeGoal = reader.GetInt32(1);
                if (!reader.IsDBNull(2))
                    guestGoal = reader.GetInt32(2);
                matches.Add(new Match(reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), homeGoal, guestGoal, reader.GetInt32(0)));

            }
            reader.Close();
            return matches;
        }

        public Match readByID(int id)
        {
            string query = "select * from matches where id = " + id + ";";
            NpgsqlDataReader reader = DataProvider.Instance.ExecuteQuery(query);
            reader.Read();
            Match curr = null;
            if (reader.HasRows)
            {
                int homeGoal = -1;
                int guestGoal = -1;
                if (!reader.IsDBNull(1))
                    homeGoal = reader.GetInt32(1);
                if (!reader.IsDBNull(2))
                    guestGoal = reader.GetInt32(2);
                curr = new Match(reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), homeGoal, guestGoal, reader.GetInt32(0));
            }
            reader.Close();
            return curr;
        }

        public List<Match> readAll()
        {
            string query = "select * from matches;";
            NpgsqlDataReader reader = DataProvider.Instance.ExecuteQuery(query);
            List<Match> matches = new List<Match>();
            while (reader.Read())
            {
                int homeGoal = -1;
                int guestGoal = -1;
                if (!reader.IsDBNull(1))
                    homeGoal = reader.GetInt32(1);
                if (!reader.IsDBNull(2))
                    guestGoal = reader.GetInt32(2);
                matches.Add(new Match(reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), homeGoal, guestGoal, reader.GetInt32(0)));

            }
            reader.Close();
            return matches;
        }
    }
}
