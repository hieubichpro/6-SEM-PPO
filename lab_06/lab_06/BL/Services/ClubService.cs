using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using NLog;
using System;
using System.Collections.Generic;

namespace lab_03.BL.Services
{
    public class ClubService
    {
        private IClubRepository clubRepo;
        private Logger log;
        public ClubService(IClubRepository clubRepo)
        {
            log = LogManager.GetLogger("LoggerMatchService");
            this.clubRepo = clubRepo;
        }
        public void insertClub(string name)
        {
            log.Info("insert club started");
            Club club = clubRepo.readbyName(name);
            if (club == null)
            {
                club = new Club(name);
                clubRepo.create(club);
            }
            else
            {
                log.Error("insert club failed");
                throw new Exception("Уже существует");
            }
            log.Info("insert club ended");
        }
        public int getIdClubByName(string name)
        {
            log.Info("getIdClubByName started");
            Club club = clubRepo.readbyName(name);
            if (club != null)
                return club.Id;
            else
            {
                log.Error("getIdClubByName failed");
                throw new Exception("Не существует");
            }
        }

        public string getNameClubById(int id)
        {
            log.Info("getNameClubById started");
            Club club = clubRepo.readbyId(id);
            if (club != null)
                return club.Name;
            else
            {
                log.Info("getNameClubById failed");
                throw new Exception("Не существует");
            }
        }
        public List<Club> getAll()
        {
            return clubRepo.readAll();
        }
        public void modifyClub(int id, string name)
        {
            var club = clubRepo.readbyId(id);
            club.Name = name;
            clubRepo.update(club);
        }
        public void deleteClub(int id)
        {
            clubRepo.delete(id);
        }
    }
}
