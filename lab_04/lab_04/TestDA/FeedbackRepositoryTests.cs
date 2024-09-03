using lab_03.BL.IRepositories;
using lab_03.BL.Services;
using lab_04.DA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestDA
{
    [TestClass]
    public class FeedbackRepositoryTests
    {
        [TestMethod]
        public void TestInsertFeedback()
        {
            IFeedbackRepository _feedback = new FeedbackRepository();

            _feedback.create(new lab_03.BL.Models.Feedback(5, 3));
            Assert.AreEqual(_feedback.readbyIDLeague(3).Count, 1);
        }

        [TestMethod]
        public void TestGetByID()
        {
            IFeedbackRepository _feedback = new FeedbackRepository();

            var all = _feedback.readbyIDLeague(1);
            Assert.AreEqual(all.Count, 3);
        }
    }
}
