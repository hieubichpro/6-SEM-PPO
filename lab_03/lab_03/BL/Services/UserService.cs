using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using System;

namespace lab_03.BL.Services

{
    public class UserService
    {
        private IUserRepository userRepo;
        public UserService(IUserRepository userRepo)
        {
            this.userRepo = userRepo;
        }

        public User Login(string login, string password)
        {
            User user = userRepo.readByLogin(login);
            if (user == null)
                throw new Exception("Не существует такого пользователя");
            else
            {
                if (!user.checkPassword(password))
                    throw new Exception("Неверный пароль");
            }
            return user;
        }

        public User Register(string login, string password, string role, string name = "")
        {
            User user = userRepo.readByLogin(login);
            if (user != null)
            {
                throw new Exception("Уже существует");
            }
            else
            {
                user = new User(login, password, role, name);
                userRepo.create(user);
                return user;
            }
        }

        public void ChangePassword(User user, string password)
        {
            user.Password = password;
            userRepo.update(user);
        }
    }
}
