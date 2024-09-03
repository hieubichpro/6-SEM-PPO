using lab_03.BL.Models;
using lab_03.BL.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestBL.Mocks;

namespace TestBL.UnitTests
{
    [TestClass]
    public class FeedbackServiceTests
    {
        private void compare(Feedback f1, Feedback f2)
        {
            Assert.AreEqual(f1.Id, f2.Id);
            Assert.AreEqual(f1.Grade, f2.Grade);
        }
        [TestMethod]
        public void TestInsertFeedback()
        {
            FeedbackMock feedbackMock = new FeedbackMock();
            FeedbackService feedbackService = new FeedbackService(feedbackMock);

            Feedback f = new Feedback(4, 3);

            feedbackService.insertFeedback(4, 3);
            Assert.IsNotNull(feedbackMock.readbyId(f.Id));
        }
    }
}
