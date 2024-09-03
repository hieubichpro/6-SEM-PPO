using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBL.Mocks
{
    public class ClubMock : Mock, IClubRepository
    {
        public Club readbyName(string name)
        {
            return clubs.FirstOrDefault(c => c.Name == name);
        }
        public Club readbyId(int id)
        {
            return clubs.FirstOrDefault(c => c.Id == id);
        }
        public void create(Club club)
        {
            clubs.Add(club);
        }
    }
}
