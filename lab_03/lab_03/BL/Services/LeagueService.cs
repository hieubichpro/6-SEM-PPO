using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace lab_03.BL.Services

{
    public class LeagueService
    {
        private ILeagueRepository leagueRepo;
        private IMatchRepository matchRepo;
        private IClubRepository clubRepo;
        public LeagueService(ILeagueRepository leagueRepo, IMatchRepository matchRepo, IClubRepository clubRepo)
        {
            this.leagueRepo = leagueRepo;
            this.matchRepo = matchRepo;
            this.clubRepo = clubRepo;
        }

        public void insertLeague(string name, double rating, int idUser)
        {
            League league = leagueRepo.readbyName(name);
            if (league == null)
            {
                league = new League(name, rating, idUser);
                leagueRepo.create(league);
            }
            else
            {
                throw new Exception("не сущ");
            }
        }

        public void deleteLeague(int id_league)
        {
            leagueRepo.deleteById(id_league);
        }
        
        public League getByName(string name)
        {
            return leagueRepo.readbyName(name);
        }
    }
}
