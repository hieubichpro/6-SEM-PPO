using System;
using System.Collections.Generic;
using System.Data;
using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using Npgsql;

namespace lab_04.DA
{
    public class UserRepository : IUserRepository
    {
        public User readById(int id)
        {
            string query = "select * from users where id = " + id + ";";
            NpgsqlDataReader reader = DataProvider.Instance.ExecuteQuery(query);
            reader.Read();
            User curr = null;
            if (reader.HasRows)
            {
                curr = new User(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(0));
            }
            reader.Close();
            return curr;
        }
        public User readByLogin(string login)
        {
            string query = "select * from users where login = '" + login + "';";
            NpgsqlDataReader reader = DataProvider.Instance.ExecuteQuery(query);
            reader.Read();
            User curr = null;
            if (reader.HasRows)
            {
                curr = new User(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(0));
            }
            reader.Close();
            return curr;
        }
        public List<User> readByRole(string role)
        {
            string query = "select * from users where role = '" + role + "';";
            NpgsqlDataReader reader = DataProvider.Instance.ExecuteQuery(query);
            List<User> res = new List<User>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(new User(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(0)));
                }
            }
            reader.Close();
            return res;
        }
        public void create(User user)
        {
            string query = "insert into users(login, password, role, name) values ('" + user.Login + "', '" + user.Password + "', '" + user.Role + "', '" + user.Name  + "');";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void update(User user)
        {
            string query = "update users set login = '" + user.Login + "', " + " name = '" + user.Name + "', password = '" + user.Password + " where id = " + user.Id + ";";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void delete(int id)
        {
            string query = "delete from users where id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
