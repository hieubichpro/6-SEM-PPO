using lab_03.BL.Models;
using lab_03.BL.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestBL.Mocks;

namespace TestBL.UnitTests
{
    [TestClass]
    public class LeagueServiceTests
    {
        private void compare(League l1, League l2)
        {
            Assert.AreEqual(l1.Id, l2.Id);
            Assert.AreEqual(l1.Name, l2.Name);
            Assert.AreEqual(l1.Rating, l2.Rating);
        }
        [TestMethod]
        public void TestInsertLeague()
        {
            Mock.clear();
            LeagueMock leagueMock = new LeagueMock();
            LeagueService leagueService = new LeagueService(leagueMock, null, null);

            leagueService.insertLeague("EPL", 5.0, 2);
            Assert.IsNotNull(leagueMock.readbyName("EPL"));
        }
        [TestMethod]
        public void TestInsertLeagueFail()
        {
            Mock.clear();
            LeagueMock leagueMock = new LeagueMock();
            LeagueService leagueService = new LeagueService(leagueMock, null, null);
            League l = new League("EPL", 5.0, 2);
            leagueMock.create(l);
            Assert.ThrowsException<Exception>(() => leagueService.insertLeague("EPL", 5.0, 2));
        }
        [TestMethod]
        public void TestDeleteLeague()
        {
            Mock.clear();
            LeagueMock leagueMock = new LeagueMock();
            LeagueService leagueService = new LeagueService(leagueMock, null, null);
            League l = new League("EPL", 5.0, 2);
            leagueMock.create(l);
            leagueService.deleteLeague(l.Id);
            Assert.IsNull(leagueService.getByName("EPL"));
        }
        [TestMethod]
        public void TestGetByName()
        {
            Mock.clear();
            LeagueMock leagueMock = new LeagueMock();
            LeagueService leagueService = new LeagueService(leagueMock, null, null);
            League expected = new League("EPL", 5.0, 2);
            leagueMock.create(expected);
            League actual = leagueService.getByName(expected.Name);
            compare(actual, expected);
        }
    }
}
