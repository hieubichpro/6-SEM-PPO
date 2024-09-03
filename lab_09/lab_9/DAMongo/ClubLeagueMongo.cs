using lab_03.BL.Models;
using lab_9.BL.IRepositories;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9.DAMongo
{
    public class ClubLeagueMongo : IClubLeagueRepository
    {
        //private string connectionString = "";
        //private string database = "PPO2024";
        //private string collectionName = "clubleagues";
        private IMongoCollection<ClubLeague> clubleagues;
        public ClubLeagueMongo()
        {
            //connectionString = connectionStr;
            //var client = new MongoClient(connectionString);
            //var db = client.GetDatabase(database);
            clubleagues = DataProvider.Instance.getClubLeagueCollection();
        }
        public void create(ClubLeague cl)
        {
            cl.Id = getAll().Count + 1;
            clubleagues.InsertOne(cl);
        }
        public List<ClubLeague> getAll()
        {
            return clubleagues.Find(_ => true).ToList();
        }
        public List<ClubLeague> getClubInLeague(int idleague)
        {
             return clubleagues.AsQueryable().Where(el => el.IdLeague == idleague).ToList();
        }
    }
}
