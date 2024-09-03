using lab_03.BL.Models;
using System.Collections.Generic;

namespace lab_03.BL.IRepositories
{
    public interface IFeedbackRepository
    {
        void create(Feedback feedback);
        List<Feedback> readbyIDLeague(int id);
        //Feedback readbyId(int id);
        //void update(Feedback feedback);
        //void delete(Feedback feedback);
    }
}
