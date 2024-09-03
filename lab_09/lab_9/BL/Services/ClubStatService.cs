using lab_03.BL.IRepositories;
using lab_08.BL.IRepositories;
using lab_08.DA;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_08.BL.Services
{
    public class ClubStatService
    {
        private IClubStatRepository clubStatRepo;
        private IMatchRepository matchRepo;
        private IClubRepository clubRepo;
        private Logger log;
        public ClubStatService(IClubStatRepository clubStatRepo, IMatchRepository matchRepo, IClubRepository clubRepo)
        {
            log = LogManager.GetLogger("LoggerMatchService");
            this.clubStatRepo = clubStatRepo;
            this.matchRepo = matchRepo;
            this.clubRepo = clubRepo;
        }
        public List<ClubStat> getTableLeague(int idLeague)
        {
            Summary(idLeague);
            return clubStatRepo.getAllByIdLeague(idLeague);
        }
        public void Summary(int idLeague)
        {
            clubStatRepo.deleteAllByIdLeague(idLeague);
            var matches = matchRepo.readByIdLeague(idLeague);
            List<int> idclubs = new List<int>();
            foreach (var match in matches)
            {
                if (!idclubs.Contains(match.IdHomeTeam))
                {
                    idclubs.Add(match.IdHomeTeam);
                }
            }
            Dictionary<int, ClubStat> stats = new Dictionary<int, ClubStat>();
            int games, wins, draws, loses, goal1, goal2;
            foreach (var id in idclubs)
            {
                games = 0;
                wins = 0;
                draws = 0;
                loses = 0;
                goal1 = 0;
                goal2 = 0;
                foreach (var match in matches)
                {
                    if (match.GoalHomeTeam != -1 && match.GoalGuestTeam != -1)
                    {
                        if (id == match.IdHomeTeam)
                        {
                            if (match.GoalHomeTeam > match.GoalGuestTeam)
                            {
                                wins++;
                            }
                            else if (match.GoalHomeTeam == match.GoalGuestTeam)
                            {
                                draws++;
                            }
                            else
                            {
                                loses++;
                            }
                            goal1 += match.GoalHomeTeam;
                            goal2 += match.GoalGuestTeam;
                            games++;
                        }
                        else if (id == match.IdGuestTeam)
                        {
                            if (match.GoalHomeTeam > match.GoalGuestTeam)
                            {
                                loses++;
                            }
                            else if (match.GoalHomeTeam == match.GoalGuestTeam)
                            {
                                draws++;
                            }
                            else
                            {
                                wins++;
                            }
                            goal1 += match.GoalGuestTeam;
                            goal2 += match.GoalHomeTeam;
                            games++;
                        }
                    }
                }
                stats.Add(id, new ClubStat(idLeague, clubRepo.readbyId(id).Name, (idclubs.Count - 1) * 2, games, wins, draws, loses, goal1, goal2, goal1 - goal2, wins * 3 + draws));
                clubStatRepo.create(stats[id]);
            }
            
        }
    }
}
