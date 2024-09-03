using lab_03.BL.Models;
using System.Collections.Generic;

namespace lab_03.BL.IRepositories
{
    public interface IClubRepository
    {
        Club readbyName(string name);
        Club readbyId(int id);
        void create(Club club);
    }
}
