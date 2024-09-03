using lab_03.BL.IRepositories;
using lab_03.BL.Services;
using lab_04.DA;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDA
{
    [TestClass]
    public class ClubRepositoryTests
    {
        [TestMethod]
        public void TestReadByName()
        {
            IClubRepository _club = new ClubRepository();

            var idClub = _club.readbyName("Arsenal").Id;
            Assert.AreEqual(idClub, 1);
        }
        [TestMethod]
        public void TestReadByID()
        {
            IClubRepository _club = new ClubRepository();

            var nameClub = _club.readbyId(1).Name;
            Assert.AreEqual(nameClub, "Arsenal");
        }
        [TestMethod]
        public void TestCreate()
        {
            IClubRepository _club = new ClubRepository();

            _club.create(new lab_03.BL.Models.Club("Monaco"));
            Assert.AreEqual(_club.readbyId(2).Name, "Monaco");
        }
    }
}
