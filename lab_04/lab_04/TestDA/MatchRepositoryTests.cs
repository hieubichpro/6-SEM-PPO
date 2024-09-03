using lab_03.BL.IRepositories;
using lab_03.BL.Services;
using lab_04.DA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestDA
{
    [TestClass]
    public class MatchRepositoryTests
    {
        [TestMethod]
        public void TestReadByIdLeague()
        {
            IMatchRepository _match = new MatchRepository();
            var matches = _match.readByIdLeague(1);
            Assert.AreEqual(2, matches.Count);
        }
        [TestMethod]
        public void TestUpdateMatch()
        {
            IMatchRepository _match = new MatchRepository();
            _match.update(new lab_03.BL.Models.Match(1, 1, 2, 4, 2, 2));
            Assert.AreEqual(_match.readByID(2).IdLeague, 1);
        }
    }
}
