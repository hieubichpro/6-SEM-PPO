
using System.Collections.Generic;
using System.Data;
using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using Npgsql;

namespace lab_04.DA
{
    public class ClubRepository : IClubRepository
    {
        public Club readbyName(string name)
        {
            string query = "select * from clubs where name = '" + name + "';";
            NpgsqlDataReader reader = DataProvider.Instance.ExecuteQuery(query);
            reader.Read();
            Club curr = null;
            if (reader.HasRows)
            {
                curr = new Club(reader.GetString(1), reader.GetInt32(0));
            }
            reader.Close();
            return curr;
        }

        public Club readbyId(int id)
        {
            string query = "select * from clubs where id = " + id + ";";
            NpgsqlDataReader reader = DataProvider.Instance.ExecuteQuery(query);
            reader.Read();
            Club curr = new Club(reader.GetString(1), reader.GetInt32(0));
            reader.Close();
            return curr;
        }
        public void create(Club club)
        {
            string query = "insert into clubs(name) values ('" + club.Name + "');";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public List<Club> readAll()
        {
            string query = "select * from clubs;";
            NpgsqlDataReader reader = DataProvider.Instance.ExecuteQuery(query);
            List<Club> res = new List<Club>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(new Club(reader.GetString(1), reader.GetInt32(0)));
                }
            }
            reader.Close();
            return res;
        }

        public void update(Club club)
        {
            string query = "update clubs set name = '" + club.Name + "' where id = " + club.Id + ";";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void delete(int id)
        {
            string query = "delete from clubs where id = " + id + ";";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
