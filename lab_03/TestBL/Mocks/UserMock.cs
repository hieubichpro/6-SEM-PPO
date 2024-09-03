using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using System.Linq;

namespace TestBL.Mocks
{
    public class UserMock : Mock, IUserRepository
    {
        public User readById(int id)
        {
            return users.FirstOrDefault(u => u.Id == id);
        }
        public User readByLogin(string login)
        {
            return users.FirstOrDefault(u => u.Login == login);
        }
        public void create(User user)
        {
            users.Add(user);
        }
        public void update(User user)
        {
            users.RemoveAll(u => u.Id == user.Id);
            users.Add(user);
        }
    }
}
