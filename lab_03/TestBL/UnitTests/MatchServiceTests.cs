using lab_03.BL.Models;
using lab_03.BL.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestBL.Mocks;

namespace TestBL.UnitTests
{
    [TestClass]
    public class MatchServiceTests
    {
        private void compare(Match m1, Match m2)
        {
            Assert.AreEqual(m1.Id, m2.Id);
            Assert.AreEqual(m1.IdGuestTeam, m2.IdGuestTeam);
            Assert.AreEqual(m1.IdHomeTeam, m2.IdHomeTeam);
        }
        [TestMethod]
        public void TestGetNameClubByID()
        {
            MatchMock matchMock = new MatchMock();
            ClubMock clubMock = new ClubMock();
            MatchService matchService = new MatchService(matchMock, clubMock);
            Club c = new Club("CSKA");
            clubMock.create(c);
            string actual = matchService.getNameClubById(c.Id);
            Assert.AreEqual(c.Name, actual);
        }
        [TestMethod]
        public void TestGetMatchByIdLeague()
        {
            Mock.clear();
            MatchMock matchMock = new MatchMock();
            ClubMock clubMock = new ClubMock();
            MatchService matchService = new MatchService(matchMock, clubMock);
            matchMock.create(new Match(2, 2, 3));
            matchMock.create(new Match(2, 4, 1));
            matchMock.create(new Match(3, 5, 2));
            var actual1 = matchService.getMatchByIdLeague(2);
            var actual2 = matchService.getMatchByIdLeague(3);
            Assert.AreEqual(actual1.Count, 2);
            Assert.AreEqual(actual2.Count, 1);
        }
    }
}
