using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using lab_9.DAMongo;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_09.DAMongo
{
    public class ClubMongo : IClubRepository
    {
        //private string connectionString = "";
        //private string database = "PPO2024";
        //private string collectionName = "clubs";
        private IMongoCollection<Club> clubs;
        public ClubMongo()
        {
            //connectionString = connectionStr;
            //var client = new MongoClient(connectionString);
            //var db = client.GetDatabase(database);
            clubs = DataProvider.Instance.getClubCollection();
        }
        public Club readbyName(string name)
        {
            return clubs.AsQueryable().Where(c => c.Name == name).FirstOrDefault();
        }
        public Club readbyId(int id)
        {
            return clubs.AsQueryable().Where(c => c.Id == id).FirstOrDefault();
        }
        public void create(Club club)
        {
            club.Id = readAll().Count + 1;
            clubs.InsertOne(club);
        }
        public List<Club> readAll()
        {
            return clubs.Find(_ => true).ToList();
        }
        public void update(Club club)
        {
            clubs.ReplaceOne(c => c.Id == club.Id, club);
        }
        public void delete(int id)
        {
            var filter = Builders<Club>.Filter.Eq(c => c.Id, id);
            clubs.DeleteOne(filter);
        }
    }
}
