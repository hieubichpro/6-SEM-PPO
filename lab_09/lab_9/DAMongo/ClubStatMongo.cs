using lab_08.BL.IRepositories;
using lab_08.DA;
using lab_9.DAMongo;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_09.DAMongo
{
    public class ClubStatMongo : IClubStatRepository
    {
        //private string connectionString = "";
        //private string database = "PPO2024";
        //private string collectionName = "clubstats";
        private IMongoCollection<ClubStat> clubstats;
        public ClubStatMongo()
        {
            //connectionString = connectionStr;
            //var client = new MongoClient(connectionString);
            //var db = client.GetDatabase(database);
            clubstats = DataProvider.Instance.getClubStatCollection();
        }
        public List<ClubStat> getAll()
        {
            return clubstats.Find(_ => true).ToList();
        }
        public List<ClubStat> getAllByIdLeague(int idLeague)
        {
            return clubstats.AsQueryable().Where(l => l.Id_league == idLeague).ToList();
        }
        public void create(ClubStat clubstat)
        {
            clubstat.Id = getAll().Count + 1;
            clubstats.InsertOne(clubstat);
        }
        public void deleteAllByIdLeague(int idLeague)
        {
            var filter = Builders<ClubStat>.Filter.Eq(ct => ct.Id_league, idLeague);
            clubstats.DeleteMany(filter);
        }

    }
}
