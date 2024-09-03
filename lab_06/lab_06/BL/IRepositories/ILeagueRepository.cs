
using lab_03.BL.Models;
using System.Collections.Generic;

namespace lab_03.BL.IRepositories
{
    public interface ILeagueRepository
    {
        League readbyName(string name);
        void create(League league);
        void deleteById(int id_league);
        League readById(int id);
        List<League> readAll();
        void update(League l);
    }
}
