using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBL.Mocks
{
    public class FeedbackMock : Mock, IFeedbackRepository
    {
        public void create(Feedback feedback)
        {
            feedbacks.Add(feedback);
        }
        public Feedback readbyId(int id)
        {
            return feedbacks.FirstOrDefault(f => f.Id == id);
        }
        public void update(Feedback feedback)
        {
            feedbacks.RemoveAll(f => f.Id == feedback.Id);
            feedbacks.Add(feedback);
        }
        public void delete(Feedback feedback)
        {
            feedbacks.RemoveAll(f => f.Id == feedback.Id);
        }

    }
}
