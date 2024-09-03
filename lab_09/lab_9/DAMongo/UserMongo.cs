using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using MongoDB.Driver;
using lab_9.DAMongo;


namespace lab_09.DAMongo
{
    public class UserMongo : IUserRepository
    {
        //private string connectionString = "";
        //private string database = "PPO2024";
        //private string collectionName = "users";
        private IMongoCollection<User> users;
        public UserMongo()
        {
            //connectionString = connectionStr;
            //var client = new MongoClient(connectionString);
            //var db = client.GetDatabase(database);
            users = DataProvider.Instance.getUserCollection();
        }
        public User readById(int id)
        {
            return users.AsQueryable().Where(u => u.Id == id).FirstOrDefault();
        }
        public User readByLogin(string login)
        {
            return users.AsQueryable().Where(u => u.Login == login).FirstOrDefault();
        }
        public List<User> readByRole(string role)
        {
            return users.AsQueryable().Where(u => u.Role == role).ToList();
        }
        public List<User> getAll()
        {
            return users.Find(_ => true).ToList();
        }
        public void create(User user)
        {
            user.Id = getAll().Count + 1;
            users.InsertOne(user);
        }
        public void update(User user)
        {
            users.ReplaceOne(u => u.Login == user.Login, user);
        }
        public void delete(int id)
        {
            var filter = Builders<User>.Filter.Eq(u => u.Id, id);
            users.DeleteOne(filter);
        }
    }
}
