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
        public List<ClubStat> getAllStatistic(int id_league)
        {
            string query = $"select * from get_table_league({id_league});";
            NpgsqlDataReader reader = DataProvider.Instance.ExecuteQuery(query);
            List<ClubStat> res = new List<ClubStat>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(new ClubStat(reader.GetString(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8), reader.GetInt32(9)));
                }
            }
            reader.Close();
            return res;
        }
    }
}
