using lab_03.BL.IRepositories;
using lab_04.DA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestDA
{
    [TestClass]
    public class UserRepositoryTests
    {
        [TestMethod]
        public void TestCreate()
        {
            IUserRepository _user = new UserRepository();
            _user.create(new lab_03.BL.Models.User("forever", "alone", "Footballer", "Hieu"));
            Assert.AreEqual(_user.readByLogin("forever").Name, "Hieu");
        }
        [TestMethod]
        public void TestReadByLogin()
        {
            IUserRepository _user = new UserRepository();
            var u = _user.readByLogin("messi");
            Assert.AreEqual(u.Role, "Referee");
        }
        [TestMethod]
        public void TestReadByID()
        {
            IUserRepository _user = new UserRepository();
            var u = _user.readById(2);
            Assert.AreEqual(u.Login, "ronaldo");
            Assert.AreEqual(u.Name, "hieu");
        }
    }
}
