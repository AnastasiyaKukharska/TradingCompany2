using BusinessLogic;
using DAL.Interfaces;
using DTO;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tests
{
    [TestFixture]
    public class AuthManagerTests
    {
        private Mock<IUserDal> userDal;
        private Mock<IBasketDal> basketDal;
        private Mock<ICategoriesDal> categoryDal;
        private Mock<IBooksDal> bookDal;
        private AuthManager manager;

        [SetUp]
        public void Setup()
        {
            userDal = new Mock<IUserDal>(MockBehavior.Strict);
            basketDal= new Mock<IBasketDal>(MockBehavior.Strict);
            categoryDal = new Mock<ICategoriesDal>(MockBehavior.Strict);
            bookDal = new Mock<IBooksDal>(MockBehavior.Strict);
            manager = new AuthManager(userDal.Object, basketDal.Object, categoryDal.Object,  bookDal.Object);
        }


        [Test]
        public void LoginUserTest()
        {
            string username = "user";
            string password = "pass";

            userDal.Setup(d => d.Login(username, password)).Returns(true);
            var res = manager.Login(username, password);

            Assert.IsTrue(res);
        }
    }
}
