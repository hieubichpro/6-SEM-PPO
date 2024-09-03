using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using Npgsql;

namespace lab_04.DA
{
    public class LeagueRepository : ILeagueRepository
    {
        public League readbyName(string name)
        {
            string query = "select * from leagues where name = '" + name + "';";
            NpgsqlDataReader reader = DataProvider.Instance.ExecuteQuery(query);
            reader.Read();
            League curr = null;
            if (reader.HasRows)
                curr = new League(reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3), reader.GetInt32(0));
            reader.Close();
            return curr;

        }
        public void create(League league)
        {
            string query = "insert into leagues(name, rating, id_user) values ('" + league.Name + "', " + league.Rating + ", " + league.IdUser  + ");";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void deleteById(int id_league)
        {
            string query = "delete from leagues where id = " + id_league;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public League readById(int id)
        {
            string query = "select * from leagues where id = " + id + ";";
            NpgsqlDataReader reader = DataProvider.Instance.ExecuteQuery(query);
            reader.Read();
            League curr = null;
            if (reader.HasRows)
            {
                curr = new League(reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3), reader.GetInt32(0));
            }
            reader.Close();
            return curr;
        }
        public List<League> readAll()
        {
            string query = "select * from leagues;";
            NpgsqlDataReader reader = DataProvider.Instance.ExecuteQuery(query);
            List<League> res = new List<League>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(new League(reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3), reader.GetInt32(0)));
                }
            }
            reader.Close();
            return res;
        }

        public void update(League l)
        {
            string query = "update leagues set name = '" + l.Name + "', rating = " + l.Rating + " id_user = " + l.IdUser + " where id = " + l.Id + ";";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable getTable(int id)
        {
            string query = "select * from get_table_league(" + id + ");";
            return DataProvider.Instance.getDataTable(query);
        }

    }
}
