using lab_03.BL.IRepositories;
using System.Collections.Generic;
using lab_03.BL.Models;

namespace lab_03.BL.Services

{
    public class MatchService
    {
        private IMatchRepository matchRepo;
        private IClubRepository clubRepo;

        public MatchService(IMatchRepository matchRepo, IClubRepository clubRepo)
        {
            this.matchRepo = matchRepo;
            this.clubRepo = clubRepo;
        }

        public string getNameClubById(int id)
        {
            return clubRepo.readbyId(id).Name;
        }
        public List<Match> getMatchByIdLeague(int id_league)
        {
            return matchRepo.readByIdLeague(id_league);
        }
    }
}
