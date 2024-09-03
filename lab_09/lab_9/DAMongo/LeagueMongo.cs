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
    public class LeagueMongo : ILeagueRepository
    {
        //private string connectionString = "";
        //private string database = "PPO2024";
        //private string collectionName1 = "leagues";
        //private string collectionName2 = "clubleagues";
        private IMongoCollection<League> leagues;
        //private IMongoCollection<ClubLeague> clubleagues;
        public LeagueMongo()
        {
            //connectionString = connectionStr;
            //var client = new MongoClient(connectionString);
            //var db = client.GetDatabase(database);
            leagues = DataProvider.Instance.getLeaguesCollection();
            //clubleagues = db.GetCollection<ClubLeague>(collectionName2);

        }
        public League readbyName(string name)
        {
            return leagues.AsQueryable().Where(l => l.Name == name).FirstOrDefault();
        }
        public void create(League league)
        {
            league.Id = readAll().Count + 1;
            leagues.InsertOne(league);
        }
        public void deleteById(int id_league)
        {
            var filter = Builders<League>.Filter.Eq(l => l.Id, id_league);
            leagues.DeleteOne(filter);
        }
        public League readById(int id)
        {
            return leagues.AsQueryable().Where(l => l.Id == id).FirstOrDefault();
        }
        public List<League> readAll()
        {
            return leagues.Find(_ => true).ToList();
        }
        public void update(League league)
        {
            leagues.ReplaceOne(l => l.Id == l.Id, league);

        }
        public List<League> readByIdUser(int id)
        {
            return leagues.AsQueryable().Where(l => l.IdUser == id).ToList();
        }
    }
}
