using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using lab_9.BL.IRepositories;
using NLog;
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
        private IClubLeagueRepository clubleagueRepo;
        private Logger log;
        public LeagueService(ILeagueRepository leagueRepo, IMatchRepository matchRepo, IClubRepository clubRepo, IClubLeagueRepository clubleagueRepo)
        {
            log = LogManager.GetLogger("LoggerMatchService");
            this.leagueRepo = leagueRepo;
            this.matchRepo = matchRepo;
            this.clubRepo = clubRepo;
            this.clubleagueRepo = clubleagueRepo;
        }

        public void insertLeague(string name, double rating, int idUser)
        {
            log.Info("read league started");
            League league = leagueRepo.readbyName(name);
            log.Info("read league ended");

            if (league == null)
            {
                log.Info("created league started");
                league = new League(name, rating, idUser);
                leagueRepo.create(league);
                log.Info("created league ended");
            }
            else
            {
                log.Error("insert failed");
                throw new Exception("уже сущ");
            }
        }

        internal List<League> getByIdUser(int id)
        {
            return leagueRepo.readByIdUser(id);
        }

        public void deleteLeague(int id_league)
        {
            leagueRepo.deleteById(id_league);
        }

        public void getTableLeague(int id_league)
        {
            //return leagueRepo.getTable(id_league);
        }

        public League getByName(string name)
        {
            log.Info("read league started");
            var l = leagueRepo.readbyName(name);
            log.Info("read league ended");
            return l;
        }

        public List<League> getAll()
        {
            return leagueRepo.readAll();
        }

        public void modifyLeague(int id, string name, double rating, int idUser)
        {
            log.Info("modify league started");
            var l = leagueRepo.readById(id);
            l.Name = name;
            l.Rating = rating;
            l.IdUser = idUser;
            leagueRepo.update(l);
            log.Info("modify league ended");
        }

        public League getById(int id)
        {
            return leagueRepo.readById(id);
        }

        public void Schedule(int id_league)
        {
            List<int> idclubs = new List<int>();
            //var allClub = clubleagueRepo.getClubInLeague(id_league);
            var allClub = clubleagueRepo.getAll();

            Console.WriteLine(allClub.Count);
            foreach (var club in allClub)
            {
                idclubs.Add(club.IdClub);
            }
            for (int i = 0; i < idclubs.Count; i++)
            {
                for (int j = 0; j < idclubs.Count; j++)
                {
                    if (j == i)
                        continue;
                    matchRepo.create(new Match(id_league, idclubs[i], idclubs[j]));
                }
            }
        }
    }
}
