using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using System;
using System.Collections.Generic;

namespace lab_03.BL.Services
{
    public class ClubService
    {
        private IClubRepository clubRepo;

        public ClubService(IClubRepository clubRepo)
        {
            this.clubRepo = clubRepo;
        }
        public void insertClub(string name)
        {
            Club club = clubRepo.readbyName(name);
            if (club == null)
            {
                club = new Club(name);
                clubRepo.create(club);
            }
            else
            {
                throw new Exception("Уже существует");
            }
        }
        public int getIdClubByName(string name)
        {
            Club club = clubRepo.readbyName(name);
            if (club != null)
                return club.Id;
            else
                throw new Exception("Не существует");
        }

        public string getNameClubById(int id)
        {
            Club club = clubRepo.readbyId(id);
            if (club != null)
                return club.Name;
            else
                throw new Exception("Не существует");
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
