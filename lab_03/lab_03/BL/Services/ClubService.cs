using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using System;

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
    }
}
