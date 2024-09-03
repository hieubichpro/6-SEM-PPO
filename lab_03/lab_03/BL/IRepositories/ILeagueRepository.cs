
using lab_03.BL.Models;

namespace lab_03.BL.IRepositories
{
    public interface ILeagueRepository
    {
        League readbyName(string name);
        void create(League league);
        void deleteById(int id_league);
        League readById(int id);
    }
}
