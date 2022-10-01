using Lesson1.Core.App.Services;
using NUnit.Framework;

namespace Lesson1.Tests
{
    public class AuthServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("������")]
        [TestCase("������")]
        [TestCase("�������")]
        public void Login_ShouldReturnTrue(string lastName)
        {
            // arrange

            var service = new AuthService();

            // act
            var result = service.Login(lastName);

            // assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Login_ShouldReturnTrue()
        {
            // arrange
            var lastName = "������";

            var service = new AuthService();

            // act
            var result = service.Login(lastName);
            result = service.Login(lastName);

            // assert
            Assert.IsTrue(result);
        }

        [TestCase("")]
        [TestCase(null)]
        [TestCase("TestUser")]
        [Test]
        public void Login_ShouldReturnFalse(string lastName)
        {
            // arrange

            var service = new AuthService();

            // act
            var result = service.Login(lastName);

            // assert
            Assert.IsFalse(result);
        }
    }
}