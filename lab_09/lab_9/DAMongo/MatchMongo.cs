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
    public class MatchMongo : IMatchRepository
    {
        //private string connectionString = "";
        //private string database = "PPO2024";
        //private string collectionName = "matches";
        private IMongoCollection<Match> matches;
        public MatchMongo()
        {
            //connectionString = connectionStr;
            //var client = new MongoClient(connectionString);
            //var db = client.GetDatabase(database);
            matches = DataProvider.Instance.getMatchCollection();
        }
        public void create(Match match)
        {
            match.Id = readAll().Count + 1;
            matches.InsertOne(match);
        }
        public void update(Match match)
        {
            matches.ReplaceOne(m => m.Id == match.Id, match);
        }
        public List<Match> readByIdLeague(int id_league)
        {
            return matches.AsQueryable().Where(m => m.IdLeague == id_league).ToList();
        }
        public Match readByID(int id)
        {
            return matches.AsQueryable().Where(m => m.Id == id).FirstOrDefault();
        }
        public List<Match> readAll()
        {
            return matches.Find(_ => true).ToList();
        }
    }
}
