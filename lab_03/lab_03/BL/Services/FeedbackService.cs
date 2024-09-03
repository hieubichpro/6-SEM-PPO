using lab_03.BL.IRepositories;
using lab_03.BL.Models;

namespace lab_03.BL.Services

{
    public class FeedbackService
    {
        private IFeedbackRepository feedbackRepo;

        public FeedbackService(IFeedbackRepository feedbackRepo)
        {
            this.feedbackRepo = feedbackRepo;
        }

        public void insertFeedback(int grade, int idLeague)
        {
            Feedback feedback = new Feedback(grade, idLeague);
            feedbackRepo.create(feedback);
        }
    }
}
