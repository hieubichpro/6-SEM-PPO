using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBL.Mocks
{
    public class LeagueMock : Mock, ILeagueRepository
    {
        public League readbyName(string name)
        {
            return leagues.FirstOrDefault(l => l.Name == name);
        }
        public void create(League league)
        {
            leagues.Add(league);
        }
        public void deleteById(int id_league)
        {
            leagues.RemoveAll(l => l.Id == id_league);
        }
        public League readById(int id)
        {
            return leagues.FirstOrDefault(l => l.Id == id);
        }
    }
}
