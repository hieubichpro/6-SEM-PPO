using lab_03.BL.IRepositories;
using lab_03.BL.Models;
using NLog;

namespace lab_03.BL.Services

{
    public class FeedbackService
    {
        private IFeedbackRepository feedbackRepo;
        private Logger log;
        public FeedbackService(IFeedbackRepository feedbackRepo)
        {
            this.feedbackRepo = feedbackRepo;
            log = LogManager.GetLogger("LoggerMatchService");
        }

        public void insertFeedback(int grade, int idLeague)
        {
            log.Info("insert feedback started");
            Feedback feedback = new Feedback(grade, idLeague);
            feedbackRepo.create(feedback);
            log.Info("insert feedback ended");
        }
    }
}
