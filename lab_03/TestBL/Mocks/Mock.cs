using lab_03.BL.Models;
using System.Collections.Generic;

namespace TestBL.Mocks
{
    public class Mock
    {
        static public List<User> users = new List<User>();
        static public List<Club> clubs = new List<Club>();
        static public List<League> leagues = new List<League>();
        static public List<Feedback> feedbacks = new List<Feedback>();
        static public List<Match> matches = new List<Match>();
        static public void clear()
        {
            users.Clear();
            clubs.Clear();
            leagues.Clear();
            feedbacks.Clear();
            matches.Clear();
        }
    }
}
