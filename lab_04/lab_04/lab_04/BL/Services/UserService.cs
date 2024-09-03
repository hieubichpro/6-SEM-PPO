using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using System;
using System.Collections.Generic;

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
        public void ChangeInfo(int id, string username, string password, string role, string name)
        {
            User u = userRepo.readById(id);
            u.Login = username;
            u.Password = password;
            u.Role = role;
            u.Name = name;
            userRepo.update(u);
        }
        public void deleteUser(int id)
        {
            userRepo.delete(id);
        }
        public List<User> getAll()
        {
            return userRepo.readByRole("Referee");
        }
    }
}
