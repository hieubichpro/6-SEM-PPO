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
        private Logger log;
        public ClubStatService(IClubStatRepository clubStatRepo)
        {
            log = LogManager.GetLogger("LoggerMatchService");
            this.clubStatRepo = clubStatRepo;
        }
        public List<ClubStat> getTableLeague(int idLeague)
        {
            return clubStatRepo.getAllStatistic(idLeague);
        }
    }
}
