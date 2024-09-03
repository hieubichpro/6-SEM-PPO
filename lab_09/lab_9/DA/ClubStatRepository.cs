using lab_04.DA;
using lab_08.BL.IRepositories;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_08.DA
{
    public class ClubStatRepository : IClubStatRepository
    {
        public void deleteAllByIdLeague(int idLeague)
        {
            string query = "delete from clubstat where id_league = " + idLeague + ";";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void create(ClubStat clubstat)
        {
            string query = $"insert into clubstat(id_league, name, allgames, matches, wins, draws, loses, goal1, goal2, diff, points) values ({clubstat.Id_league}, '{clubstat.Name}', {clubstat.Allgames}, {clubstat.Matches}, {clubstat.Wins}, {clubstat.Draws}, {clubstat.Loses}, {clubstat.Goal1}, {clubstat.Goal2}, {clubstat.Diff}, {clubstat.Points})";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public List<ClubStat> getAll()
        {
            string query = "select * from clubstat;";
            NpgsqlDataReader reader = DataProvider.Instance.ExecuteQuery(query);
            List<ClubStat> res = new List<ClubStat>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(new ClubStat(reader.GetInt32(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8), reader.GetInt32(9), reader.GetInt32(10), reader.GetInt32(11), reader.GetInt32(0)));
                }
            }
            reader.Close();
            return res;
        }
        public List<ClubStat> getAllByIdLeague(int idLeague)
        {
            string query = $"select * from clubstat where id_league = {idLeague};";
            NpgsqlDataReader reader = DataProvider.Instance.ExecuteQuery(query);
            List<ClubStat> res = new List<ClubStat>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(new ClubStat(reader.GetInt32(1),reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8), reader.GetInt32(9), reader.GetInt32(10), reader.GetInt32(11), reader.GetInt32(0)));
                }
            }
            reader.Close();
            return res;
        }
    }
}
