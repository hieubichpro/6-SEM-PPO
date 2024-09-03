using lab_03.BL.Models;
using lab_08.DA;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9.DAMongo
{
    public class DataProvider
    {
        private static DataProvider instance;
        private IMongoDatabase db;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value; }
        }
        private DataProvider()
        {
            var client = new MongoClient(Program.connectionString);
            db = client.GetDatabase("PPO2024");
        }
        public IMongoCollection<User> getUserCollection()
        {
            return db.GetCollection<User>("users");
        }
        public IMongoCollection<Club> getClubCollection()
        {
            return db.GetCollection<Club>("clubs");
        }
        public IMongoCollection<Match> getMatchCollection()
        {
            return db.GetCollection<Match>("matches");
        }
        public IMongoCollection<League> getLeaguesCollection()
        {
            return db.GetCollection<League>("leagues");
        }
        public IMongoCollection<Feedback> getFeedbackCollection()
        {
            return db.GetCollection<Feedback>("feedbacks");
        }
        public IMongoCollection<ClubStat> getClubStatCollection()
        {
            return db.GetCollection<ClubStat>("clubstats");
        }
        public IMongoCollection<ClubLeague> getClubLeagueCollection()
        {
            return db.GetCollection<ClubLeague>("clubleagues");
        }


    }
}
