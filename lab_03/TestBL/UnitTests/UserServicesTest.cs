using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using lab_03.BL.Models;
using TestBL.Mocks;
using lab_03.BL.Services;

namespace TestBL.UnitTests
{
    [TestClass]
    public class UserServicesTest
    {
        public void compare(User u1, User u2)
        {
            Assert.AreEqual(u1.Id, u2.Id);
            Assert.AreEqual(u1.Login, u2.Login);
        }
        [TestMethod]
        public void TestLogin()
        {
            Mock.clear();
            var userMock = new UserMock();
            var userService = new UserService(userMock);

            string login = "abc";
            string pass = "123";

            User expected = new User("abc", pass, "Footballer", "aa");
            userMock.create(expected);

            User actual = userService.Login(login, pass);
            compare(actual, expected);
        }

        [TestMethod]
        public void TestLoginFailed1()
        {
            Mock.clear();
            var userMock = new UserMock();
            var userService = new UserService(userMock);

            string login = "abc";
            string pass = "123";

            User expected = new User(login, pass, "Footballer", "aa");
            userMock.create(expected);

            Assert.ThrowsException<Exception>(() => userService.Login(login, "456"));

        }
        [TestMethod]
        public void TestLoginFailed2()
        {
            Mock.clear();
            var userMock = new UserMock();
            var userService = new UserService(userMock);

            string login = "abc";
            string pass = "123";

            User expected = new User(login, pass, "Footballer", "aa");
            userMock.create(expected);

            Assert.ThrowsException<Exception>(() => userService.Login("aaa", pass));
        }
        [TestMethod]
        public void TestRegister()
        {
            Mock.clear();
            var userMock = new UserMock();
            var userService = new UserService(userMock);

            string login = "abc";
            string pass = "123";

            User expected = new User(login, pass, "Footballer", "aa");

            User actual = userService.Register(login, pass, "Footballer");

            compare(actual, expected);
        }
        [TestMethod]
        public void TestRegisterFailed()
        {
            Mock.clear();
            var userMock = new UserMock();
            var userService = new UserService(userMock);

            string login = "abc";
            string pass = "123";

            User u = new User(login, pass, "Footballer", "aa");
            userMock.create(u);

            Assert.ThrowsException<Exception>(() => userService.Register(login, pass, "Footballer"));
        }
        [TestMethod]
        public void TestChangePassword()
        {
            Mock.clear();
            var userMock = new UserMock();
            var userService = new UserService(userMock);

            string login = "abc";
            string pass = "123";

            User u = new User(login, pass, "Footballer", "aa");
            userMock.create(u);

            userService.ChangePassword(u, "456");

            u = userMock.readByLogin(login);
            Assert.AreEqual(u.Password, "456");
        }
    }
}
