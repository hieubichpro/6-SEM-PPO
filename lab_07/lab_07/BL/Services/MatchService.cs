using lab_03.BL.IRepositories;
using System.Collections.Generic;
using lab_03.BL.Models;
using NLog;
using System;

namespace lab_03.BL.Services

{
    public class MatchService
    {
        private IMatchRepository matchRepo;
        private IClubRepository clubRepo;
        private Logger log;
        public MatchService(IMatchRepository matchRepo, IClubRepository clubRepo)
        {
            log = LogManager.GetLogger("LoggerMatchService");
            this.matchRepo = matchRepo;
            this.clubRepo = clubRepo;
        }

        public string getNameClubById(int id)
        {
            log.Info("get club started");
            Club c = clubRepo.readbyId(id);
            if (c == null)
            {
                log.Error("club doesnt exists");
                throw new Exception("не сущ");
            }
            log.Info("get club ended");
            return c.Name;
        }
        public List<Match> getMatchByIdLeague(int id_league)
        {
            log.Info("get matches started");
            var matches = matchRepo.readByIdLeague(id_league);
            log.Info("get matches ended");
            return matches;
        }

        public void EnterScore(int id, int homeGoal, int guestGoal)
        {
            log.Info("enter score started");
            var match = matchRepo.readByID(id);
            match.GoalHomeTeam = homeGoal;
            match.GoalGuestTeam = guestGoal;
            matchRepo.update(match);
            log.Info("enter score ended");
        }
        public Match getById(int id)
        {
            return matchRepo.readByID(id);
        }
    }
}
