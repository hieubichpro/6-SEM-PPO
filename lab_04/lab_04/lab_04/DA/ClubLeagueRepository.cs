using lab_03.BL.Models;
using lab_04.DA;
using lab_9.BL.IRepositories;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9.DA
{
    public class ClubLeagueRepository : IClubLeagueRepository
    {
        public List<ClubLeague> getAll()
        {
            string query = "select * from leagueclub;";
            NpgsqlDataReader reader = DataProvider.Instance.ExecuteQuery(query);
            List<ClubLeague> res = new List<ClubLeague>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(new ClubLeague(reader.GetInt32(1), reader.GetInt32(2)));
                }
            }
            reader.Close();
            return res;
        }
        public void create(ClubLeague cl)
        {
            string query = $"insert into leagueclub(id_league, id_club) values ({cl.IdLeague}, {cl.IdClub});";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public List<ClubLeague> getClubInLeague(int idleague)
        {
            string query = "select * from leagueclub where id_league = " + idleague + ";";
            NpgsqlDataReader reader = DataProvider.Instance.ExecuteQuery(query);
            List<ClubLeague> res = new List<ClubLeague>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(new ClubLeague(reader.GetInt32(1), reader.GetInt32(2)));
                }
            }
            reader.Close();
            return res;
        }
    }
}
