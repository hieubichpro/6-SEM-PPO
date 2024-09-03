using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBL.Mocks
{
    public class MatchMock : Mock, IMatchRepository
    {
        public void create(Match match)
        {
            matches.Add(match);
        }
        public void update(Match match)
        {
            matches.RemoveAll(m => m.Id == match.Id);
            matches.Add(match);
        }
        public List<Match> readByIdLeague(int id_league)
        {
            List<Match> res = new List<Match>();
            foreach (Match m in matches)
            {
                if (m.IdLeague == id_league)
                    res.Add(m);
            }
            return res;
        }
        public Match readByID(int id)
        {
            return matches.FirstOrDefault(m => m.Id == id);
        }

    }
}
