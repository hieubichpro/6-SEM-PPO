using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using NLog;
using System;
using System.Collections.Generic;

namespace lab_03.BL.Services

{
    public class UserService
    {
        private IUserRepository userRepo;
        private Logger log;
        public UserService(IUserRepository userRepo)
        {
            log = LogManager.GetLogger("LoggerUserService");
            this.userRepo = userRepo;
        }

        public User Login(string login, string password)
        {
            log.Info("login started");
            User user = userRepo.readByLogin(login);
            if (user == null)
            {
                log.Error("user doesn't exists");
                throw new Exception("Не существует такого пользователя");
            }
            else
            {
                if (!user.checkPassword(password))
                {
                    log.Error("password not correct");
                    throw new Exception("Неверный пароль");
                }
            }
            log.Info("login sucess");
            return user;
        }

        public void Register(string login, string password, string role, string name = "")
        {
            log.Info("register started");
            User user = userRepo.readByLogin(login);
            if (user != null)
            {
                log.Error("have been exists");
                throw new Exception("Уже существует");
            }
            else
            {
                user = new User(login, password, role, name);
                userRepo.create(user);
                log.Info("register success");
            }
        }

        public void ChangePassword(User user, string password)
        {
            user.Password = password;
            userRepo.update(user);
        }
        public void ChangeInfo(int id, string username, string password, string role, string name)
        {
            log.Info("change info started");
            User u = userRepo.readById(id);
            u.Login = username;
            u.Password = password;
            u.Role = role;
            u.Name = name;
            userRepo.update(u);
            log.Info("change info ended");
        }
        public void deleteUser(int id)
        {
            log.Info("delete started");
            userRepo.delete(id);
            log.Info("delete ended");
        }
        public List<User> getAll()
        {
            return userRepo.readByRole("Referee");
        }
        public User getbyId(int id)
        {
            return userRepo.readById(id);
        }
    }
}
