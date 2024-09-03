using lab_03.BL.Models;
using lab_03.BL.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestBL.Mocks;

namespace TestBL.UnitTests
{
    [TestClass]
    public class ClubServiceTests
    {
        public void compare(Club c1, Club c2)
        {
            Assert.AreEqual(c1.Id, c2.Id);
            Assert.AreEqual(c1.Name, c2.Name);
        }
        [TestMethod]
        public void TestInsert()
        {
            Mock.clear();
            var clubMock = new ClubMock();
            var clubService = new ClubService(clubMock);

            string name = "chelsea";

            Club expected = new Club(name);

            clubService.insertClub(name);

            Club actual = clubMock.readbyName(name);
            compare(actual, expected);
        }
        [TestMethod]
        public void TestInsertFail()
        {
            Mock.clear();
            var clubMock = new ClubMock();
            var clubService = new ClubService(clubMock);

            string name = "chelsea";

            Club expected = new Club(name);
            clubMock.create(expected);

            Assert.ThrowsException<Exception>(() => clubService.insertClub(name));
        }
        [TestMethod]
        public void TestGetIdbyName()
        {
            Mock.clear();
            var clubMock = new ClubMock();
            var clubService = new ClubService(clubMock);

            string name = "chelsea";

            Club c = new Club(name);
            clubMock.create(c);

            int id = clubService.getIdClubByName(name);
            Assert.AreEqual(id, c.Id);
        }
        [TestMethod]
        public void TestGetNamebyId()
        {
            Mock.clear();
            var clubMock = new ClubMock();
            var clubService = new ClubService(clubMock);

            string name = "chelsea";

            Club c = new Club(name);
            clubMock.create(c);

            string n = clubService.getNameClubById(c.Id);
            Assert.AreEqual(c.Name, n);
        }
    }
}
