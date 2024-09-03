using lab_03.BL.IRepositories;
using lab_03.BL.Services;
using lab_04.DA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestDA
{
    [TestClass]
    public class LeagueRepositoryTests
    {
        [TestMethod]
        public void TestReadByName()
        {
            ILeagueRepository _league = new LeagueRepository();

            var league = _league.readbyName("EPL");
            Assert.AreEqual(league.IdUser, 1);
            Assert.AreEqual(league.Rating, 5);
        }
        [TestMethod]
        public void TestInsertLeague()
        {
            ILeagueRepository _league = new LeagueRepository();

            _league.create(new lab_03.BL.Models.League("Rus League", 5, 1));
            Assert.AreEqual(_league.readbyName("Rus League").IdUser, 1);
        }
        [TestMethod]
        public void TestDeleteLeague()
        {
            ILeagueRepository _league = new LeagueRepository();

            _league.deleteById(2);
            Assert.AreEqual(_league.readById(2), null);
        }
    }
}
