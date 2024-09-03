using lab_08.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_08.BL.IRepositories
{
    public interface IClubStatRepository
    {
        List<ClubStat> getAllStatistic(int id_league);
    }
}
