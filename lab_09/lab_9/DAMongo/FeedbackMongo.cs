using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_9.DAMongo;

namespace lab_09.DAMongo
{
    public class FeedbackMongo : IFeedbackRepository
    {
        //private string connectionString = "";
        //private string database = "PPO2024";
        //private string collectionName = "feedbacks";
        private IMongoCollection<Feedback> feedbacks;
        public FeedbackMongo()
        {
            //connectionString = connectionStr;
            //var client = new MongoClient(connectionString);
            //var db = client.GetDatabase(database);
            feedbacks = DataProvider.Instance.getFeedbackCollection();
        }
        public List<Feedback> readAll()
        {
            return feedbacks.Find(_ => true).ToList();
        }

        public void create(Feedback feedback)
        {
            feedback.Id = readAll().Count + 1;
            feedbacks.InsertOne(feedback);
        }

        public List<Feedback> readbyIDLeague(int id)
        {
            return feedbacks.AsQueryable().Where(f => f.IdLeague == id).ToList();
        }

    }
}
