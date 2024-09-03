
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
    public class FeedbackRepository : IFeedbackRepository
    {
        public void create(Feedback feedback)
        {
            string query = "insert into feedbacks(grade, id_league) values"
                          + " (" + feedback.Grade + ", "+ feedback.IdLeague + ");";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public List<Feedback> readbyIDLeague(int id)
        {
            string query = "select * from feedbacks where id_league = " + id + ";";
            var reader = DataProvider.Instance.ExecuteQuery(query);
            List<Feedback> res = new List<Feedback>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(new Feedback(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(0)));
                }
            }
            reader.Close();
            return res;
        }
    }
}
